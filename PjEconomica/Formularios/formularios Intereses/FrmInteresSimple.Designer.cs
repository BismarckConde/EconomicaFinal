namespace PjEconomica.Formularios.formularios_Intereses
{
    partial class FrmInteresSimple
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
            btnfuturo = new Button();
            btnPresente = new Button();
            btnPeriodo = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(253, 29);
            label1.Name = "label1";
            label1.Size = new Size(322, 35);
            label1.TabIndex = 0;
            label1.Text = "¿Qué es el interes simple?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(218, 76);
            label2.Name = "label2";
            label2.Size = new Size(461, 84);
            label2.TabIndex = 1;
            label2.Text = "Se llama interés simpe al que por el uso del dinero\r\na través de varios periodos de capitalizacion no se \r\ncobra interés sobre los intereses que se debe.";
            // 
            // btnfuturo
            // 
            btnfuturo.Font = new Font("Sitka Text", 12F);
            btnfuturo.Location = new Point(30, 187);
            btnfuturo.Name = "btnfuturo";
            btnfuturo.Size = new Size(191, 45);
            btnfuturo.TabIndex = 2;
            btnfuturo.Text = "Calcular Futuro";
            btnfuturo.UseVisualStyleBackColor = true;
            btnfuturo.Click += btnfuturo_Click;
            // 
            // btnPresente
            // 
            btnPresente.Font = new Font("Sitka Text", 12F);
            btnPresente.Location = new Point(276, 187);
            btnPresente.Name = "btnPresente";
            btnPresente.Size = new Size(188, 45);
            btnPresente.TabIndex = 3;
            btnPresente.Text = "Calcular Presente";
            btnPresente.UseVisualStyleBackColor = true;
            btnPresente.Click += btnPresente_Click;
            // 
            // btnPeriodo
            // 
            btnPeriodo.Font = new Font("Sitka Text", 12F);
            btnPeriodo.Location = new Point(512, 187);
            btnPeriodo.Name = "btnPeriodo";
            btnPeriodo.Size = new Size(156, 45);
            btnPeriodo.TabIndex = 4;
            btnPeriodo.Text = "Calcular Periodo";
            btnPeriodo.UseVisualStyleBackColor = true;
            btnPeriodo.Click += btnPeriodo_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.simle;
            pictureBox1.Location = new Point(12, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(191, 131);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // FrmInteresSimple
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(702, 256);
            Controls.Add(pictureBox1);
            Controls.Add(btnPeriodo);
            Controls.Add(btnPresente);
            Controls.Add(btnfuturo);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmInteresSimple";
            Text = "FrmInteresSimple";
            Load += FrmInteresSimple_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnfuturo;
        private Button btnPresente;
        private Button btnPeriodo;
        private PictureBox pictureBox1;
    }
}