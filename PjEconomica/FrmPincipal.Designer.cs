namespace PjEconomica
{
    partial class FrmPincipal
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
            label1 = new Label();
            btnInteres = new Button();
            btnAnualidades = new Button();
            btnIndicadores = new Button();
            btnGradientes = new Button();
            btnCalendario = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(249, 21);
            label1.Name = "label1";
            label1.Size = new Size(278, 60);
            label1.TabIndex = 0;
            label1.Text = "         ¡Bienvenido...!\r\n¿Qué le gustaría calcular?";
            // 
            // btnInteres
            // 
            btnInteres.BackColor = Color.White;
            btnInteres.Font = new Font("Sitka Text", 11.249999F, FontStyle.Bold);
            btnInteres.Location = new Point(75, 251);
            btnInteres.Name = "btnInteres";
            btnInteres.Size = new Size(103, 47);
            btnInteres.TabIndex = 1;
            btnInteres.Text = "Intereses";
            btnInteres.UseVisualStyleBackColor = false;
            btnInteres.Click += btnInteres_Click;
            // 
            // btnAnualidades
            // 
            btnAnualidades.BackColor = Color.White;
            btnAnualidades.Font = new Font("Sitka Text", 11.249999F, FontStyle.Bold);
            btnAnualidades.Location = new Point(554, 251);
            btnAnualidades.Name = "btnAnualidades";
            btnAnualidades.Size = new Size(113, 47);
            btnAnualidades.TabIndex = 2;
            btnAnualidades.Text = "Anualidades";
            btnAnualidades.UseVisualStyleBackColor = false;
            btnAnualidades.Click += btnAnualidades_Click;
            // 
            // btnIndicadores
            // 
            btnIndicadores.BackColor = Color.White;
            btnIndicadores.Font = new Font("Sitka Text", 11.249999F, FontStyle.Bold);
            btnIndicadores.Location = new Point(148, 449);
            btnIndicadores.Name = "btnIndicadores";
            btnIndicadores.Size = new Size(128, 42);
            btnIndicadores.TabIndex = 3;
            btnIndicadores.Text = "Indicadores";
            btnIndicadores.UseVisualStyleBackColor = false;
            btnIndicadores.Click += button3_Click;
            // 
            // btnGradientes
            // 
            btnGradientes.BackColor = Color.White;
            btnGradientes.Font = new Font("Sitka Text", 11.249999F, FontStyle.Bold);
            btnGradientes.Location = new Point(316, 251);
            btnGradientes.Name = "btnGradientes";
            btnGradientes.Size = new Size(103, 47);
            btnGradientes.TabIndex = 4;
            btnGradientes.Text = "Gradientes";
            btnGradientes.UseVisualStyleBackColor = false;
            btnGradientes.Click += btnGradientes_Click;
            // 
            // btnCalendario
            // 
            btnCalendario.BackColor = Color.White;
            btnCalendario.Font = new Font("Sitka Text", 11.249999F, FontStyle.Bold);
            btnCalendario.Location = new Point(396, 449);
            btnCalendario.Name = "btnCalendario";
            btnCalendario.Size = new Size(187, 42);
            btnCalendario.TabIndex = 5;
            btnCalendario.Text = "Calendario de Pago";
            btnCalendario.UseVisualStyleBackColor = false;
            btnCalendario.Click += btnCalendario_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.interes;
            pictureBox1.Location = new Point(64, 125);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Indicadores;
            pictureBox2.Location = new Point(135, 316);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(154, 113);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Gradientes1;
            pictureBox4.Location = new Point(294, 125);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(149, 120);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 14;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.Calendario_de_pago;
            pictureBox5.Location = new Point(392, 316);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(191, 113);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 15;
            pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Anualidad1;
            pictureBox3.Location = new Point(540, 125);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(137, 120);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            // 
            // FrmPincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(760, 526);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnCalendario);
            Controls.Add(btnGradientes);
            Controls.Add(btnIndicadores);
            Controls.Add(btnAnualidades);
            Controls.Add(btnInteres);
            Controls.Add(label1);
            Cursor = Cursors.Hand;
            Name = "FrmPincipal";
            Text = "FrmPincipal";
            Load += FrmPincipal_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnInteres;
        private Button btnAnualidades;
        private Button btnIndicadores;
        private Button btnGradientes;
        private Button btnCalendario;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox3;
    }
}