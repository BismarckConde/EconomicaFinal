namespace PjEconomica.Formularios.formularios_Intereses
{
    partial class FrmPresente
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
            txtPeriodoP = new TextBox();
            txtTasaInteresP = new TextBox();
            txtValorFuturoP = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cmbPeriodoFuturoSimple = new ComboBox();
            cmbInteresFuturoSimple = new ComboBox();
            dgvResultadosP = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvResultadosP).BeginInit();
            SuspendLayout();
            // 
            // btnLim
            // 
            btnLim.Font = new Font("Sitka Text", 12F);
            btnLim.Location = new Point(207, 208);
            btnLim.Name = "btnLim";
            btnLim.Size = new Size(134, 35);
            btnLim.TabIndex = 19;
            btnLim.Text = "Limpiar";
            btnLim.UseVisualStyleBackColor = true;
            btnLim.Click += btnLim_Click;
            // 
            // btnCal
            // 
            btnCal.Font = new Font("Sitka Text", 12F);
            btnCal.Location = new Point(39, 208);
            btnCal.Name = "btnCal";
            btnCal.Size = new Size(134, 35);
            btnCal.TabIndex = 18;
            btnCal.Text = "Calcular";
            btnCal.UseVisualStyleBackColor = true;
            btnCal.Click += btnCal_Click;
            // 
            // txtPeriodoP
            // 
            txtPeriodoP.Location = new Point(173, 165);
            txtPeriodoP.Name = "txtPeriodoP";
            txtPeriodoP.Size = new Size(100, 23);
            txtPeriodoP.TabIndex = 17;
            // 
            // txtTasaInteresP
            // 
            txtTasaInteresP.Location = new Point(173, 129);
            txtTasaInteresP.Name = "txtTasaInteresP";
            txtTasaInteresP.Size = new Size(100, 23);
            txtTasaInteresP.TabIndex = 16;
            // 
            // txtValorFuturoP
            // 
            txtValorFuturoP.Location = new Point(173, 86);
            txtValorFuturoP.Name = "txtValorFuturoP";
            txtValorFuturoP.Size = new Size(100, 23);
            txtValorFuturoP.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Text", 12F);
            label4.Location = new Point(39, 165);
            label4.Name = "label4";
            label4.Size = new Size(77, 23);
            label4.TabIndex = 13;
            label4.Text = "Periodo :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Text", 12F);
            label3.Location = new Point(39, 129);
            label3.Name = "label3";
            label3.Size = new Size(134, 23);
            label3.TabIndex = 12;
            label3.Text = "Tasa de Interes :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 12F);
            label2.Location = new Point(39, 89);
            label2.Name = "label2";
            label2.Size = new Size(116, 23);
            label2.TabIndex = 11;
            label2.Text = "Valor Futuro :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(269, 18);
            label1.Name = "label1";
            label1.Size = new Size(337, 35);
            label1.TabIndex = 10;
            label1.Text = "Calculo de interes Presente\r\n";
            // 
            // cmbPeriodoFuturoSimple
            // 
            cmbPeriodoFuturoSimple.FormattingEnabled = true;
            cmbPeriodoFuturoSimple.Items.AddRange(new object[] { "Años", "Meses", "Semestres", "Trimestres" });
            cmbPeriodoFuturoSimple.Location = new Point(281, 165);
            cmbPeriodoFuturoSimple.Name = "cmbPeriodoFuturoSimple";
            cmbPeriodoFuturoSimple.Size = new Size(88, 23);
            cmbPeriodoFuturoSimple.TabIndex = 22;
            // 
            // cmbInteresFuturoSimple
            // 
            cmbInteresFuturoSimple.FormattingEnabled = true;
            cmbInteresFuturoSimple.Items.AddRange(new object[] { "Anual", "Mensual", "Semestral", "Trimestral" });
            cmbInteresFuturoSimple.Location = new Point(281, 126);
            cmbInteresFuturoSimple.Name = "cmbInteresFuturoSimple";
            cmbInteresFuturoSimple.Size = new Size(88, 23);
            cmbInteresFuturoSimple.TabIndex = 21;
            // 
            // dgvResultadosP
            // 
            dgvResultadosP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultadosP.Location = new Point(375, 83);
            dgvResultadosP.Name = "dgvResultadosP";
            dgvResultadosP.Size = new Size(501, 160);
            dgvResultadosP.TabIndex = 20;
            // 
            // FrmPresente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 274);
            Controls.Add(cmbPeriodoFuturoSimple);
            Controls.Add(cmbInteresFuturoSimple);
            Controls.Add(dgvResultadosP);
            Controls.Add(btnLim);
            Controls.Add(btnCal);
            Controls.Add(txtPeriodoP);
            Controls.Add(txtTasaInteresP);
            Controls.Add(txtValorFuturoP);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmPresente";
            Text = "FrmPresente";
            ((System.ComponentModel.ISupportInitialize)dgvResultadosP).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLim;
        private Button btnCal;
        private TextBox txtPeriodoP;
        private TextBox txtTasaInteresP;
        private TextBox txtValorFuturoP;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cmbPeriodoFuturoSimple;
        private ComboBox cmbInteresFuturoSimple;
        private DataGridView dgvResultadosP;
    }
}