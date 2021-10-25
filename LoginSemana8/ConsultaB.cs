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
    public partial class ConsultaB : Form
    {
        public string cadena_conexion = "Database=sistema;Data Source=localhost;User Id=admin;Password=admin";
        public ConsultaB()
        {
            InitializeComponent();
        }

        private void ConsultaB_Load(object sender, EventArgs e)
        {
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

        private void button1_Click(object sender, EventArgs e)
        {
            Bitacora f1 = new Bitacora();
            f1.Show();
            this.Hide();
        }
    }
}
