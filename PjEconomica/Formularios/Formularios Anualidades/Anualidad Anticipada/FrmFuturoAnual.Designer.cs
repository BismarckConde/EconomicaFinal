namespace PjEconomica.Formularios.Formularios_Anualidades.Anualidad_Anticipada
{
    partial class FrmFuturoAnual
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
            txtperi = new TextBox();
            label4 = new Label();
            txttasa = new TextBox();
            label3 = new Label();
            txtanu = new TextBox();
            label2 = new Label();
            label1 = new Label();
            cmbInteresAnualidadF = new ComboBox();
            cmbPeriodoFuturo = new ComboBox();
            rdbSiFuturo = new RadioButton();
            rdbNoFuturo = new RadioButton();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvResultadosFuturo).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLim
            // 
            btnLim.BackColor = Color.White;
            btnLim.Font = new Font("Sitka Text", 11.249999F);
            btnLim.Location = new Point(574, 348);
            btnLim.Name = "btnLim";
            btnLim.Size = new Size(104, 32);
            btnLim.TabIndex = 20;
            btnLim.Text = "Limpiar";
            btnLim.UseVisualStyleBackColor = false;
            btnLim.Click += btnLim_Click;
            // 
            // btnCal
            // 
            btnCal.BackColor = Color.White;
            btnCal.Font = new Font("Sitka Text", 11.249999F);
            btnCal.Location = new Point(442, 348);
            btnCal.Name = "btnCal";
            btnCal.Size = new Size(104, 32);
            btnCal.TabIndex = 19;
            btnCal.Text = "Calcular";
            btnCal.UseVisualStyleBackColor = false;
            btnCal.Click += btnCal_Click;
            // 
            // dgvResultadosFuturo
            // 
            dgvResultadosFuturo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultadosFuturo.Location = new Point(36, 184);
            dgvResultadosFuturo.Name = "dgvResultadosFuturo";
            dgvResultadosFuturo.Size = new Size(642, 150);
            dgvResultadosFuturo.TabIndex = 18;
            // 
            // txtperi
            // 
            txtperi.Font = new Font("Sitka Text", 11.249999F);
            txtperi.Location = new Point(578, 61);
            txtperi.Name = "txtperi";
            txtperi.Size = new Size(100, 26);
            txtperi.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Text", 11.249999F);
            label4.Location = new Point(499, 61);
            label4.Name = "label4";
            label4.Size = new Size(73, 21);
            label4.TabIndex = 16;
            label4.Text = "Periodo :";
            // 
            // txttasa
            // 
            txttasa.Font = new Font("Sitka Text", 11.249999F);
            txttasa.Location = new Point(381, 61);
            txttasa.Name = "txttasa";
            txttasa.Size = new Size(100, 26);
            txttasa.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Text", 11.249999F);
            label3.Location = new Point(253, 61);
            label3.Name = "label3";
            label3.Size = new Size(125, 21);
            label3.TabIndex = 14;
            label3.Text = "Tasa de interes :";
            // 
            // txtanu
            // 
            txtanu.Font = new Font("Sitka Text", 11.249999F);
            txtanu.Location = new Point(133, 61);
            txtanu.Name = "txtanu";
            txtanu.Size = new Size(100, 26);
            txtanu.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 11.249999F);
            label2.Location = new Point(36, 61);
            label2.Name = "label2";
            label2.Size = new Size(91, 21);
            label2.TabIndex = 12;
            label2.Text = "Anualidad :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(253, 9);
            label1.Name = "label1";
            label1.Size = new Size(190, 30);
            label1.TabIndex = 11;
            label1.Text = "Ingrese los datos";
            // 
            // cmbInteresAnualidadF
            // 
            cmbInteresAnualidadF.FormattingEnabled = true;
            cmbInteresAnualidadF.Items.AddRange(new object[] { "Anual", "Mensual", "Semestral", "Trimestral" });
            cmbInteresAnualidadF.Location = new Point(381, 107);
            cmbInteresAnualidadF.Name = "cmbInteresAnualidadF";
            cmbInteresAnualidadF.Size = new Size(100, 23);
            cmbInteresAnualidadF.TabIndex = 23;
            // 
            // cmbPeriodoFuturo
            // 
            cmbPeriodoFuturo.FormattingEnabled = true;
            cmbPeriodoFuturo.Items.AddRange(new object[] { "Años", "Meses", "Semestres", "Trimestres" });
            cmbPeriodoFuturo.Location = new Point(578, 107);
            cmbPeriodoFuturo.Name = "cmbPeriodoFuturo";
            cmbPeriodoFuturo.Size = new Size(100, 23);
            cmbPeriodoFuturo.TabIndex = 24;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbNoFuturo);
            groupBox1.Controls.Add(rdbSiFuturo);
            groupBox1.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(36, 116);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 53);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Capitalizable";
            // 
            // FrmFuturoAnual
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 390);
            Controls.Add(cmbPeriodoFuturo);
            Controls.Add(cmbInteresAnualidadF);
            Controls.Add(groupBox1);
            Controls.Add(btnLim);
            Controls.Add(btnCal);
            Controls.Add(dgvResultadosFuturo);
            Controls.Add(txtperi);
            Controls.Add(label4);
            Controls.Add(txttasa);
            Controls.Add(label3);
            Controls.Add(txtanu);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmFuturoAnual";
            Text = "FrmFuturoAnual";
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
        private TextBox txtperi;
        private Label label4;
        private TextBox txttasa;
        private Label label3;
        private TextBox txtanu;
        private Label label2;
        private Label label1;
        private ComboBox cmbInteresAnualidadF;
        private ComboBox cmbPeriodoFuturo;
        private RadioButton rdbSiFuturo;
        private RadioButton rdbNoFuturo;
        private GroupBox groupBox1;
    }
}