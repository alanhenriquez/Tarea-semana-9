﻿using System;
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
        public string cadena_conexion = "Database=sistema;Data Source=localhost;User Id=admin;Password=admin";
        public string usuario_modificar;
        public UsuariosMySQL()
        {
            InitializeComponent();
        }

        //static string conexion = "SERVER"
        private void UsuariosMySQL_Load(object sender, EventArgs e)
        {
            txtusuario.Enabled = false;
            txtclave.Enabled = false;
            lstnivel.Enabled = false;
            bguardar.Visible = false;
            bactualizar.Visible = false;
            try
            {
                string consulta = "select * from usuarios";
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
            {
                try
                {
                    MySqlConnection myConnection = new MySqlConnection(cadena_conexion);
                    string myInsertQuery = "INSERT INTO usuarios(nombre,clave,nivel) Values(?nombre,?clave,?nivel)";
                    MySqlCommand myCommand = new MySqlCommand(myInsertQuery);
                    myCommand.Parameters.Add("?nombre", MySqlDbType.VarChar, 50).Value = txtusuario.Text;
                    myCommand.Parameters.Add("?clave", MySqlDbType.VarChar, 50).Value = txtclave.Text;
                    myCommand.Parameters.Add("?nivel", MySqlDbType.Int32, 10).Value = lstnivel.Text;

                    myCommand.Connection = myConnection;
                    myConnection.Open();
                    myCommand.ExecuteNonQuery();
                    myCommand.Connection.Close();

                    MessageBox.Show("Usuario agregado con éxito", "Ok", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                    string consulta = "select * from usuarios";

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

                bnuevo.Visible = true;
                bguardar.Visible = false;
                txtusuario.Enabled = false;
                txtclave.Enabled = false;
                lstnivel.Enabled = false;
                bnuevo.Focus();
            }
            }

        private void bmodificar_Click(object sender, EventArgs e)
        {
            txtusuario.Enabled = true;
            txtclave.Enabled = true;
            lstnivel.Enabled = true;

            txtusuario.Focus();
            bmodificar.Visible = false;
            bactualizar.Visible = true;

            usuario_modificar = txtusuario.Text.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
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
                    string consulta = "select * from usuarios where Idusuario ='" + Convert.ToInt32(txtbuscar.Text) + "' ";
                    MySqlCommand myCommand = new MySqlCommand(consulta, myConnection);
                    myConnection.Open();
                    MySqlDataReader myReader;
                    myReader = myCommand.ExecuteReader();
                    if (myReader.Read())
                    {
                        txtIdusuario.Text = (myReader.GetString(0));
                        txtusuario.Text = (myReader.GetString(1));
                        txtclave.Text = (myReader.GetString(2));
                        lstnivel.Text = (myReader.GetString(3));
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

        private void button11_Click(object sender, EventArgs e)
        {
            Inicio f1 = new Inicio();
            f1.Show();
            this.Hide();
        }

        private void beliminar_Click(object sender, EventArgs e)
        {
            {
                try
                {

                    MySqlConnection myConnection = new MySqlConnection(cadena_conexion);
                    string myInsertQuery = "DELETE FROM usuarios where Idusuario = '" + Convert.ToInt32(txtusuario.Text) + "' ";
                    MySqlCommand myCommand = new MySqlCommand(myInsertQuery);

                    myCommand.Connection = myConnection;
                    myConnection.Open();
                    myCommand.ExecuteNonQuery();
                    myCommand.Connection.Close();
                    MessageBox.Show("Usuario eliminado con exito", "Usuario Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    string consulta = "select * from usuarios";

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
                bnuevo.Visible = true;
                bguardar.Visible = true;

                txtusuario.Enabled = false;
                txtclave.Enabled = false;
                lstnivel.Enabled = false;
            }
        }

        private void bactualizar_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    MySqlConnection myConnection = new MySqlConnection(cadena_conexion);

                    
                    string nombre = txtusuario.Text.ToString();
                    string clave = txtclave.Text.ToString();
                    string nivel = lstnivel.Text.ToString();


                    string MyInsertQuery = "UPDATE usuarios SET nombre = '" + nombre + "' clave = '" + clave + "', nivel = '" + nivel + "'  WHERE nombre ='" + txtusuario.Text + "'";

                    MySqlCommand myCommand = new MySqlCommand(MyInsertQuery);

                    myCommand.Connection = myConnection;
                    myConnection.Open();
                    myCommand.ExecuteNonQuery();
                    myCommand.Connection.Close();
                    MessageBox.Show("Usuario Actializado con exito", "Actualizacon completa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    string consulta = "select * from usuarios";

                    MySqlConnection conexion = new MySqlConnection(cadena_conexion);
                    MySqlDataAdapter da = new MySqlDataAdapter(consulta, conexion);
                    System.Data.DataSet ds = new System.Data.DataSet();
                    da.Fill(ds, "sistema");
                    dataGridView1.DataSource = ds;
                    dataGridView1.DataMember = "sistema";
                }
                catch (System.Exception)
                {
                    MessageBox.Show("El usuario no se puede actualizar ", " Actualizacion incompleta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                bmodificar.Visible = true;
                bactualizar.Visible = false;

                txtusuario.Enabled = false;
                txtclave.Enabled = false;
                lstnivel.Enabled = false;

            }
        }

        private void bsalir_Click(object sender, EventArgs e)
        {
            Inicio f1 = new Inicio();
            f1.Show();
            this.Hide();
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void bprimero_Click(object sender, EventArgs e)
        {

        }
    }
}
