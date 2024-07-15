namespace PjEconomica.Formularios.Formularios_Anualidades
{
    partial class FrmAnualidadAnticipada
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
            label2 = new Label();
            pictureBox1 = new PictureBox();
            btnpre = new Button();
            btnFu = new Button();
            btnAnuPre = new Button();
            btnAnuFu = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(207, 27);
            label1.Name = "label1";
            label1.Size = new Size(431, 35);
            label1.TabIndex = 0;
            label1.Text = "¿Qué es una Anualidad Anticipada?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(281, 86);
            label2.Name = "label2";
            label2.Size = new Size(394, 140);
            label2.TabIndex = 1;
            label2.Text = "Es aquella serie de pagos en las \r\nque los pagos se presentan a \r\ninicios de cada periodo de capitalización\r\ny el último se produce en un periodo antes \r\ndel plazo de la anualidad";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Anualidad;
            pictureBox1.Location = new Point(56, 86);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(209, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btnpre
            // 
            btnpre.BackColor = Color.White;
            btnpre.Font = new Font("Sitka Text", 9.749999F);
            btnpre.Location = new Point(12, 254);
            btnpre.Name = "btnpre";
            btnpre.Size = new Size(136, 44);
            btnpre.TabIndex = 3;
            btnpre.Text = "Presente";
            btnpre.UseVisualStyleBackColor = false;
            btnpre.Click += btnpre_Click;
            // 
            // btnFu
            // 
            btnFu.BackColor = Color.White;
            btnFu.Font = new Font("Sitka Text", 9.749999F);
            btnFu.Location = new Point(217, 254);
            btnFu.Name = "btnFu";
            btnFu.Size = new Size(136, 44);
            btnFu.TabIndex = 4;
            btnFu.Text = "Futuro";
            btnFu.UseVisualStyleBackColor = false;
            btnFu.Click += btnFu_Click;
            // 
            // btnAnuPre
            // 
            btnAnuPre.BackColor = Color.White;
            btnAnuPre.Font = new Font("Sitka Text", 9.749999F);
            btnAnuPre.Location = new Point(403, 254);
            btnAnuPre.Name = "btnAnuPre";
            btnAnuPre.Size = new Size(151, 44);
            btnAnuPre.TabIndex = 5;
            btnAnuPre.Text = "Anualidad Presente";
            btnAnuPre.UseVisualStyleBackColor = false;
            btnAnuPre.Click += btnAnuPre_Click;
            // 
            // btnAnuFu
            // 
            btnAnuFu.BackColor = Color.White;
            btnAnuFu.Font = new Font("Sitka Text", 9.749999F);
            btnAnuFu.Location = new Point(587, 254);
            btnAnuFu.Name = "btnAnuFu";
            btnAnuFu.Size = new Size(136, 44);
            btnAnuFu.TabIndex = 6;
            btnAnuFu.Text = "Anualidad Futuro";
            btnAnuFu.UseVisualStyleBackColor = false;
            btnAnuFu.Click += btnAnuFu_Click;
            // 
            // FrmAnualidadAnticipada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 315);
            Controls.Add(btnAnuFu);
            Controls.Add(btnAnuPre);
            Controls.Add(btnFu);
            Controls.Add(btnpre);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmAnualidadAnticipada";
            Text = "FrmAnualidadAnticipada";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Button btnpre;
        private Button btnFu;
        private Button btnAnuPre;
        private Button btnAnuFu;
    }
}