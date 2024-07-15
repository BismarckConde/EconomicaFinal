namespace PjEconomica.Formularios.formularios_Intereses
{
    partial class FrmDefinicionCompuesto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDefinicionCompuesto));
            btnPeriodo = new Button();
            btnPresente = new Button();
            btnfuturo = new Button();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnPeriodo
            // 
            btnPeriodo.Font = new Font("Sitka Text", 12F);
            btnPeriodo.Location = new Point(530, 223);
            btnPeriodo.Name = "btnPeriodo";
            btnPeriodo.Size = new Size(156, 45);
            btnPeriodo.TabIndex = 9;
            btnPeriodo.Text = "Calcular Periodo";
            btnPeriodo.UseVisualStyleBackColor = true;
            btnPeriodo.Click += btnPeriodo_Click;
            // 
            // btnPresente
            // 
            btnPresente.Font = new Font("Sitka Text", 12F);
            btnPresente.Location = new Point(294, 223);
            btnPresente.Name = "btnPresente";
            btnPresente.Size = new Size(188, 45);
            btnPresente.TabIndex = 8;
            btnPresente.Text = "Calcular Presente";
            btnPresente.UseVisualStyleBackColor = true;
            btnPresente.Click += btnPresente_Click;
            // 
            // btnfuturo
            // 
            btnfuturo.Font = new Font("Sitka Text", 12F);
            btnfuturo.Location = new Point(48, 223);
            btnfuturo.Name = "btnfuturo";
            btnfuturo.Size = new Size(191, 45);
            btnfuturo.TabIndex = 7;
            btnfuturo.Text = "Calcular Futuro";
            btnfuturo.UseVisualStyleBackColor = true;
            btnfuturo.Click += btnfuturo_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(247, 56);
            label2.Name = "label2";
            label2.Size = new Size(457, 140);
            label2.TabIndex = 6;
            label2.Text = resources.GetString("label2.Text");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(261, 9);
            label1.Name = "label1";
            label1.Size = new Size(370, 35);
            label1.TabIndex = 5;
            label1.Text = "¿Qué es el interes compuesto?";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.images1;
            pictureBox1.Location = new Point(33, 56);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(193, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // FrmDefinicionCompuesto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 298);
            Controls.Add(pictureBox1);
            Controls.Add(btnPeriodo);
            Controls.Add(btnPresente);
            Controls.Add(btnfuturo);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmDefinicionCompuesto";
            Text = "FrmDefinicionCompuesto";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPeriodo;
        private Button btnPresente;
        private Button btnfuturo;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}