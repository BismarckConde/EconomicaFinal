namespace PjEconomica.Formularios.Formularios_Anualidades.Anualidades_Vencidas
{
    partial class FrmAnufutuVenci
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
            cmbPeriodoAF = new ComboBox();
            cmbInteresAF = new ComboBox();
            groupBox1 = new GroupBox();
            rdbNoFuturo = new RadioButton();
            rdbSiFuturo = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dgvResultadosAnualidadFuturo).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLim
            // 
            btnLim.BackColor = Color.White;
            btnLim.Font = new Font("Sitka Text", 11.249999F);
            btnLim.Location = new Point(577, 374);
            btnLim.Name = "btnLim";
            btnLim.Size = new Size(104, 32);
            btnLim.TabIndex = 42;
            btnLim.Text = "Limpiar";
            btnLim.UseVisualStyleBackColor = false;
            btnLim.Click += btnLim_Click;
            // 
            // btnCal
            // 
            btnCal.BackColor = Color.White;
            btnCal.Font = new Font("Sitka Text", 11.249999F);
            btnCal.Location = new Point(445, 374);
            btnCal.Name = "btnCal";
            btnCal.Size = new Size(104, 32);
            btnCal.TabIndex = 41;
            btnCal.Text = "Calcular";
            btnCal.UseVisualStyleBackColor = false;
            btnCal.Click += btnCal_Click;
            // 
            // dgvResultadosAnualidadFuturo
            // 
            dgvResultadosAnualidadFuturo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultadosAnualidadFuturo.Location = new Point(39, 210);
            dgvResultadosAnualidadFuturo.Name = "dgvResultadosAnualidadFuturo";
            dgvResultadosAnualidadFuturo.Size = new Size(642, 150);
            dgvResultadosAnualidadFuturo.TabIndex = 40;
            // 
            // txtPeriodoAnualidadFuturo
            // 
            txtPeriodoAnualidadFuturo.Font = new Font("Sitka Text", 11.249999F);
            txtPeriodoAnualidadFuturo.Location = new Point(581, 61);
            txtPeriodoAnualidadFuturo.Name = "txtPeriodoAnualidadFuturo";
            txtPeriodoAnualidadFuturo.Size = new Size(100, 26);
            txtPeriodoAnualidadFuturo.TabIndex = 39;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Text", 11.249999F);
            label4.Location = new Point(502, 61);
            label4.Name = "label4";
            label4.Size = new Size(73, 21);
            label4.TabIndex = 38;
            label4.Text = "Periodo :";
            // 
            // txtInteresAnualidadFuturo
            // 
            txtInteresAnualidadFuturo.Font = new Font("Sitka Text", 11.249999F);
            txtInteresAnualidadFuturo.Location = new Point(384, 61);
            txtInteresAnualidadFuturo.Name = "txtInteresAnualidadFuturo";
            txtInteresAnualidadFuturo.Size = new Size(100, 26);
            txtInteresAnualidadFuturo.TabIndex = 37;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Text", 11.249999F);
            label3.Location = new Point(256, 61);
            label3.Name = "label3";
            label3.Size = new Size(125, 21);
            label3.TabIndex = 36;
            label3.Text = "Tasa de interes :";
            // 
            // txtValorFuturoAnualidadFuturo
            // 
            txtValorFuturoAnualidadFuturo.Font = new Font("Sitka Text", 11.249999F);
            txtValorFuturoAnualidadFuturo.Location = new Point(136, 61);
            txtValorFuturoAnualidadFuturo.Name = "txtValorFuturoAnualidadFuturo";
            txtValorFuturoAnualidadFuturo.Size = new Size(100, 26);
            txtValorFuturoAnualidadFuturo.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 11.249999F);
            label2.Location = new Point(18, 61);
            label2.Name = "label2";
            label2.Size = new Size(112, 21);
            label2.TabIndex = 34;
            label2.Text = "Valor Futuro : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(239, 9);
            label1.Name = "label1";
            label1.Size = new Size(190, 30);
            label1.TabIndex = 33;
            label1.Text = "Ingrese los datos";
            // 
            // cmbPeriodoAF
            // 
            cmbPeriodoAF.FormattingEnabled = true;
            cmbPeriodoAF.Items.AddRange(new object[] { "Años", "Meses", "Semestres", "Trimestres" });
            cmbPeriodoAF.Location = new Point(578, 100);
            cmbPeriodoAF.Name = "cmbPeriodoAF";
            cmbPeriodoAF.Size = new Size(100, 23);
            cmbPeriodoAF.TabIndex = 45;
            // 
            // cmbInteresAF
            // 
            cmbInteresAF.FormattingEnabled = true;
            cmbInteresAF.Items.AddRange(new object[] { "Anual", "Mensual", "Semestral", "Trimestral" });
            cmbInteresAF.Location = new Point(381, 100);
            cmbInteresAF.Name = "cmbInteresAF";
            cmbInteresAF.Size = new Size(100, 23);
            cmbInteresAF.TabIndex = 44;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbNoFuturo);
            groupBox1.Controls.Add(rdbSiFuturo);
            groupBox1.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(36, 109);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 53);
            groupBox1.TabIndex = 43;
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
            // FrmAnufutuVenci
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(703, 412);
            Controls.Add(cmbPeriodoAF);
            Controls.Add(cmbInteresAF);
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
            Name = "FrmAnufutuVenci";
            Text = "FrmAnufutuVenci";
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
        private ComboBox cmbPeriodoAF;
        private ComboBox cmbInteresAF;
        private GroupBox groupBox1;
        private RadioButton rdbNoFuturo;
        private RadioButton rdbSiFuturo;
    }
}