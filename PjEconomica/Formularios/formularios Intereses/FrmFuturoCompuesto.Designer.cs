namespace PjEconomica.Formularios.formularios_Intereses
{
    partial class FrmFuturoCompuesto
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
            txtPeriodoF = new TextBox();
            txtTasaInteresF = new TextBox();
            txtValorPresenteF = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            dgvResultadosFU = new DataGridView();
            groupBox1 = new GroupBox();
            rdbNo = new RadioButton();
            rdbSi = new RadioButton();
            cmbInteresF = new ComboBox();
            cmbPeriodoF = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvResultadosFU).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLim
            // 
            btnLim.Font = new Font("Sitka Text", 12F);
            btnLim.Location = new Point(196, 190);
            btnLim.Name = "btnLim";
            btnLim.Size = new Size(134, 35);
            btnLim.TabIndex = 29;
            btnLim.Text = "Limpiar";
            btnLim.UseVisualStyleBackColor = true;
            btnLim.Click += btnLim_Click;
            // 
            // btnCal
            // 
            btnCal.Font = new Font("Sitka Text", 12F);
            btnCal.Location = new Point(28, 190);
            btnCal.Name = "btnCal";
            btnCal.Size = new Size(134, 35);
            btnCal.TabIndex = 28;
            btnCal.Text = "Calcular";
            btnCal.UseVisualStyleBackColor = true;
            btnCal.Click += btnCal_Click;
            // 
            // txtPeriodoF
            // 
            txtPeriodoF.Location = new Point(162, 143);
            txtPeriodoF.Name = "txtPeriodoF";
            txtPeriodoF.Size = new Size(100, 23);
            txtPeriodoF.TabIndex = 27;
            // 
            // txtTasaInteresF
            // 
            txtTasaInteresF.Location = new Point(162, 107);
            txtTasaInteresF.Name = "txtTasaInteresF";
            txtTasaInteresF.Size = new Size(100, 23);
            txtTasaInteresF.TabIndex = 26;
            // 
            // txtValorPresenteF
            // 
            txtValorPresenteF.Location = new Point(162, 64);
            txtValorPresenteF.Name = "txtValorPresenteF";
            txtValorPresenteF.Size = new Size(100, 23);
            txtValorPresenteF.TabIndex = 25;
            txtValorPresenteF.TextChanged += txtVp_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Text", 12F);
            label3.Location = new Point(28, 107);
            label3.Name = "label3";
            label3.Size = new Size(134, 23);
            label3.TabIndex = 23;
            label3.Text = "Tasa de Interes :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 12F);
            label2.Location = new Point(28, 67);
            label2.Name = "label2";
            label2.Size = new Size(128, 23);
            label2.TabIndex = 22;
            label2.Text = "Valor Presente :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(240, 9);
            label1.Name = "label1";
            label1.Size = new Size(445, 35);
            label1.TabIndex = 21;
            label1.Text = "Calculo de interes futuro compuesto\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Text", 12F);
            label4.Location = new Point(28, 143);
            label4.Name = "label4";
            label4.Size = new Size(77, 23);
            label4.TabIndex = 31;
            label4.Text = "Periodo :";
            // 
            // dgvResultadosFU
            // 
            dgvResultadosFU.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultadosFU.Location = new Point(418, 75);
            dgvResultadosFU.Name = "dgvResultadosFU";
            dgvResultadosFU.Size = new Size(452, 132);
            dgvResultadosFU.TabIndex = 32;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbNo);
            groupBox1.Controls.Add(rdbSi);
            groupBox1.Font = new Font("Sitka Text", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(279, 50);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(133, 54);
            groupBox1.TabIndex = 33;
            groupBox1.TabStop = false;
            groupBox1.Text = "Capitalizable";
            // 
            // rdbNo
            // 
            rdbNo.AutoSize = true;
            rdbNo.Location = new Point(78, 25);
            rdbNo.Name = "rdbNo";
            rdbNo.Size = new Size(47, 25);
            rdbNo.TabIndex = 35;
            rdbNo.TabStop = true;
            rdbNo.Text = "No";
            rdbNo.UseVisualStyleBackColor = true;
            // 
            // rdbSi
            // 
            rdbSi.AutoSize = true;
            rdbSi.Location = new Point(18, 25);
            rdbSi.Name = "rdbSi";
            rdbSi.Size = new Size(41, 25);
            rdbSi.TabIndex = 34;
            rdbSi.TabStop = true;
            rdbSi.Text = "Si";
            rdbSi.UseVisualStyleBackColor = true;
            // 
            // cmbInteresF
            // 
            cmbInteresF.FormattingEnabled = true;
            cmbInteresF.Items.AddRange(new object[] { "Anual", "Semestral", "Trimestral", "Mensual" });
            cmbInteresF.Location = new Point(279, 110);
            cmbInteresF.Name = "cmbInteresF";
            cmbInteresF.Size = new Size(121, 23);
            cmbInteresF.TabIndex = 34;
            // 
            // cmbPeriodoF
            // 
            cmbPeriodoF.FormattingEnabled = true;
            cmbPeriodoF.Items.AddRange(new object[] { "Años", "Semestres", "Trimestres", "Meses" });
            cmbPeriodoF.Location = new Point(279, 143);
            cmbPeriodoF.Name = "cmbPeriodoF";
            cmbPeriodoF.Size = new Size(121, 23);
            cmbPeriodoF.TabIndex = 35;
            // 
            // FrmFuturoCompuesto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(902, 259);
            Controls.Add(cmbPeriodoF);
            Controls.Add(cmbInteresF);
            Controls.Add(groupBox1);
            Controls.Add(dgvResultadosFU);
            Controls.Add(label4);
            Controls.Add(btnLim);
            Controls.Add(btnCal);
            Controls.Add(txtPeriodoF);
            Controls.Add(txtTasaInteresF);
            Controls.Add(txtValorPresenteF);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmFuturoCompuesto";
            Text = "FrmFuturoCompuesto";
            Load += FrmFuturoCompuesto_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResultadosFU).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnLim;
        private Button btnCal;
        private TextBox txtPeriodoF;
        private TextBox txtTasaInteresF;
        private TextBox txtValorPresenteF;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private DataGridView dgvResultadosFU;
        private GroupBox groupBox1;
        private RadioButton rdbSi;
        private RadioButton rdbNo;
        private ComboBox cmbInteresF;
        private ComboBox cmbPeriodoF;
    }
}