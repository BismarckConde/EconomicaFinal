namespace PjEconomica.Formularios.Formularios_Anualidades.Anualidades_Diferidas
{
    partial class FrmAnuFutuDife
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
            label5 = new Label();
            btnLim = new Button();
            btnCal = new Button();
            dgvResultadosAnualidadFuturo = new DataGridView();
            txtPeriodoAnualidadFuturo = new TextBox();
            label4 = new Label();
            txtInteresAnualidadFuturo = new TextBox();
            label3 = new Label();
            txtValorFuturoAnualidadFuturo = new TextBox();
            label1 = new Label();
            cmbPeriodoAf = new ComboBox();
            cmbInteresAf = new ComboBox();
            groupBox1 = new GroupBox();
            rdbno = new RadioButton();
            rdbSi = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dgvResultadosAnualidadFuturo).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(18, 63);
            label5.Name = "label5";
            label5.Size = new Size(116, 23);
            label5.TabIndex = 57;
            label5.Text = "Valor Futuro :";
            // 
            // btnLim
            // 
            btnLim.BackColor = Color.White;
            btnLim.Font = new Font("Sitka Text", 11.249999F);
            btnLim.Location = new Point(556, 355);
            btnLim.Name = "btnLim";
            btnLim.Size = new Size(104, 32);
            btnLim.TabIndex = 55;
            btnLim.Text = "Limpiar";
            btnLim.UseVisualStyleBackColor = false;
            btnLim.Click += btnLim_Click;
            // 
            // btnCal
            // 
            btnCal.BackColor = Color.White;
            btnCal.Font = new Font("Sitka Text", 11.249999F);
            btnCal.Location = new Point(424, 355);
            btnCal.Name = "btnCal";
            btnCal.Size = new Size(104, 32);
            btnCal.TabIndex = 54;
            btnCal.Text = "Calcular";
            btnCal.UseVisualStyleBackColor = false;
            btnCal.Click += btnCal_Click;
            // 
            // dgvResultadosAnualidadFuturo
            // 
            dgvResultadosAnualidadFuturo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultadosAnualidadFuturo.Location = new Point(18, 191);
            dgvResultadosAnualidadFuturo.Name = "dgvResultadosAnualidadFuturo";
            dgvResultadosAnualidadFuturo.Size = new Size(642, 150);
            dgvResultadosAnualidadFuturo.TabIndex = 53;
            // 
            // txtPeriodoAnualidadFuturo
            // 
            txtPeriodoAnualidadFuturo.Font = new Font("Sitka Text", 11.249999F);
            txtPeriodoAnualidadFuturo.Location = new Point(571, 65);
            txtPeriodoAnualidadFuturo.Name = "txtPeriodoAnualidadFuturo";
            txtPeriodoAnualidadFuturo.Size = new Size(100, 26);
            txtPeriodoAnualidadFuturo.TabIndex = 52;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Text", 11.249999F);
            label4.Location = new Point(492, 65);
            label4.Name = "label4";
            label4.Size = new Size(77, 21);
            label4.TabIndex = 51;
            label4.Text = "Periodo  :";
            // 
            // txtInteresAnualidadFuturo
            // 
            txtInteresAnualidadFuturo.Font = new Font("Sitka Text", 11.249999F);
            txtInteresAnualidadFuturo.Location = new Point(386, 63);
            txtInteresAnualidadFuturo.Name = "txtInteresAnualidadFuturo";
            txtInteresAnualidadFuturo.Size = new Size(100, 26);
            txtInteresAnualidadFuturo.TabIndex = 50;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Text", 11.249999F);
            label3.Location = new Point(258, 63);
            label3.Name = "label3";
            label3.Size = new Size(125, 21);
            label3.TabIndex = 49;
            label3.Text = "Tasa de interes :";
            // 
            // txtValorFuturoAnualidadFuturo
            // 
            txtValorFuturoAnualidadFuturo.Font = new Font("Sitka Text", 11.249999F);
            txtValorFuturoAnualidadFuturo.Location = new Point(152, 63);
            txtValorFuturoAnualidadFuturo.Name = "txtValorFuturoAnualidadFuturo";
            txtValorFuturoAnualidadFuturo.Size = new Size(100, 26);
            txtValorFuturoAnualidadFuturo.TabIndex = 48;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(241, 9);
            label1.Name = "label1";
            label1.Size = new Size(190, 30);
            label1.TabIndex = 47;
            label1.Text = "Ingrese los datos";
            // 
            // cmbPeriodoAf
            // 
            cmbPeriodoAf.FormattingEnabled = true;
            cmbPeriodoAf.Items.AddRange(new object[] { "Años", "Meses", "Semestres", "Trimestres" });
            cmbPeriodoAf.Location = new Point(574, 106);
            cmbPeriodoAf.Name = "cmbPeriodoAf";
            cmbPeriodoAf.Size = new Size(100, 23);
            cmbPeriodoAf.TabIndex = 60;
            // 
            // cmbInteresAf
            // 
            cmbInteresAf.FormattingEnabled = true;
            cmbInteresAf.Items.AddRange(new object[] { "Anual", "Mensual", "Semestral", "Trimestral" });
            cmbInteresAf.Location = new Point(389, 106);
            cmbInteresAf.Name = "cmbInteresAf";
            cmbInteresAf.Size = new Size(100, 23);
            cmbInteresAf.TabIndex = 59;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbno);
            groupBox1.Controls.Add(rdbSi);
            groupBox1.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(27, 106);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(157, 60);
            groupBox1.TabIndex = 58;
            groupBox1.TabStop = false;
            groupBox1.Text = "Capitalizable";
            // 
            // rdbno
            // 
            rdbno.AutoSize = true;
            rdbno.Location = new Point(69, 22);
            rdbno.Name = "rdbno";
            rdbno.Size = new Size(49, 27);
            rdbno.TabIndex = 1;
            rdbno.TabStop = true;
            rdbno.Text = "No";
            rdbno.UseVisualStyleBackColor = true;
            // 
            // rdbSi
            // 
            rdbSi.AutoSize = true;
            rdbSi.Location = new Point(6, 22);
            rdbSi.Name = "rdbSi";
            rdbSi.Size = new Size(42, 27);
            rdbSi.TabIndex = 0;
            rdbSi.TabStop = true;
            rdbSi.Text = "Si";
            rdbSi.UseVisualStyleBackColor = true;
            // 
            // FrmAnuFutuDife
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(689, 405);
            Controls.Add(cmbPeriodoAf);
            Controls.Add(cmbInteresAf);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Controls.Add(btnLim);
            Controls.Add(btnCal);
            Controls.Add(dgvResultadosAnualidadFuturo);
            Controls.Add(txtPeriodoAnualidadFuturo);
            Controls.Add(label4);
            Controls.Add(txtInteresAnualidadFuturo);
            Controls.Add(label3);
            Controls.Add(txtValorFuturoAnualidadFuturo);
            Controls.Add(label1);
            Name = "FrmAnuFutuDife";
            Text = "FrmAnuFutuDife";
            ((System.ComponentModel.ISupportInitialize)dgvResultadosAnualidadFuturo).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Button btnLim;
        private Button btnCal;
        private DataGridView dgvResultadosAnualidadFuturo;
        private TextBox txtPeriodoAnualidadFuturo;
        private Label label4;
        private TextBox txtInteresAnualidadFuturo;
        private Label label3;
        private TextBox txtValorFuturoAnualidadFuturo;
        private Label label1;
        private ComboBox cmbPeriodoAf;
        private ComboBox cmbInteresAf;
        private GroupBox groupBox1;
        private RadioButton rdbno;
        private RadioButton rdbSi;
    }
}