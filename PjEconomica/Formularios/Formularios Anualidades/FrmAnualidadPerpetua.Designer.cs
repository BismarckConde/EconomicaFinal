namespace PjEconomica.Formularios.Formularios_Anualidades
{
    partial class FrmAnualidadPerpetua
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
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            btnLim = new Button();
            btnCal = new Button();
            dataGridView1 = new DataGridView();
            txttasa = new TextBox();
            label3 = new Label();
            txtanu = new TextBox();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Anualidad;
            pictureBox1.Location = new Point(62, 79);
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
            label2.Location = new Point(287, 79);
            label2.Name = "label2";
            label2.Size = new Size(367, 140);
            label2.TabIndex = 8;
            label2.Text = "Es aquella serie de pagos cuyo \r\npago se inicia en una fecha fija \r\ny continúa para siempre, en términos\r\nmatemáticos se interpreta que el \r\nplazo de a anualidad tiende al \"infinito\".";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(180, 19);
            label1.Name = "label1";
            label1.Size = new Size(409, 35);
            label1.TabIndex = 7;
            label1.Text = "¿Qué es una Anualidad Perpetua?";
            // 
            // btnLim
            // 
            btnLim.BackColor = Color.White;
            btnLim.Font = new Font("Sitka Text", 11.249999F);
            btnLim.Location = new Point(485, 539);
            btnLim.Name = "btnLim";
            btnLim.Size = new Size(104, 32);
            btnLim.TabIndex = 31;
            btnLim.Text = "Limpiar";
            btnLim.UseVisualStyleBackColor = false;
            // 
            // btnCal
            // 
            btnCal.BackColor = Color.White;
            btnCal.Font = new Font("Sitka Text", 11.249999F);
            btnCal.Location = new Point(362, 539);
            btnCal.Name = "btnCal";
            btnCal.Size = new Size(104, 32);
            btnCal.TabIndex = 30;
            btnCal.Text = "Calcular";
            btnCal.UseVisualStyleBackColor = false;
            btnCal.Click += btnCal_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(144, 372);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(445, 150);
            dataGridView1.TabIndex = 29;
            // 
            // txttasa
            // 
            txttasa.Font = new Font("Sitka Text", 11.249999F);
            txttasa.Location = new Point(489, 299);
            txttasa.Name = "txttasa";
            txttasa.Size = new Size(100, 26);
            txttasa.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Text", 11.249999F);
            label3.Location = new Point(361, 299);
            label3.Name = "label3";
            label3.Size = new Size(125, 21);
            label3.TabIndex = 25;
            label3.Text = "Tasa de interes :";
            // 
            // txtanu
            // 
            txtanu.Font = new Font("Sitka Text", 11.249999F);
            txtanu.Location = new Point(241, 299);
            txtanu.Name = "txtanu";
            txtanu.Size = new Size(100, 26);
            txtanu.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Text", 11.249999F);
            label5.Location = new Point(144, 299);
            label5.Name = "label5";
            label5.Size = new Size(91, 21);
            label5.TabIndex = 23;
            label5.Text = "Anualidad :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Text", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(276, 250);
            label6.Name = "label6";
            label6.Size = new Size(190, 30);
            label6.TabIndex = 22;
            label6.Text = "Ingrese los datos";
            // 
            // FrmAnualidadPerpetua
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 583);
            Controls.Add(btnLim);
            Controls.Add(btnCal);
            Controls.Add(dataGridView1);
            Controls.Add(txttasa);
            Controls.Add(label3);
            Controls.Add(txtanu);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmAnualidadPerpetua";
            Text = "FrmAnualidadPerpetua";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Button btnLim;
        private Button btnCal;
        private DataGridView dataGridView1;
        private TextBox txttasa;
        private Label label3;
        private TextBox txtanu;
        private Label label5;
        private Label label6;
    }
}