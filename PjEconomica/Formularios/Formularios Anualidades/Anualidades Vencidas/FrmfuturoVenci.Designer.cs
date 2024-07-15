namespace PjEconomica.Formularios.Formularios_Anualidades.Anualidades_Vencidas
{
    partial class FrmfuturoVenci
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
            btnLim = new Button();
            btnCal = new Button();
            dgvResultadosFuturo = new DataGridView();
            txtPeriodoFuturo = new TextBox();
            label4 = new Label();
            txtInteresFuturo = new TextBox();
            label3 = new Label();
            txtanu = new TextBox();
            label2 = new Label();
            label1 = new Label();
            cmbPeriodoAnualidadVencida = new ComboBox();
            cmbInteresAnualidadVencidaFuturo = new ComboBox();
            groupBox1 = new GroupBox();
            rdbNoFuturo = new RadioButton();
            rdbSiFuturo = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dgvResultadosFuturo).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLim
            // 
            btnLim.BackColor = Color.White;
            btnLim.Font = new Font("Sitka Text", 11.249999F);
            btnLim.Location = new Point(550, 344);
            btnLim.Name = "btnLim";
            btnLim.Size = new Size(104, 32);
            btnLim.TabIndex = 31;
            btnLim.Text = "Limpiar";
            btnLim.UseVisualStyleBackColor = false;
            btnLim.Click += btnLim_Click;
            // 
            // btnCal
            // 
            btnCal.BackColor = Color.White;
            btnCal.Font = new Font("Sitka Text", 11.249999F);
            btnCal.Location = new Point(418, 344);
            btnCal.Name = "btnCal";
            btnCal.Size = new Size(104, 32);
            btnCal.TabIndex = 30;
            btnCal.Text = "Calcular";
            btnCal.UseVisualStyleBackColor = false;
            btnCal.Click += btnCal_Click;
            // 
            // dgvResultadosFuturo
            // 
            dgvResultadosFuturo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultadosFuturo.Location = new Point(12, 180);
            dgvResultadosFuturo.Name = "dgvResultadosFuturo";
            dgvResultadosFuturo.Size = new Size(642, 150);
            dgvResultadosFuturo.TabIndex = 29;
            // 
            // txtPeriodoFuturo
            // 
            txtPeriodoFuturo.Font = new Font("Sitka Text", 11.249999F);
            txtPeriodoFuturo.Location = new Point(559, 61);
            txtPeriodoFuturo.Name = "txtPeriodoFuturo";
            txtPeriodoFuturo.Size = new Size(100, 26);
            txtPeriodoFuturo.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Text", 11.249999F);
            label4.Location = new Point(480, 61);
            label4.Name = "label4";
            label4.Size = new Size(73, 21);
            label4.TabIndex = 27;
            label4.Text = "Periodo :";
            // 
            // txtInteresFuturo
            // 
            txtInteresFuturo.Font = new Font("Sitka Text", 11.249999F);
            txtInteresFuturo.Location = new Point(362, 61);
            txtInteresFuturo.Name = "txtInteresFuturo";
            txtInteresFuturo.Size = new Size(100, 26);
            txtInteresFuturo.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Text", 11.249999F);
            label3.Location = new Point(234, 61);
            label3.Name = "label3";
            label3.Size = new Size(125, 21);
            label3.TabIndex = 25;
            label3.Text = "Tasa de interes :";
            // 
            // txtanu
            // 
            txtanu.Font = new Font("Sitka Text", 11.249999F);
            txtanu.Location = new Point(114, 61);
            txtanu.Name = "txtanu";
            txtanu.Size = new Size(100, 26);
            txtanu.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 11.249999F);
            label2.Location = new Point(17, 61);
            label2.Name = "label2";
            label2.Size = new Size(91, 21);
            label2.TabIndex = 23;
            label2.Text = "Anualidad :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(234, 9);
            label1.Name = "label1";
            label1.Size = new Size(190, 30);
            label1.TabIndex = 22;
            label1.Text = "Ingrese los datos";
            // 
            // cmbPeriodoAnualidadVencida
            // 
            cmbPeriodoAnualidadVencida.FormattingEnabled = true;
            cmbPeriodoAnualidadVencida.Items.AddRange(new object[] { "Años", "Meses", "Semestres", "Trimestres" });
            cmbPeriodoAnualidadVencida.Location = new Point(559, 99);
            cmbPeriodoAnualidadVencida.Name = "cmbPeriodoAnualidadVencida";
            cmbPeriodoAnualidadVencida.Size = new Size(100, 23);
            cmbPeriodoAnualidadVencida.TabIndex = 34;
            // 
            // cmbInteresAnualidadVencidaFuturo
            // 
            cmbInteresAnualidadVencidaFuturo.FormattingEnabled = true;
            cmbInteresAnualidadVencidaFuturo.Items.AddRange(new object[] { "Anual", "Mensual", "Semestral", "Trimestral" });
            cmbInteresAnualidadVencidaFuturo.Location = new Point(362, 99);
            cmbInteresAnualidadVencidaFuturo.Name = "cmbInteresAnualidadVencidaFuturo";
            cmbInteresAnualidadVencidaFuturo.Size = new Size(100, 23);
            cmbInteresAnualidadVencidaFuturo.TabIndex = 33;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbNoFuturo);
            groupBox1.Controls.Add(rdbSiFuturo);
            groupBox1.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(17, 108);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 53);
            groupBox1.TabIndex = 32;
            groupBox1.TabStop = false;
            groupBox1.Text = "Capitalizable";
            // 
            // rdbNoFuturo
            // 
            rdbNoFuturo.AutoSize = true;
            rdbNoFuturo.Location = new Point(66, 22);
            rdbNoFuturo.Name = "rdbNoFuturo";
            rdbNoFuturo.Size = new Size(49, 27);
            rdbNoFuturo.TabIndex = 1;
            rdbNoFuturo.TabStop = true;
            rdbNoFuturo.Text = "No";
            rdbNoFuturo.UseVisualStyleBackColor = true;
            // 
            // rdbSiFuturo
            // 
            rdbSiFuturo.AutoSize = true;
            rdbSiFuturo.Location = new Point(6, 22);
            rdbSiFuturo.Name = "rdbSiFuturo";
            rdbSiFuturo.Size = new Size(42, 27);
            rdbSiFuturo.TabIndex = 0;
            rdbSiFuturo.TabStop = true;
            rdbSiFuturo.Text = "Si";
            rdbSiFuturo.UseVisualStyleBackColor = true;
            // 
            // FrmfuturoVenci
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 408);
            Controls.Add(cmbPeriodoAnualidadVencida);
            Controls.Add(cmbInteresAnualidadVencidaFuturo);
            Controls.Add(groupBox1);
            Controls.Add(btnLim);
            Controls.Add(btnCal);
            Controls.Add(dgvResultadosFuturo);
            Controls.Add(txtPeriodoFuturo);
            Controls.Add(label4);
            Controls.Add(txtInteresFuturo);
            Controls.Add(label3);
            Controls.Add(txtanu);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmfuturoVenci";
            Text = "FrmfuturoVenci";
            ((System.ComponentModel.ISupportInitialize)dgvResultadosFuturo).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnLim;
        private Button btnCal;
        private DataGridView dgvResultadosFuturo;
        private TextBox txtPeriodoFuturo;
        private Label label4;
        private TextBox txtInteresFuturo;
        private Label label3;
        private TextBox txtanu;
        private Label label2;
        private Label label1;
        private ComboBox cmbPeriodoAnualidadVencida;
        private ComboBox cmbInteresAnualidadVencidaFuturo;
        private GroupBox groupBox1;
        private RadioButton rdbNoFuturo;
        private RadioButton rdbSiFuturo;
    }
}