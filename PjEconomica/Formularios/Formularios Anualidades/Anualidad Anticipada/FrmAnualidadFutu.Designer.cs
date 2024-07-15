namespace PjEconomica.Formularios.Formularios_Anualidades.Anualidad_Anticipada
{
    partial class FrmAnualidadFutu
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
            dgvResultadosAnualidadFuturo = new DataGridView();
            txtPeriodoAnualidadFuturo = new TextBox();
            label4 = new Label();
            txtInteresAnualidadFuturo = new TextBox();
            label3 = new Label();
            txtValorFuturoAnualidadFuturo = new TextBox();
            label2 = new Label();
            label1 = new Label();
            cmbPeriodoAf = new ComboBox();
            cmbInteresAf = new ComboBox();
            groupBox1 = new GroupBox();
            rdbNoAnualidadAnticipadaAF = new RadioButton();
            rdbSiAnualidadAnticipadaAF = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dgvResultadosAnualidadFuturo).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLim
            // 
            btnLim.BackColor = Color.White;
            btnLim.Font = new Font("Sitka Text", 11.249999F);
            btnLim.Location = new Point(562, 375);
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
            btnCal.Location = new Point(430, 375);
            btnCal.Name = "btnCal";
            btnCal.Size = new Size(104, 32);
            btnCal.TabIndex = 19;
            btnCal.Text = "Calcular";
            btnCal.UseVisualStyleBackColor = false;
            btnCal.Click += btnCal_Click;
            // 
            // dgvResultadosAnualidadFuturo
            // 
            dgvResultadosAnualidadFuturo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultadosAnualidadFuturo.Location = new Point(24, 211);
            dgvResultadosAnualidadFuturo.Name = "dgvResultadosAnualidadFuturo";
            dgvResultadosAnualidadFuturo.Size = new Size(642, 150);
            dgvResultadosAnualidadFuturo.TabIndex = 18;
            // 
            // txtPeriodoAnualidadFuturo
            // 
            txtPeriodoAnualidadFuturo.Font = new Font("Sitka Text", 11.249999F);
            txtPeriodoAnualidadFuturo.Location = new Point(583, 70);
            txtPeriodoAnualidadFuturo.Name = "txtPeriodoAnualidadFuturo";
            txtPeriodoAnualidadFuturo.Size = new Size(100, 26);
            txtPeriodoAnualidadFuturo.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Text", 11.249999F);
            label4.Location = new Point(504, 70);
            label4.Name = "label4";
            label4.Size = new Size(73, 21);
            label4.TabIndex = 16;
            label4.Text = "Periodo :";
            // 
            // txtInteresAnualidadFuturo
            // 
            txtInteresAnualidadFuturo.Font = new Font("Sitka Text", 11.249999F);
            txtInteresAnualidadFuturo.Location = new Point(386, 70);
            txtInteresAnualidadFuturo.Name = "txtInteresAnualidadFuturo";
            txtInteresAnualidadFuturo.Size = new Size(100, 26);
            txtInteresAnualidadFuturo.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Text", 11.249999F);
            label3.Location = new Point(258, 70);
            label3.Name = "label3";
            label3.Size = new Size(125, 21);
            label3.TabIndex = 14;
            label3.Text = "Tasa de interes :";
            // 
            // txtValorFuturoAnualidadFuturo
            // 
            txtValorFuturoAnualidadFuturo.Font = new Font("Sitka Text", 11.249999F);
            txtValorFuturoAnualidadFuturo.Location = new Point(138, 70);
            txtValorFuturoAnualidadFuturo.Name = "txtValorFuturoAnualidadFuturo";
            txtValorFuturoAnualidadFuturo.Size = new Size(100, 26);
            txtValorFuturoAnualidadFuturo.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 11.249999F);
            label2.Location = new Point(24, 70);
            label2.Name = "label2";
            label2.Size = new Size(108, 21);
            label2.TabIndex = 12;
            label2.Text = "Valor Futuro :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(258, 18);
            label1.Name = "label1";
            label1.Size = new Size(190, 30);
            label1.TabIndex = 11;
            label1.Text = "Ingrese los datos";
            // 
            // cmbPeriodoAf
            // 
            cmbPeriodoAf.FormattingEnabled = true;
            cmbPeriodoAf.Items.AddRange(new object[] { "Años", "Meses", "Semestres", "Trimestres" });
            cmbPeriodoAf.Location = new Point(583, 102);
            cmbPeriodoAf.Name = "cmbPeriodoAf";
            cmbPeriodoAf.Size = new Size(100, 23);
            cmbPeriodoAf.TabIndex = 30;
            // 
            // cmbInteresAf
            // 
            cmbInteresAf.FormattingEnabled = true;
            cmbInteresAf.Items.AddRange(new object[] { "Anual", "Mensual", "Semestral", "Trimestral" });
            cmbInteresAf.Location = new Point(386, 102);
            cmbInteresAf.Name = "cmbInteresAf";
            cmbInteresAf.Size = new Size(100, 23);
            cmbInteresAf.TabIndex = 29;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbNoAnualidadAnticipadaAF);
            groupBox1.Controls.Add(rdbSiAnualidadAnticipadaAF);
            groupBox1.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(24, 115);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 53);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            groupBox1.Text = "Capitalizable";
            // 
            // rdbNoAnualidadAnticipadaAF
            // 
            rdbNoAnualidadAnticipadaAF.AutoSize = true;
            rdbNoAnualidadAnticipadaAF.Location = new Point(66, 22);
            rdbNoAnualidadAnticipadaAF.Name = "rdbNoAnualidadAnticipadaAF";
            rdbNoAnualidadAnticipadaAF.Size = new Size(49, 27);
            rdbNoAnualidadAnticipadaAF.TabIndex = 1;
            rdbNoAnualidadAnticipadaAF.TabStop = true;
            rdbNoAnualidadAnticipadaAF.Text = "No";
            rdbNoAnualidadAnticipadaAF.UseVisualStyleBackColor = true;
            // 
            // rdbSiAnualidadAnticipadaAF
            // 
            rdbSiAnualidadAnticipadaAF.AutoSize = true;
            rdbSiAnualidadAnticipadaAF.Location = new Point(6, 22);
            rdbSiAnualidadAnticipadaAF.Name = "rdbSiAnualidadAnticipadaAF";
            rdbSiAnualidadAnticipadaAF.Size = new Size(42, 27);
            rdbSiAnualidadAnticipadaAF.TabIndex = 0;
            rdbSiAnualidadAnticipadaAF.TabStop = true;
            rdbSiAnualidadAnticipadaAF.Text = "Si";
            rdbSiAnualidadAnticipadaAF.UseVisualStyleBackColor = true;
            // 
            // FrmAnualidadFutu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 412);
            Controls.Add(cmbPeriodoAf);
            Controls.Add(cmbInteresAf);
            Controls.Add(groupBox1);
            Controls.Add(btnLim);
            Controls.Add(btnCal);
            Controls.Add(dgvResultadosAnualidadFuturo);
            Controls.Add(txtPeriodoAnualidadFuturo);
            Controls.Add(label4);
            Controls.Add(txtInteresAnualidadFuturo);
            Controls.Add(label3);
            Controls.Add(txtValorFuturoAnualidadFuturo);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmAnualidadFutu";
            Text = "FrmAnualidadFutu";
            ((System.ComponentModel.ISupportInitialize)dgvResultadosAnualidadFuturo).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnLim;
        private Button btnCal;
        private DataGridView dgvResultadosAnualidadFuturo;
        private TextBox txtPeriodoAnualidadFuturo;
        private Label label4;
        private TextBox txtInteresAnualidadFuturo;
        private Label label3;
        private TextBox txtValorFuturoAnualidadFuturo;
        private Label label2;
        private Label label1;
        private ComboBox cmbPeriodoAf;
        private ComboBox cmbInteresAf;
        private GroupBox groupBox1;
        private RadioButton rdbNoAnualidadAnticipadaAF;
        private RadioButton rdbSiAnualidadAnticipadaAF;
    }
}