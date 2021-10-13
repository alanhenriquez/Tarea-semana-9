using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginSemana8
{
    public partial class Conversor_de_Monedas : Form
    {
        public Conversor_de_Monedas()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double dolar, euro, yenes, btc, libra_esterlina;
            try
            {
                dolar = Convert.ToDouble(textBox1.Text);
                euro = dolar / 1.2028;
                yenes = dolar / 0.0092;
                btc = dolar / 54644.80;
                libra_esterlina = dolar / 1.3962;
                textBox2.Text = dolar.ToString();
                textBox3.Text = dolar.ToString();
                textBox6.Text = dolar.ToString();
                textBox8.Text = dolar.ToString();
                textBox4.Text = euro.ToString();
                textBox5.Text = yenes.ToString();
                textBox7.Text = btc.ToString();
                textBox9.Text = libra_esterlina.ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox6.Text = string.Empty;
            textBox8.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox7.Text = string.Empty;
            textBox9.Text = string.Empty;
            textBox1.Focus();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "Confirme Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                Inicio f1 = new Inicio();
                f1.Show();
                this.Hide();
            }
        }
    }
}
