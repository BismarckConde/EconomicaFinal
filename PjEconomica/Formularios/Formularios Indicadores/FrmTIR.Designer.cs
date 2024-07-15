namespace PjEconomica.Formularios.Formularios_Indicadores
{
    partial class FrmTIR
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
            groupBox1 = new GroupBox();
            dgvTIR = new DataGridView();
            btnLimpiar = new Button();
            btnCalcular = new Button();
            txtInt2 = new TextBox();
            txtIn1 = new TextBox();
            txtVP2 = new TextBox();
            txtVP1 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTIR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvTIR);
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Controls.Add(btnCalcular);
            groupBox1.Controls.Add(txtInt2);
            groupBox1.Controls.Add(txtIn1);
            groupBox1.Controls.Add(txtVP2);
            groupBox1.Controls.Add(txtVP1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(22, 229);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(825, 306);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingrese los datos";
            // 
            // dgvTIR
            // 
            dgvTIR.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTIR.Location = new Point(338, 61);
            dgvTIR.Name = "dgvTIR";
            dgvTIR.Size = new Size(481, 230);
            dgvTIR.TabIndex = 11;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.White;
            btnLimpiar.Location = new Point(158, 242);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(105, 49);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.White;
            btnCalcular.Location = new Point(19, 242);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(105, 49);
            btnCalcular.TabIndex = 9;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtInt2
            // 
            txtInt2.Location = new Point(115, 182);
            txtInt2.Name = "txtInt2";
            txtInt2.Size = new Size(100, 31);
            txtInt2.TabIndex = 7;
            // 
            // txtIn1
            // 
            txtIn1.Location = new Point(115, 130);
            txtIn1.Name = "txtIn1";
            txtIn1.Size = new Size(100, 31);
            txtIn1.TabIndex = 6;
            // 
            // txtVP2
            // 
            txtVP2.Location = new Point(202, 85);
            txtVP2.Name = "txtVP2";
            txtVP2.Size = new Size(100, 31);
            txtVP2.TabIndex = 5;
            // 
            // txtVP1
            // 
            txtVP1.Location = new Point(200, 39);
            txtVP1.Name = "txtVP1";
            txtVP1.Size = new Size(100, 31);
            txtVP1.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Text", 12F);
            label6.Location = new Point(20, 182);
            label6.Name = "label6";
            label6.Size = new Size(74, 23);
            label6.TabIndex = 3;
            label6.Text = "Intres 2:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Text", 12F);
            label5.Location = new Point(20, 137);
            label5.Name = "label5";
            label5.Size = new Size(80, 23);
            label5.TabIndex = 2;
            label5.Text = "Interes 1:\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Text", 12F);
            label4.Location = new Point(19, 85);
            label4.Name = "label4";
            label4.Size = new Size(177, 23);
            label4.TabIndex = 1;
            label4.Text = "Valor Presente Neto 2:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Text", 12F);
            label3.Location = new Point(19, 39);
            label3.Name = "label3";
            label3.Size = new Size(175, 23);
            label3.TabIndex = 0;
            label3.Text = "Valor Presente Neto 1:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.images2;
            pictureBox1.Location = new Point(19, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(188, 136);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(217, 81);
            label2.Name = "label2";
            label2.Size = new Size(473, 84);
            label2.TabIndex = 5;
            label2.Text = "Es un índice de rentabilidad ampliamente aceptado\r\nen la evaluación de proyectos. La TIR está definida \r\ncomo la tasa de descuento que reduce a cero el VPN.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(171, 24);
            label1.Name = "label1";
            label1.Size = new Size(519, 35);
            label1.TabIndex = 4;
            label1.Text = "¿Qué es la Tasa Interna de Retorno (TIR) ?";
            // 
            // FrmTIR
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 549);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmTIR";
            Text = "FrmTIR";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTIR).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnLimpiar;
        private Button btnCalcular;
        private TextBox txtInt2;
        private TextBox txtIn1;
        private TextBox txtVP2;
        private TextBox txtVP1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private DataGridView dgvTIR;
    }
}