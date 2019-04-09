using System;
using System.Drawing;
using System.Windows.Forms;
using QRCoder;

namespace AyPS
{
    public partial class FrmUsersCodesGenerator : Form
    {
        Bitmap _CurrentCode = null;
        public FrmUsersCodesGenerator()
        {
            InitializeComponent();
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput())
                {
                    MessageBox.Show("La informacion proporcionada es insuficiente!","Advertencia!",
                        MessageBoxButtons.OK,MessageBoxIcon.Information);
                    return;
                }
                String ToEncode = TxtName.Text + "," + TxtRegistrationCode.Text + ","+TxtGroup.Text;
                QRCodeGenerator Generator = new QRCodeGenerator();
                QRCodeData Data = Generator.CreateQrCode(ToEncode,QRCodeGenerator.ECCLevel.H);
                QRCode Code = new QRCode(Data);
                _CurrentCode = Code.GetGraphic(20);
                PBCode.Image = _CurrentCode;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo ha salido mal!"+Environment.NewLine+"Intente nuevamente","Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
            }
        }

        private bool ValidateInput()
        {
            if (String.IsNullOrWhiteSpace(TxtName.Text) 
                |string.IsNullOrWhiteSpace(TxtRegistrationCode.Text) | String.IsNullOrWhiteSpace(TxtGroup.Text))
            {
                return false;
            }
            return true;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            _CurrentCode = null;
            TxtName.Text = string.Empty;
            TxtRegistrationCode.Text = string.Empty;
            PBCode.Image = null;
            TxtGroup.Text = "";
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            if (_CurrentCode == null)
            {
                MessageBox.Show("Es necesario generar el codigo primero!","Informacion insuficiente!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            FolderBrowserDialog Dialog = new FolderBrowserDialog();
            DialogResult Result = Dialog.ShowDialog();
            if (Result==DialogResult.OK && !string.IsNullOrWhiteSpace(Dialog.SelectedPath))
            {
                try
                {
                    _CurrentCode.Save(Dialog.SelectedPath+@"\"+TxtRegistrationCode.Text+".Jpeg",System.Drawing.Imaging.ImageFormat.Jpeg);
                    MessageBox.Show("Exportado exitosamente!","Finalizado!",MessageBoxButtons.OK,MessageBoxIcon.Hand);
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error!"+Environment.NewLine+"Intenta de nuevo!","Error",
                        MessageBoxButtons.OK,MessageBoxIcon.Error);
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void FrmUsersCodesGenerator_Load(object sender, EventArgs e)
        {

        }
    }
}
