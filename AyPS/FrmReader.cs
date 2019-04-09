using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Drawing;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;
using System.Data;
using System.Linq;
using System.Diagnostics;
using MySql.Data.MySqlClient;
namespace AyPS
{
    public partial class FrmReader : Form
    {
        FilterInfoCollection _VideoDeviceList = new FilterInfoCollection(FilterCategory.VideoInputDevice);
        VideoCaptureDevice _VideoSource = null;
        DataTable _CurrentInfo = new DataTable();
        String _Class;
        String _ConnectionString;
        int _Elapsed;
        public FrmReader(String Class, int Elapsed,String ConnectionString)
        {
            InitializeComponent();
            foreach (FilterInfo Device in _VideoDeviceList)
            {
                CboDevices.Items.Add(Device.Name);
            }
            _Class = Class;
            _Elapsed = Elapsed;
            _ConnectionString = ConnectionString;
        }

        private void FrmReader_Load(object sender, EventArgs e)
        {
            _CurrentInfo.Columns.Add("Matricula");
            _CurrentInfo.Columns.Add("Alumno");
            _CurrentInfo.Columns.Add("Grupo");
            _CurrentInfo.Columns.Add("Asignatura");
            _CurrentInfo.Columns.Add("Hora de llegada");
            var Now = DateTime.Now.TimeOfDay;
            Console.WriteLine("Now:  "+Now);
            var ToNearestHour = TimeSpan.FromHours(Math.Ceiling(Now.TotalHours));
            Console.WriteLine("NowFromHours:  " +ToNearestHour);
            ToNearestHour=ToNearestHour.Add(new TimeSpan(_Elapsed - 1, 0, 0));
            Console.WriteLine("NowFromHours:  " + ToNearestHour);
            var Difference = (ToNearestHour - Now).TotalSeconds;
            Console.WriteLine("Seconds left to next hour :: "+ Difference);
            if ((Difference - 600) > 0)
            {
                var TimeLeftInSeconds = Difference - 600;
                int Left = (int)TimeLeftInSeconds;
                Timer.Interval = Left * 1000;
                //Timer.Interval = 60000;
                Timer.Tick += Timer_Click;
                Timer.Start(); 
            }
            else
            {
                MessageBox.Show("La aplicacion no estara disponible hasta comenzada la clase.","Tiempo insuficiente",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
        }
        private void Timer_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Time Reached, Time to close!");
            Save();
        }
        private void Save()
        {
            String Insert = "INSERT INTO assistance(Matricula,Alumno,Grupo,Asignatura,Llegada) VALUES";
            for (int i=0;i<DGVAlreadyHere.RowCount;i++)
            {
                String Formating = DGVAlreadyHere.Rows[i].Cells[4].Value.ToString();
                DateTime Formatted = DateTime.Parse(Formating);
                Formatted.ToString("YYYY-MM-DD HH:MM:SS");
                Insert += "('" + MySqlHelper.EscapeString(DGVAlreadyHere.Rows[i].Cells[1].Value.ToString())+"','"+
                    MySqlHelper.EscapeString(DGVAlreadyHere.Rows[i].Cells[0].Value.ToString())+"','"+
                    MySqlHelper.EscapeString(DGVAlreadyHere.Rows[i].Cells[2].Value.ToString())+"','"+
                    MySqlHelper.EscapeString(DGVAlreadyHere.Rows[i].Cells[3].Value.ToString()) + "','"+
                    MySqlHelper.EscapeString(Formatted.ToString("yyyy-MM-dd H:mm:ss")) +"'),";
            }
            Insert = Insert.Remove(Insert.Length-1,1);
            
            Console.WriteLine(Insert);
            try
            {
                MySqlConnection Connection = Connector.Connect(_ConnectionString);
                using (MySqlCommand Command = new MySqlCommand(Insert,Connection))
                {
                    Command.Prepare();
                    Command.ExecuteNonQuery();
                    MessageBox.Show("Class saved!","Saved!",MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void BtnGetFeed_Click(object sender, EventArgs e)
        {
            if (CboDevices.SelectedIndex==-1) { return; }
            _VideoSource = new VideoCaptureDevice(_VideoDeviceList[CboDevices.SelectedIndex].MonikerString);
            _VideoSource.NewFrame += new NewFrameEventHandler(Video_NewFrame);
            
            _VideoSource.Start();
            Console.WriteLine("Video Started...");
        }
        private void Video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitMap = (Bitmap)eventArgs.Frame.Clone();
            Scann(bitMap);
            PBFeed.Image = bitMap;
        }
        private void StopFeed()
        {
            _VideoSource.SignalToStop();
            _VideoSource.WaitForStop();
            //_VideoSource.Stop();
            //_VideoSource.WaitForStop();
            //_VideoSource = null;
            PBFeed.Image = null;
        }
        private void Scann(Bitmap FromCammera)
        {
            LuminanceSource Source = new BitmapLuminanceSource(FromCammera);
            BinaryBitmap bitmap = new BinaryBitmap(new HybridBinarizer(Source));
            Result result = new MultiFormatReader().decode(bitmap);
            if (result != null && CBAdquire.Checked)
            {
                if (IsFormatCorrect(result.Text))
                {
                    String[] Info = result.Text.Split(',');
                    MessageBox.Show("Bienvenido!  " + Info[0], "Protege el inmobiliario porfavor!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SetTextBoxText(Info[0]);
                    AddToCurrentClass(result.Text);
                    //StopFeed();
                    SetCheckBox(false);
                }
            }
            else
            {
                SetTextBoxText("Searching...");
            }
        }
        private void AddToCurrentClass(String CorrectFormatAlumnaeInfo)
        {
            DataRow Row = _CurrentInfo.NewRow();
            String[] CurrentAlumnInfo = CorrectFormatAlumnaeInfo.Split(',');
            if (!Exists(CurrentAlumnInfo[0]))
            {
                Row["Matricula"] = CurrentAlumnInfo[0];
                Row["Alumno"] = CurrentAlumnInfo[1];
                Row["Asignatura"] = _Class;
                Row["Grupo"] = CurrentAlumnInfo[2];
                Row["Hora de llegada"] = DateTime.Now;
                _CurrentInfo.Rows.Add(Row);
                UpdateDGVDataSource(true);
            }
            else
            {
                MessageBox.Show("Ya en el sistema!!, tome asiento porfavor.","Recaptura innecesaria",MessageBoxButtons.OK,MessageBoxIcon.Hand);
            }

        }
        private bool Exists(String Matricula)
        {
            DataRow[] Rows = _CurrentInfo.Select("Matricula='" + Matricula + "'");
            if (Rows.Count() > 0)
            {
                return true;
            }
            return false;
        }
        private void UpdateDGVDataSource(bool Update)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<bool>(UpdateDGVDataSource),new object[] { Update});
                return;
            }
            UpdateDGV(Update);
        }
        private void UpdateDGV(bool Update)
        {
            DGVAlreadyHere.DataSource = _CurrentInfo;
            DGVAlreadyHere.Update();
            DGVAlreadyHere.Refresh();
        }
        private bool IsFormatCorrect(String Encoded)
        {
            String[] Components = Encoded.Split(',');
            if (Components.Length==3)
            {
                return true;
            }
            return false;
        }
        private void SetCheckBox(bool Value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<bool>(SetCheckBox),new object[] {Value });
                return;
            }
            CBAdquire.Checked = Value;
        }
        private void SetTextBoxText(String Text)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<String>(SetTextBoxText), new object[] { Text});
                return;
            }
            TxtCapturedInfo.Text = Text;
        }
    }
}
