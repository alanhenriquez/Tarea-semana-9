
namespace LoginSemana8
{
    partial class UsuariosMySQL
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuariosMySQL));
            this.button11 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lstnivel = new System.Windows.Forms.ComboBox();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bactualizar = new System.Windows.Forms.Button();
            this.bguardar = new System.Windows.Forms.Button();
            this.bsalir = new System.Windows.Forms.Button();
            this.bmodificar = new System.Windows.Forms.Button();
            this.beliminar = new System.Windows.Forms.Button();
            this.bnuevo = new System.Windows.Forms.Button();
            this.bultimo = new System.Windows.Forms.Button();
            this.bsiguiente = new System.Windows.Forms.Button();
            this.banterior = new System.Windows.Forms.Button();
            this.bprimero = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtIdusuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(12, 15);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 57);
            this.button11.TabIndex = 37;
            this.button11.Text = "Inicio";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(165, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(339, 26);
            this.label4.TabIndex = 36;
            this.label4.Text = "INGRESO DE USUARIOS AL SISTEMA";
            // 
            // lstnivel
            // 
            this.lstnivel.FormattingEnabled = true;
            this.lstnivel.Location = new System.Drawing.Point(369, 200);
            this.lstnivel.Name = "lstnivel";
            this.lstnivel.Size = new System.Drawing.Size(181, 28);
            this.lstnivel.TabIndex = 35;
            // 
            // txtclave
            // 
            this.txtclave.Location = new System.Drawing.Point(369, 155);
            this.txtclave.Name = "txtclave";
            this.txtclave.Size = new System.Drawing.Size(181, 26);
            this.txtclave.TabIndex = 34;
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(369, 112);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(181, 26);
            this.txtusuario.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Nivel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Clave";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Usuario";
            // 
            // bactualizar
            // 
            this.bactualizar.Location = new System.Drawing.Point(341, 431);
            this.bactualizar.Name = "bactualizar";
            this.bactualizar.Size = new System.Drawing.Size(114, 57);
            this.bactualizar.TabIndex = 29;
            this.bactualizar.Text = "Actualizar";
            this.bactualizar.UseVisualStyleBackColor = true;
            this.bactualizar.Click += new System.EventHandler(this.bactualizar_Click);
            // 
            // bguardar
            // 
            this.bguardar.Location = new System.Drawing.Point(60, 431);
            this.bguardar.Name = "bguardar";
            this.bguardar.Size = new System.Drawing.Size(114, 57);
            this.bguardar.TabIndex = 28;
            this.bguardar.Text = "Guardar";
            this.bguardar.UseVisualStyleBackColor = true;
            this.bguardar.Click += new System.EventHandler(this.bguardar_Click);
            // 
            // bsalir
            // 
            this.bsalir.Location = new System.Drawing.Point(487, 355);
            this.bsalir.Name = "bsalir";
            this.bsalir.Size = new System.Drawing.Size(114, 57);
            this.bsalir.TabIndex = 27;
            this.bsalir.Text = "Salir";
            this.bsalir.UseVisualStyleBackColor = true;
            this.bsalir.Click += new System.EventHandler(this.bsalir_Click);
            // 
            // bmodificar
            // 
            this.bmodificar.Location = new System.Drawing.Point(341, 355);
            this.bmodificar.Name = "bmodificar";
            this.bmodificar.Size = new System.Drawing.Size(114, 57);
            this.bmodificar.TabIndex = 26;
            this.bmodificar.Text = "Modificar";
            this.bmodificar.UseVisualStyleBackColor = true;
            this.bmodificar.Click += new System.EventHandler(this.bmodificar_Click);
            // 
            // beliminar
            // 
            this.beliminar.Location = new System.Drawing.Point(211, 355);
            this.beliminar.Name = "beliminar";
            this.beliminar.Size = new System.Drawing.Size(114, 57);
            this.beliminar.TabIndex = 25;
            this.beliminar.Text = "Eliminar";
            this.beliminar.UseVisualStyleBackColor = true;
            this.beliminar.Click += new System.EventHandler(this.beliminar_Click);
            // 
            // bnuevo
            // 
            this.bnuevo.Location = new System.Drawing.Point(60, 355);
            this.bnuevo.Name = "bnuevo";
            this.bnuevo.Size = new System.Drawing.Size(114, 57);
            this.bnuevo.TabIndex = 24;
            this.bnuevo.Text = "Nuevo";
            this.bnuevo.UseVisualStyleBackColor = true;
            this.bnuevo.Click += new System.EventHandler(this.bnuevo_Click);
            // 
            // bultimo
            // 
            this.bultimo.Location = new System.Drawing.Point(487, 270);
            this.bultimo.Name = "bultimo";
            this.bultimo.Size = new System.Drawing.Size(114, 57);
            this.bultimo.TabIndex = 23;
            this.bultimo.Text = "Ultimo";
            this.bultimo.UseVisualStyleBackColor = true;
            // 
            // bsiguiente
            // 
            this.bsiguiente.Location = new System.Drawing.Point(341, 270);
            this.bsiguiente.Name = "bsiguiente";
            this.bsiguiente.Size = new System.Drawing.Size(114, 57);
            this.bsiguiente.TabIndex = 22;
            this.bsiguiente.Text = "Siguiente";
            this.bsiguiente.UseVisualStyleBackColor = true;
            // 
            // banterior
            // 
            this.banterior.Location = new System.Drawing.Point(211, 270);
            this.banterior.Name = "banterior";
            this.banterior.Size = new System.Drawing.Size(114, 57);
            this.banterior.TabIndex = 21;
            this.banterior.Text = "Anterior";
            this.banterior.UseVisualStyleBackColor = true;
            // 
            // bprimero
            // 
            this.bprimero.Location = new System.Drawing.Point(60, 270);
            this.bprimero.Name = "bprimero";
            this.bprimero.Size = new System.Drawing.Size(114, 57);
            this.bprimero.TabIndex = 20;
            this.bprimero.Text = "Primero";
            this.bprimero.UseVisualStyleBackColor = true;
            this.bprimero.Click += new System.EventHandler(this.bprimero_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(635, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(293, 279);
            this.dataGridView1.TabIndex = 38;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(635, 78);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(181, 26);
            this.txtbuscar.TabIndex = 39;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(822, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 42);
            this.button1.TabIndex = 40;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtIdusuario
            // 
            this.txtIdusuario.Location = new System.Drawing.Point(369, 78);
            this.txtIdusuario.Name = "txtIdusuario";
            this.txtIdusuario.Size = new System.Drawing.Size(181, 26);
            this.txtIdusuario.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(263, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 42;
            this.label5.Text = "Idusuario";
            // 
            // UsuariosMySQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(940, 497);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIdusuario);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstnivel);
            this.Controls.Add(this.txtclave);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bactualizar);
            this.Controls.Add(this.bguardar);
            this.Controls.Add(this.bsalir);
            this.Controls.Add(this.bmodificar);
            this.Controls.Add(this.beliminar);
            this.Controls.Add(this.bnuevo);
            this.Controls.Add(this.bultimo);
            this.Controls.Add(this.bsiguiente);
            this.Controls.Add(this.banterior);
            this.Controls.Add(this.bprimero);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UsuariosMySQL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso de Usuarios";
            this.Load += new System.EventHandler(this.UsuariosMySQL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox lstnivel;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bactualizar;
        private System.Windows.Forms.Button bguardar;
        private System.Windows.Forms.Button bsalir;
        private System.Windows.Forms.Button bmodificar;
        private System.Windows.Forms.Button beliminar;
        private System.Windows.Forms.Button bnuevo;
        private System.Windows.Forms.Button bultimo;
        private System.Windows.Forms.Button bsiguiente;
        private System.Windows.Forms.Button banterior;
        private System.Windows.Forms.Button bprimero;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtIdusuario;
        private System.Windows.Forms.Label label5;
    }
}