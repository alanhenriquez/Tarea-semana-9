﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LoginSemana8
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculadora f1 = new Calculadora();
            f1.Show();
            this.Hide();

        }

        private void conversorDePesoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Conversor f1 = new Conversor();
            f1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Acercade f2 = new Acercade();
            f2.ShowDialog();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void saludoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Saludo f1 = new Saludo();
            f1.Show();
            this.Hide();
        }

        private void ayudaParteIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ayuda f1 = new Ayuda();
            f1.Show();
            this.Hide();
        }

        private void ayudaParteIIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ayuda_II f1 = new Ayuda_II ();
            f1.Show();
            this.Hide();
        }

        private void ayudaParteIIIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ayuda_III f1 = new Ayuda_III();
            f1.Show();
            this.Hide();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Saludo f1 = new Saludo();
            f1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Calculadora f1 = new Calculadora();
            f1.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Conversor f1 = new Conversor();
            f1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conversor_de_Monedas f1 = new Conversor_de_Monedas();
            f1.Show();
            this.Hide();
        }

        private void usuariosAccessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Access f1 = new Access();
            f1.Show();
            this.Hide();
        }

        private void usuariosMySQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuariosMySQL f1 = new UsuariosMySQL();
            f1.Show();
            this.Hide();
        }

        private void bitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitacora f1 = new Bitacora();
            f1.Show();
            this.Hide();
        }
    }
}
