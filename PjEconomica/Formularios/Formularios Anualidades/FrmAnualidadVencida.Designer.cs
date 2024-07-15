namespace PjEconomica.Formularios.Formularios_Anualidades
{
    partial class FrmAnualidadVencida
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
            btnAnuFu = new Button();
            btnAnuPre = new Button();
            btnFu = new Button();
            btnpre = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAnuFu
            // 
            btnAnuFu.BackColor = Color.White;
            btnAnuFu.Font = new Font("Sitka Text", 9.749999F);
            btnAnuFu.Location = new Point(601, 247);
            btnAnuFu.Name = "btnAnuFu";
            btnAnuFu.Size = new Size(136, 44);
            btnAnuFu.TabIndex = 13;
            btnAnuFu.Text = "Anualidad Futuro";
            btnAnuFu.UseVisualStyleBackColor = false;
            btnAnuFu.Click += btnAnuFu_Click;
            // 
            // btnAnuPre
            // 
            btnAnuPre.BackColor = Color.White;
            btnAnuPre.Font = new Font("Sitka Text", 9.749999F);
            btnAnuPre.Location = new Point(417, 247);
            btnAnuPre.Name = "btnAnuPre";
            btnAnuPre.Size = new Size(151, 44);
            btnAnuPre.TabIndex = 12;
            btnAnuPre.Text = "Anualidad Presente";
            btnAnuPre.UseVisualStyleBackColor = false;
            btnAnuPre.Click += btnAnuPre_Click;
            // 
            // btnFu
            // 
            btnFu.BackColor = Color.White;
            btnFu.Font = new Font("Sitka Text", 9.749999F);
            btnFu.Location = new Point(231, 247);
            btnFu.Name = "btnFu";
            btnFu.Size = new Size(136, 44);
            btnFu.TabIndex = 11;
            btnFu.Text = "Futuro";
            btnFu.UseVisualStyleBackColor = false;
            btnFu.Click += btnFu_Click;
            // 
            // btnpre
            // 
            btnpre.BackColor = Color.White;
            btnpre.Font = new Font("Sitka Text", 9.749999F);
            btnpre.Location = new Point(26, 247);
            btnpre.Name = "btnpre";
            btnpre.Size = new Size(136, 44);
            btnpre.TabIndex = 10;
            btnpre.Text = "Presente";
            btnpre.UseVisualStyleBackColor = false;
            btnpre.Click += btnpre_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Anualidad;
            pictureBox1.Location = new Point(70, 79);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(209, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(294, 79);
            label2.Name = "label2";
            label2.Size = new Size(419, 140);
            label2.TabIndex = 8;
            label2.Text = "Es aquella serie de pagos en la cual\r\nlos pagos son efectuados al final de \r\ncada intervalo de pago, es decir, que \r\nel primer pago se hace al final del \r\nprimer intervalo de pago y así sucesivamente.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(221, 20);
            label1.Name = "label1";
            label1.Size = new Size(407, 35);
            label1.TabIndex = 7;
            label1.Text = "¿Qué es una Anualidad Vencidas?";
            // 
            // FrmAnualidadVencida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 306);
            Controls.Add(btnAnuFu);
            Controls.Add(btnAnuPre);
            Controls.Add(btnFu);
            Controls.Add(btnpre);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmAnualidadVencida";
            Text = "FrmAnualidadVencida";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAnuFu;
        private Button btnAnuPre;
        private Button btnFu;
        private Button btnpre;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
    }
}