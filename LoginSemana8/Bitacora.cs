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
    public partial class Bitacora : Form
    {
        public string cadena_conexion = "Database=sistema;Data Source=localhost;User Id=admin;Password=admin";
        public string usuario_modificar;
        public Bitacora()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Inicio f1 = new Inicio();
            f1.Show();
            this.Hide();
        }

        private void Bitacora_Load(object sender, EventArgs e)
        {
            txtIdusuario.Enabled = false;
            txtnombre.Enabled = false;
            txtusuario.Enabled = false;
            txtfecha.Enabled = false;
            txthora.Enabled = false;
            txtrealizar.Enabled = false;
            txtrealizada.Enabled = false;
            btnguardar.Visible = false;
            btnactualizar.Visible = false;
            try
            {
                string consulta = "select * from bitacora";
                MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                MySqlDataAdapter comando = new MySqlDataAdapter(consulta, conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                comando.Fill(ds, "sistema");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "sistema";
            }
            catch (MySqlException)
            {
                MessageBox.Show("Error de conexion", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnnuevo_Click(object sender, EventArgs e)
        {
            txtIdusuario.Enabled = true;
            txtnombre.Enabled = true;
            txtusuario.Enabled = true;
            txtfecha.Enabled = true;
            txthora.Enabled = true;
            txtrealizar.Enabled = true;
            txtrealizada.Enabled = true;
            txtIdusuario.Focus();
            btnnuevo.Visible = false;
            btnguardar.Visible = true;
        }

        private void bguardar_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    MySqlConnection myConnection = new MySqlConnection(cadena_conexion);
                    string myInsertQuery = "INSERT INTO bitacora(Idusuario,nombre,usuario,fecha,hora,accion_a_realizar,accion_realizada) Values(?Idusuario,?nombre,?usuario,?fecha,?hora,?accion_a_realizar,?accion_realizada)";
                    MySqlCommand myCommand = new MySqlCommand(myInsertQuery);
                    myCommand.Parameters.Add("?Idusuario", MySqlDbType.Int32, 10).Value = txtIdusuario.Text;
                    myCommand.Parameters.Add("?nombre", MySqlDbType.VarChar, 100).Value = txtnombre.Text;
                    myCommand.Parameters.Add("?usuario", MySqlDbType.VarChar, 50).Value = txtusuario.Text;
                    myCommand.Parameters.Add("?fecha", MySqlDbType.VarChar, 50).Value = txtfecha.Text;
                    myCommand.Parameters.Add("?hora", MySqlDbType.VarChar, 15).Value = txthora.Text;
                    myCommand.Parameters.Add("?accion_a_realizar", MySqlDbType.VarChar, 100).Value = txtrealizar.Text;
                    myCommand.Parameters.Add("?accion_realizada", MySqlDbType.VarChar, 100).Value = txtrealizada.Text;

                    myCommand.Connection = myConnection;
                    myConnection.Open();
                    myCommand.ExecuteNonQuery();
                    myCommand.Connection.Close();

                    MessageBox.Show("Usuario agregado con éxito", "Ok", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                    string consulta = "select * from bitacora";

                    MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                    MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
                    System.Data.DataSet ds = new System.Data.DataSet();
                    da.Fill(ds, "sistema");
                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = "sistema";

                }
                catch (MySqlException)
                {
                    MessageBox.Show("Ya existe el usuario", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                btnnuevo.Visible = true;
                btnguardar.Visible = false;
                txtIdusuario.Enabled = false;
                txtnombre.Enabled = false;
                txtusuario.Enabled = false;
                txtfecha.Enabled = false;
                txthora.Enabled = false;
                txtrealizar.Enabled = false;
                txtrealizada.Enabled = false;
                btnnuevo.Focus();
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            {
                try
                {

                    MySqlConnection myConnection = new MySqlConnection(cadena_conexion);
                    string myInsertQuery = "DELETE FROM bitacora where nombre = '" + txtnombre.Text + "' ";
                    MySqlCommand myCommand = new MySqlCommand(myInsertQuery);

                    myCommand.Connection = myConnection;
                    myConnection.Open();
                    myCommand.ExecuteNonQuery();
                    myCommand.Connection.Close();
                    MessageBox.Show("Usuario eliminado con exito", "Usuario Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    string consulta = "select * from bitacora";

                    MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                    MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
                    System.Data.DataSet ds = new System.Data.DataSet();
                    da.Fill(ds, "sistema");
                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = "sistema";
                }
                catch (System.Exception)
                {
                    MessageBox.Show("Error al Eliminar el ususario ", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                btnnuevo.Visible = true;
                btnguardar.Visible = true;
                btnmodificar.Visible = true;
                txtusuario.Enabled = false;
                txtIdusuario.Enabled = false;
                txtnombre.Enabled = false;
                txtusuario.Enabled = false;
                txtfecha.Enabled = false;
                txthora.Enabled = false;
                txtrealizar.Enabled = false;
                txtrealizada.Enabled = false;
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    string myConnectionString = "";
                    if (myConnectionString == "")
                    {
                        myConnectionString = "Database=sistema;Data Source=localhost;User Id=admin;Password=admin";
                    }
                    MySqlConnection myConnection = new MySqlConnection(cadena_conexion);
                    string consulta = "select * from bitacora where Idusuario ='" + Convert.ToInt32(txtbuscar.Text) + "' ";
                    MySqlCommand myCommand = new MySqlCommand(consulta, myConnection);
                    myConnection.Open();
                    MySqlDataReader myReader;
                    myReader = myCommand.ExecuteReader();
                    if (myReader.Read())
                    {
                        txtIdusuario.Text = (myReader.GetString(0));
                        txtnombre.Text = (myReader.GetString(1));
                        txtusuario.Text = (myReader.GetString(2));
                        txtfecha.Text = (myReader.GetString(3));
                        txthora.Text = (myReader.GetString(4));
                        txtrealizar.Text = (myReader.GetString(5));
                        txtrealizada.Text = (myReader.GetString(6));
                    }
                    else
                    {

                    }
                    myReader.Close();
                    myConnection.Close();

                }
                catch (MySqlException k)
                {
                    MessageBox.Show(k.ToString());
                }
            }
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            txtIdusuario.Enabled = true;
            txtnombre.Enabled = true;
            txtusuario.Enabled = true;
            txtfecha.Enabled = true;
            txthora.Enabled = true;
            txtrealizar.Enabled = true;
            txtrealizada.Enabled = true;

            txtIdusuario.Focus();
            btnmodificar.Visible = false;
            btnactualizar.Visible = true;

            usuario_modificar = txtIdusuario.Text.ToString();
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    MySqlConnection myConnection = new MySqlConnection(cadena_conexion);
                    string myInsertQuery = "UPDATE bitacora SET Idusuario=?Idusuario, nombre=?nombre, usuario=?usuario, fecha=?fecha, hora=?hora, accion_a_realizar=?accion_a_realizar, accion_realizada=?accion_realizada WHERE Idusuario=?Idusuario";
                    MySqlCommand myCommand = new MySqlCommand(myInsertQuery);
                    myCommand.Parameters.Add("?Idusuario", MySqlDbType.Int32, 10).Value = txtIdusuario.Text;
                    myCommand.Parameters.Add("?nombre", MySqlDbType.VarChar, 100).Value = txtnombre.Text;
                    myCommand.Parameters.Add("?usuario", MySqlDbType.VarChar, 50).Value = txtusuario.Text;
                    myCommand.Parameters.Add("?fecha", MySqlDbType.VarChar, 50).Value = txtfecha.Text;
                    myCommand.Parameters.Add("?hora", MySqlDbType.VarChar, 15).Value = txthora.Text;
                    myCommand.Parameters.Add("?accion_a_realizar", MySqlDbType.VarChar, 100).Value = txtrealizar.Text;
                    myCommand.Parameters.Add("?accion_realizada", MySqlDbType.VarChar, 100).Value = txtrealizada.Text;

                    myCommand.Connection = myConnection;
                    myConnection.Open();
                    myCommand.ExecuteNonQuery();
                    myCommand.Connection.Close();

                    MessageBox.Show("Registro actualizado con exito", "Ok", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                    string consulta = "select * from bitacora";

                    MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                    MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
                    System.Data.DataSet ds = new System.Data.DataSet();
                    da.Fill(ds, "sistema");
                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = "sistema";

                }
                catch (MySqlException)
                {
                    MessageBox.Show("Registro no actualizado", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                btnnuevo.Visible = true;
                btnmodificar.Visible = true;
                btnguardar.Visible = false;
                txtIdusuario.Enabled = false;
                txtnombre.Enabled = false;
                txtusuario.Enabled = false;
                txtfecha.Enabled = false;
                txthora.Enabled = false;
                txtrealizar.Enabled = false;
                txtrealizada.Enabled = false;
                btnnuevo.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    MySqlConnection myConnection = new MySqlConnection(cadena_conexion);
                    string myInsertQuery = "INSERT INTO bitacora(Idusuario,nombre,usuario,fecha,hora,accion_a_realizar,accion_realizada) Values(?Idusuario,?nombre,?usuario,?fecha,?hora,?accion_a_realizar,?accion_realizada)";
                    MySqlCommand myCommand = new MySqlCommand(myInsertQuery);
                    myCommand.Parameters.Add("?Idusuario", MySqlDbType.Int32, 10).Value = txtIdusuario.Text;
                    myCommand.Parameters.Add("?nombre", MySqlDbType.VarChar, 100).Value = txtnombre.Text;
                    myCommand.Parameters.Add("?usuario", MySqlDbType.VarChar, 50).Value = txtusuario.Text;
                    myCommand.Parameters.Add("?fecha", MySqlDbType.VarChar, 50).Value = txtfecha.Text;
                    myCommand.Parameters.Add("?hora", MySqlDbType.VarChar, 15).Value = txthora.Text;
                    myCommand.Parameters.Add("?accion_a_realizar", MySqlDbType.VarChar, 100).Value = txtrealizar.Text;
                    myCommand.Parameters.Add("?accion_realizada", MySqlDbType.VarChar, 100).Value = txtrealizada.Text;

                    myCommand.Connection = myConnection;
                    myConnection.Open();
                    myCommand.ExecuteNonQuery();
                    myCommand.Connection.Close();

                    MessageBox.Show("Usuario agregado con éxito", "Ok", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                    string consulta = "select * from bitacora";

                    MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                    MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
                    System.Data.DataSet ds = new System.Data.DataSet();
                    da.Fill(ds, "sistema");
                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = "sistema";

                }
                catch (MySqlException)
                {
                    MessageBox.Show("Ya existe el usuario", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                btnnuevo.Visible = true;
                btnguardar.Visible = false;
                txtIdusuario.Enabled = false;
                txtnombre.Enabled = false;
                txtusuario.Enabled = false;
                txtfecha.Enabled = false;
                txthora.Enabled = false;
                txtrealizar.Enabled = false;
                txtrealizada.Enabled = false;
                btnnuevo.Focus();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ConsultaB f1 = new ConsultaB();
            f1.Show();
            this.Hide();
        }
    }
}
