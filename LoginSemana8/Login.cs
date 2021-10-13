using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;


namespace LoginSemana8
{
    public partial class Login : Form
    {
        OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\sistema\\BaseLogin.accdb");
        public Login()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                MessageBox.Show("conectado");
            }
            catch (Exception a)
            {
                MessageBox.Show("error por" + a.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try

            {
                OleDbConnection conexion_access = new OleDbConnection();
                conexion_access.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\\SISTEMA\\sistema.accdb ";
                conexion_access.Open();
                OleDbDataAdapter consulta = new OleDbDataAdapter("SELECT * FROM usuario", conexion_access);
                DataSet resultado = new DataSet(); consulta.Fill(resultado);
                foreach (DataRow registro in resultado.Tables[0].Rows)
                {
                    if ((txtusuario.Text == registro["nombre"].ToString()) && (txtpass.Text == registro["clave"].ToString()))
                    {

                        Inicio f3 = new Inicio();
                        f3.Show();
                        this.Hide();
                    }
                    conexion_access.Close();
                }

            }

            catch (Exception err)
            {

                MessageBox.Show(err.Message); MessageBox.Show("Error de usuario o clave de acceso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtusuario.Focus();

            }



        }
    }
}
