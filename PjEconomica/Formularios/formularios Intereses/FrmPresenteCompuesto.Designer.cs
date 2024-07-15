namespace PjEconomica.Formularios.formularios_Intereses
{
    partial class FrmPresenteCompuesto
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
            label4 = new Label();
            btnLim = new Button();
            btnCal = new Button();
            txtPeriodoP = new TextBox();
            txtTasaInteresP = new TextBox();
            txtValorFuturoP = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cmbPeriodoP = new ComboBox();
            cmbInteresP = new ComboBox();
            groupBox1 = new GroupBox();
            rdbNo1 = new RadioButton();
            rdbSi1 = new RadioButton();
            dgvResultadosP = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResultadosP).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Text", 12F);
            label4.Location = new Point(25, 143);
            label4.Name = "label4";
            label4.Size = new Size(77, 23);
            label4.TabIndex = 42;
            label4.Text = "Periodo :";
            // 
            // btnLim
            // 
            btnLim.Font = new Font("Sitka Text", 12F);
            btnLim.Location = new Point(193, 186);
            btnLim.Name = "btnLim";
            btnLim.Size = new Size(134, 35);
            btnLim.TabIndex = 40;
            btnLim.Text = "Limpiar";
            btnLim.UseVisualStyleBackColor = true;
            btnLim.Click += btnLim_Click;
            // 
            // btnCal
            // 
            btnCal.Font = new Font("Sitka Text", 12F);
            btnCal.Location = new Point(25, 186);
            btnCal.Name = "btnCal";
            btnCal.Size = new Size(134, 35);
            btnCal.TabIndex = 39;
            btnCal.Text = "Calcular";
            btnCal.UseVisualStyleBackColor = true;
            btnCal.Click += btnCal_Click;
            // 
            // txtPeriodoP
            // 
            txtPeriodoP.Location = new Point(159, 143);
            txtPeriodoP.Name = "txtPeriodoP";
            txtPeriodoP.Size = new Size(100, 23);
            txtPeriodoP.TabIndex = 38;
            // 
            // txtTasaInteresP
            // 
            txtTasaInteresP.Location = new Point(159, 107);
            txtTasaInteresP.Name = "txtTasaInteresP";
            txtTasaInteresP.Size = new Size(100, 23);
            txtTasaInteresP.TabIndex = 37;
            // 
            // txtValorFuturoP
            // 
            txtValorFuturoP.Location = new Point(159, 64);
            txtValorFuturoP.Name = "txtValorFuturoP";
            txtValorFuturoP.Size = new Size(100, 23);
            txtValorFuturoP.TabIndex = 36;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Text", 12F);
            label3.Location = new Point(25, 107);
            label3.Name = "label3";
            label3.Size = new Size(134, 23);
            label3.TabIndex = 34;
            label3.Text = "Tasa de Interes :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 12F);
            label2.Location = new Point(25, 67);
            label2.Name = "label2";
            label2.Size = new Size(116, 23);
            label2.TabIndex = 33;
            label2.Text = "Valor Futuro :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(159, 9);
            label1.Name = "label1";
            label1.Size = new Size(472, 35);
            label1.TabIndex = 32;
            label1.Text = "Calculo de interes presente compuesto\r\n";
            // 
            // cmbPeriodoP
            // 
            cmbPeriodoP.FormattingEnabled = true;
            cmbPeriodoP.Items.AddRange(new object[] { "Años", "Semestres", "Trimestres", "Meses" });
            cmbPeriodoP.Location = new Point(274, 145);
            cmbPeriodoP.Name = "cmbPeriodoP";
            cmbPeriodoP.Size = new Size(121, 23);
            cmbPeriodoP.TabIndex = 46;
            // 
            // cmbInteresP
            // 
            cmbInteresP.FormattingEnabled = true;
            cmbInteresP.Items.AddRange(new object[] { "Anual", "Semestral", "Trimestral", "Mensual" });
            cmbInteresP.Location = new Point(274, 112);
            cmbInteresP.Name = "cmbInteresP";
            cmbInteresP.Size = new Size(121, 23);
            cmbInteresP.TabIndex = 45;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbNo1);
            groupBox1.Controls.Add(rdbSi1);
            groupBox1.Font = new Font("Sitka Text", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(274, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(133, 54);
            groupBox1.TabIndex = 44;
            groupBox1.TabStop = false;
            groupBox1.Text = "Capitalizable";
            // 
            // rdbNo1
            // 
            rdbNo1.AutoSize = true;
            rdbNo1.Location = new Point(78, 25);
            rdbNo1.Name = "rdbNo1";
            rdbNo1.Size = new Size(47, 25);
            rdbNo1.TabIndex = 35;
            rdbNo1.TabStop = true;
            rdbNo1.Text = "No";
            rdbNo1.UseVisualStyleBackColor = true;
            // 
            // rdbSi1
            // 
            rdbSi1.AutoSize = true;
            rdbSi1.Location = new Point(18, 25);
            rdbSi1.Name = "rdbSi1";
            rdbSi1.Size = new Size(41, 25);
            rdbSi1.TabIndex = 34;
            rdbSi1.TabStop = true;
            rdbSi1.Text = "Si";
            rdbSi1.UseVisualStyleBackColor = true;
            // 
            // dgvResultadosP
            // 
            dgvResultadosP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultadosP.Location = new Point(413, 77);
            dgvResultadosP.Name = "dgvResultadosP";
            dgvResultadosP.Size = new Size(452, 132);
            dgvResultadosP.TabIndex = 43;
            // 
            // FrmPresenteCompuesto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 239);
            Controls.Add(cmbPeriodoP);
            Controls.Add(cmbInteresP);
            Controls.Add(groupBox1);
            Controls.Add(dgvResultadosP);
            Controls.Add(label4);
            Controls.Add(btnLim);
            Controls.Add(btnCal);
            Controls.Add(txtPeriodoP);
            Controls.Add(txtTasaInteresP);
            Controls.Add(txtValorFuturoP);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmPresenteCompuesto";
            Text = "FrmPresenteCompuesto";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResultadosP).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Button btnLim;
        private Button btnCal;
        private TextBox txtPeriodoP;
        private TextBox txtTasaInteresP;
        private TextBox txtValorFuturoP;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cmbPeriodoP;
        private ComboBox cmbInteresP;
        private GroupBox groupBox1;
        private RadioButton rdbNo1;
        private RadioButton rdbSi1;
        private DataGridView dgvResultadosP;
    }
}