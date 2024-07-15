namespace PjEconomica.Formularios.Formularios_Anualidades.Anualidades_Diferidas
{
    partial class FrmFuDife
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
            rdbno = new RadioButton();
            rdbSi = new RadioButton();
            cmbPeriodoFuturo2 = new ComboBox();
            cmbPeriodoFuturo = new ComboBox();
            cmbInteresFuturo = new ComboBox();
            txtPeriodo2Futuro = new TextBox();
            label5 = new Label();
            btnLim = new Button();
            btnCal = new Button();
            dgvResultadosFuturo = new DataGridView();
            txtPeriodo1Futuro = new TextBox();
            label4 = new Label();
            txtTasaInteresFuturo = new TextBox();
            label3 = new Label();
            txtValorAnualidadFuturo = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResultadosFuturo).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbno);
            groupBox1.Controls.Add(rdbSi);
            groupBox1.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(9, 102);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(157, 60);
            groupBox1.TabIndex = 54;
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
            // cmbPeriodoFuturo2
            // 
            cmbPeriodoFuturo2.FormattingEnabled = true;
            cmbPeriodoFuturo2.Items.AddRange(new object[] { "Años", "Meses", "Semestres", "Trimestres" });
            cmbPeriodoFuturo2.Location = new Point(748, 102);
            cmbPeriodoFuturo2.Name = "cmbPeriodoFuturo2";
            cmbPeriodoFuturo2.Size = new Size(100, 23);
            cmbPeriodoFuturo2.TabIndex = 53;
            // 
            // cmbPeriodoFuturo
            // 
            cmbPeriodoFuturo.FormattingEnabled = true;
            cmbPeriodoFuturo.Items.AddRange(new object[] { "Años", "Meses", "Semestres", "Trimestres" });
            cmbPeriodoFuturo.Location = new Point(551, 102);
            cmbPeriodoFuturo.Name = "cmbPeriodoFuturo";
            cmbPeriodoFuturo.Size = new Size(100, 23);
            cmbPeriodoFuturo.TabIndex = 52;
            cmbPeriodoFuturo.SelectedIndexChanged += cmbPeriodoPresente_SelectedIndexChanged;
            // 
            // cmbInteresFuturo
            // 
            cmbInteresFuturo.FormattingEnabled = true;
            cmbInteresFuturo.Items.AddRange(new object[] { "Anual", "Mensual", "Semestral", "Trimestral" });
            cmbInteresFuturo.Location = new Point(354, 102);
            cmbInteresFuturo.Name = "cmbInteresFuturo";
            cmbInteresFuturo.Size = new Size(100, 23);
            cmbInteresFuturo.TabIndex = 51;
            // 
            // txtPeriodo2Futuro
            // 
            txtPeriodo2Futuro.Font = new Font("Sitka Text", 11.249999F);
            txtPeriodo2Futuro.Location = new Point(748, 64);
            txtPeriodo2Futuro.Name = "txtPeriodo2Futuro";
            txtPeriodo2Futuro.Size = new Size(100, 26);
            txtPeriodo2Futuro.TabIndex = 50;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Text", 11.249999F);
            label5.Location = new Point(657, 64);
            label5.Name = "label5";
            label5.Size = new Size(86, 21);
            label5.TabIndex = 49;
            label5.Text = "Periodo 2 :";
            // 
            // btnLim
            // 
            btnLim.BackColor = Color.White;
            btnLim.Font = new Font("Sitka Text", 11.249999F);
            btnLim.Location = new Point(674, 237);
            btnLim.Name = "btnLim";
            btnLim.Size = new Size(174, 32);
            btnLim.TabIndex = 48;
            btnLim.Text = "Limpiar";
            btnLim.UseVisualStyleBackColor = false;
            btnLim.Click += btnLim_Click;
            // 
            // btnCal
            // 
            btnCal.BackColor = Color.White;
            btnCal.Font = new Font("Sitka Text", 11.249999F);
            btnCal.Location = new Point(674, 178);
            btnCal.Name = "btnCal";
            btnCal.Size = new Size(174, 32);
            btnCal.TabIndex = 47;
            btnCal.Text = "Calcular";
            btnCal.UseVisualStyleBackColor = false;
            btnCal.Click += btnCal_Click;
            // 
            // dgvResultadosFuturo
            // 
            dgvResultadosFuturo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultadosFuturo.Location = new Point(9, 178);
            dgvResultadosFuturo.Name = "dgvResultadosFuturo";
            dgvResultadosFuturo.Size = new Size(642, 150);
            dgvResultadosFuturo.TabIndex = 46;
            // 
            // txtPeriodo1Futuro
            // 
            txtPeriodo1Futuro.Font = new Font("Sitka Text", 11.249999F);
            txtPeriodo1Futuro.Location = new Point(551, 61);
            txtPeriodo1Futuro.Name = "txtPeriodo1Futuro";
            txtPeriodo1Futuro.Size = new Size(100, 26);
            txtPeriodo1Futuro.TabIndex = 45;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Text", 11.249999F);
            label4.Location = new Point(472, 61);
            label4.Name = "label4";
            label4.Size = new Size(84, 21);
            label4.TabIndex = 44;
            label4.Text = "Periodo 1 :";
            // 
            // txtTasaInteresFuturo
            // 
            txtTasaInteresFuturo.Font = new Font("Sitka Text", 11.249999F);
            txtTasaInteresFuturo.Location = new Point(354, 61);
            txtTasaInteresFuturo.Name = "txtTasaInteresFuturo";
            txtTasaInteresFuturo.Size = new Size(100, 26);
            txtTasaInteresFuturo.TabIndex = 43;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Text", 11.249999F);
            label3.Location = new Point(226, 61);
            label3.Name = "label3";
            label3.Size = new Size(125, 21);
            label3.TabIndex = 42;
            label3.Text = "Tasa de interes :";
            // 
            // txtValorAnualidadFuturo
            // 
            txtValorAnualidadFuturo.Font = new Font("Sitka Text", 11.249999F);
            txtValorAnualidadFuturo.Location = new Point(106, 61);
            txtValorAnualidadFuturo.Name = "txtValorAnualidadFuturo";
            txtValorAnualidadFuturo.Size = new Size(100, 26);
            txtValorAnualidadFuturo.TabIndex = 41;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 11.249999F);
            label2.Location = new Point(9, 61);
            label2.Name = "label2";
            label2.Size = new Size(91, 21);
            label2.TabIndex = 40;
            label2.Text = "Anualidad :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(343, 9);
            label1.Name = "label1";
            label1.Size = new Size(190, 30);
            label1.TabIndex = 39;
            label1.Text = "Ingrese los datos";
            // 
            // FrmFuDife
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 344);
            Controls.Add(groupBox1);
            Controls.Add(cmbPeriodoFuturo2);
            Controls.Add(cmbPeriodoFuturo);
            Controls.Add(cmbInteresFuturo);
            Controls.Add(txtPeriodo2Futuro);
            Controls.Add(label5);
            Controls.Add(btnLim);
            Controls.Add(btnCal);
            Controls.Add(dgvResultadosFuturo);
            Controls.Add(txtPeriodo1Futuro);
            Controls.Add(label4);
            Controls.Add(txtTasaInteresFuturo);
            Controls.Add(label3);
            Controls.Add(txtValorAnualidadFuturo);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmFuDife";
            Text = "FrmFuDife";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResultadosFuturo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rdbno;
        private RadioButton rdbSi;
        private ComboBox cmbPeriodoFuturo2;
        private ComboBox cmbPeriodoFuturo;
        private ComboBox cmbInteresFuturo;
        private TextBox txtPeriodo2Futuro;
        private Label label5;
        private Button btnLim;
        private Button btnCal;
        private DataGridView dgvResultadosFuturo;
        private TextBox txtPeriodo1Futuro;
        private Label label4;
        private TextBox txtTasaInteresFuturo;
        private Label label3;
        private TextBox txtValorAnualidadFuturo;
        private Label label2;
        private Label label1;
    }
}