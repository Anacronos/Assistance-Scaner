using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace AyPS
{
    public partial class FrmMainMenu : Form
    {
        String _ConnectionString = "";
        public FrmMainMenu()
        {
            InitializeComponent();
        }

        private void FrmMainMenu_Load(object sender, EventArgs e)
        {
            
            String SelectAsignatures = "SELECT Name FROM Asignatures";
            MySqlConnection Connection = Connector.Connect(_ConnectionString);
            if (Connection != null)
            {
                using (MySqlCommand Command = new MySqlCommand(SelectAsignatures, Connection))
                {
                    MySqlDataReader Reader = Command.ExecuteReader();
                    while (Reader.Read())
                    {
                        CboClass.Items.Add(Reader.GetValue(0));
                    }
                }
            }
            else
            {
                MessageBox.Show("La conexion ha fallado, revise la consola para mas informacion!", "Error de conexion", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            
        }

        private void BtnChecker_Click(object sender, EventArgs e)
        {
            if (CboClass.SelectedIndex==-1)
            {
                MessageBox.Show("Seleccione una clase primero!!","Informacion insuficiente!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;

            }
            int CurrentElapsed = 2;
            if (!String.IsNullOrWhiteSpace(TxtElapsed.Text))
            {
                if (!Int32.TryParse(TxtElapsed.Text, out CurrentElapsed))
                {
                    MessageBox.Show("La conversion a entero del valor 'Duracion' fallo el valor tomado fue el default","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            FrmReader Reader = new FrmReader(CboClass.Text,CurrentElapsed,_ConnectionString);
            Reader.ShowDialog();
        }

        private void BtnCodeGenerator_Click(object sender, EventArgs e)
        {
            FrmUsersCodesGenerator Generator = new FrmUsersCodesGenerator();
            Generator.ShowDialog();
        }
    }
}
