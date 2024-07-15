namespace PjEconomica.Formularios.Formularios_Gradientes
{
    partial class FrmGradienteGeométrico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGradienteGeométrico));
            btnAnualidad = new Button();
            btnFuturo = new Button();
            btnPresente = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAnualidad
            // 
            btnAnualidad.BackColor = Color.White;
            btnAnualidad.Font = new Font("Sitka Text", 12F);
            btnAnualidad.Location = new Point(577, 264);
            btnAnualidad.Name = "btnAnualidad";
            btnAnualidad.Size = new Size(129, 31);
            btnAnualidad.TabIndex = 19;
            btnAnualidad.Text = "Anualidad";
            btnAnualidad.UseVisualStyleBackColor = false;
            btnAnualidad.Click += btnAnualidad_Click;
            // 
            // btnFuturo
            // 
            btnFuturo.BackColor = Color.White;
            btnFuturo.Font = new Font("Sitka Text", 12F);
            btnFuturo.Location = new Point(323, 264);
            btnFuturo.Name = "btnFuturo";
            btnFuturo.Size = new Size(129, 31);
            btnFuturo.TabIndex = 18;
            btnFuturo.Text = "Futuro";
            btnFuturo.UseVisualStyleBackColor = false;
            btnFuturo.Click += btnFuturo_Click;
            // 
            // btnPresente
            // 
            btnPresente.BackColor = Color.White;
            btnPresente.Font = new Font("Sitka Text", 12F);
            btnPresente.Location = new Point(56, 264);
            btnPresente.Name = "btnPresente";
            btnPresente.Size = new Size(129, 31);
            btnPresente.TabIndex = 17;
            btnPresente.Text = "Presente";
            btnPresente.UseVisualStyleBackColor = false;
            btnPresente.Click += btnPresente_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.images3;
            pictureBox1.Location = new Point(56, 85);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(185, 153);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(273, 85);
            label2.Name = "label2";
            label2.Size = new Size(372, 138);
            label2.TabIndex = 15;
            label2.Text = resources.GetString("label2.Text");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(77, 25);
            label1.Name = "label1";
            label1.Size = new Size(601, 35);
            label1.TabIndex = 14;
            label1.Text = "¿Qué son las series con crecimiento geométricos?";
            // 
            // FrmGradienteGeométrico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 321);
            Controls.Add(btnAnualidad);
            Controls.Add(btnFuturo);
            Controls.Add(btnPresente);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmGradienteGeométrico";
            Text = "FrmGradienteGeométrico";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAnualidad;
        private Button btnFuturo;
        private Button btnPresente;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
    }
}