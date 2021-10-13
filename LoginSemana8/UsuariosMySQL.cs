using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace LoginSemana8
{
    public partial class UsuariosMySQL : Form
    {
        public string cadena_conexion = "Database=base_login;Data Source=localhost;User Id=dba;Password=dba";
        public UsuariosMySQL()
        {
            InitializeComponent();
        }

        private void UsuariosMySQL_Load(object sender, EventArgs e)
        {
            txtusuario.Enabled = false;
            txtclave.Enabled = false;
            lstnivel.Enabled = false;
            try
            {
                string consulta = "select * from tusuario";
                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter comando = new MySqlDataAdapter(consulta, conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                comando.Fill(ds, "base_login");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "base_login";
            }
            catch (MySqlException)
            {
                MessageBox.Show("Error de conexion", "Error!", MessageBoxButtons.OK,
   MessageBoxIcon.Error);
            }

        }

        private void bnuevo_Click(object sender, EventArgs e)
        {
            txtusuario.Enabled = true;
            txtclave.Enabled = true;
            lstnivel.Enabled = true;
            txtusuario.Text = "";
            txtclave.Text = "";
            lstnivel.Text = "Seleccione nivel";
            txtusuario.Focus();
            bnuevo.Visible = false;
            bguardar.Visible = true;
        }

        private void bguardar_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection myConnection = new MySqlConnection(cadena_conexion);
                string myInsertQuery = "INSERT INTO tusuario(nombre,password,nivel) Values(?nombre,?clave,?nivel)";
                MySqlCommand myCommand = new MySqlCommand(myInsertQuery);
                myCommand.Parameters.Add("?nombre", MySqlDbType.VarChar, 40).Value = txtusuario.Text;
                myCommand.Parameters.Add("?clave", MySqlDbType.VarChar, 45).Value = txtclave.Text;
                myCommand.Parameters.Add("?nivel", MySqlDbType.Int32, 4).Value = lstnivel.Text;
                myConnection.Open();
                myCommand.ExecuteNonQuery();
                myCommand.Connection.Close();

                MessageBox.Show("Usuario agregado con éxito", "Ok", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

                string consulta = "select * from tusuario";

                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "base_login");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "base_login";

            }
            catch (MySqlException)
            {
                MessageBox.Show("Ya existe el usuario", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            bnuevo.Visible = true;
            bguardar.Visible = false;
            txtusuario.Enabled = false;
            txtclave.Enabled = false;
            lstnivel.Enabled = false;
            bnuevo.Focus();
        }

        private void bmodificar_Click(object sender, EventArgs e)
        {
            txtusuario.Enabled = true;
            txtclave.Enabled = true;
            lstnivel.Enabled = true;

            txtusuario.Focus();
            bmodificar.Visible = false;
            bactualizar.Visible = true;

            //usuario_modificar = txtusuario.Text.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Inicio f1 = new Inicio();
            f1.Show();
            this.Hide();
        }
    }
}
