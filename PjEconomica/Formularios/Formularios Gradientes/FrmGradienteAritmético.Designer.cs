namespace PjEconomica.Formularios.Formularios_Gradientes
{
    partial class FrmGradienteAritmético
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGradienteAritmético));
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            btnPresente = new Button();
            btnFuturo = new Button();
            btnAnualidad = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.images3;
            pictureBox1.Location = new Point(36, 95);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(185, 153);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(249, 95);
            label2.Name = "label2";
            label2.Size = new Size(437, 138);
            label2.TabIndex = 9;
            label2.Text = resources.GetString("label2.Text");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(105, 34);
            label1.Name = "label1";
            label1.Size = new Size(581, 35);
            label1.TabIndex = 8;
            label1.Text = "¿Qué son las series con crecimiento aritmético?";
            // 
            // btnPresente
            // 
            btnPresente.BackColor = Color.White;
            btnPresente.Font = new Font("Sitka Text", 12F);
            btnPresente.Location = new Point(36, 274);
            btnPresente.Name = "btnPresente";
            btnPresente.Size = new Size(129, 31);
            btnPresente.TabIndex = 11;
            btnPresente.Text = "Presente";
            btnPresente.UseVisualStyleBackColor = false;
            btnPresente.Click += btnPresente_Click;
            // 
            // btnFuturo
            // 
            btnFuturo.BackColor = Color.White;
            btnFuturo.Font = new Font("Sitka Text", 12F);
            btnFuturo.Location = new Point(303, 274);
            btnFuturo.Name = "btnFuturo";
            btnFuturo.Size = new Size(129, 31);
            btnFuturo.TabIndex = 12;
            btnFuturo.Text = "Futuro";
            btnFuturo.UseVisualStyleBackColor = false;
            btnFuturo.Click += btnFuturo_Click;
            // 
            // btnAnualidad
            // 
            btnAnualidad.BackColor = Color.White;
            btnAnualidad.Font = new Font("Sitka Text", 12F);
            btnAnualidad.Location = new Point(557, 274);
            btnAnualidad.Name = "btnAnualidad";
            btnAnualidad.Size = new Size(129, 31);
            btnAnualidad.TabIndex = 13;
            btnAnualidad.Text = "Anualidad";
            btnAnualidad.UseVisualStyleBackColor = false;
            btnAnualidad.Click += btnAnualidad_Click;
            // 
            // FrmGradienteAritmético
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(762, 329);
            Controls.Add(btnAnualidad);
            Controls.Add(btnFuturo);
            Controls.Add(btnPresente);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmGradienteAritmético";
            Text = "FrmGradienteAritmético";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Button btnPresente;
        private Button btnFuturo;
        private Button btnAnualidad;
    }
}