namespace PjEconomica.Formularios.Formularios_Gradientes
{
    partial class FrmGeoFuturo
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
            cmbperi = new ComboBox();
            cmbInteresF = new ComboBox();
            cmbTasaNomF = new ComboBox();
            txtInteresJ = new TextBox();
            label3 = new Label();
            btnLim = new Button();
            btncal = new Button();
            dgvFuturoGeometrico = new DataGridView();
            txtPeriodoF = new TextBox();
            txtInteresFuturo = new TextBox();
            txtAnualidadFuturo = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFuturoGeometrico).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbperi);
            groupBox1.Controls.Add(cmbInteresF);
            groupBox1.Controls.Add(cmbTasaNomF);
            groupBox1.Controls.Add(txtInteresJ);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnLim);
            groupBox1.Controls.Add(btncal);
            groupBox1.Controls.Add(dgvFuturoGeometrico);
            groupBox1.Controls.Add(txtPeriodoF);
            groupBox1.Controls.Add(txtInteresFuturo);
            groupBox1.Controls.Add(txtAnualidadFuturo);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Sitka Text", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(19, 65);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(763, 372);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingrese los datos";
            // 
            // cmbperi
            // 
            cmbperi.FormattingEnabled = true;
            cmbperi.Items.AddRange(new object[] { "Años", "Meses", "Trimestres", "Semestres" });
            cmbperi.Location = new Point(543, 82);
            cmbperi.Name = "cmbperi";
            cmbperi.Size = new Size(100, 29);
            cmbperi.TabIndex = 16;
            // 
            // cmbInteresF
            // 
            cmbInteresF.FormattingEnabled = true;
            cmbInteresF.Items.AddRange(new object[] { "Anual", "Mensual", "Trimestral", "Semestral" });
            cmbInteresF.Location = new Point(358, 79);
            cmbInteresF.Name = "cmbInteresF";
            cmbInteresF.Size = new Size(100, 29);
            cmbInteresF.TabIndex = 15;
            // 
            // cmbTasaNomF
            // 
            cmbTasaNomF.FormattingEnabled = true;
            cmbTasaNomF.Items.AddRange(new object[] { "Anual", "Mensual", "Trimestral", "Semestral" });
            cmbTasaNomF.Location = new Point(182, 124);
            cmbTasaNomF.Name = "cmbTasaNomF";
            cmbTasaNomF.Size = new Size(100, 29);
            cmbTasaNomF.TabIndex = 14;
            // 
            // txtInteresJ
            // 
            txtInteresJ.Location = new Point(182, 82);
            txtInteresJ.Name = "txtInteresJ";
            txtInteresJ.Size = new Size(100, 26);
            txtInteresJ.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 85);
            label3.Name = "label3";
            label3.Size = new Size(159, 21);
            label3.TabIndex = 12;
            label3.Text = " Interes Nominal (j) :";
            // 
            // btnLim
            // 
            btnLim.BackColor = Color.White;
            btnLim.Location = new Point(623, 328);
            btnLim.Name = "btnLim";
            btnLim.Size = new Size(112, 37);
            btnLim.TabIndex = 11;
            btnLim.Text = "Limpiar";
            btnLim.UseVisualStyleBackColor = false;
            btnLim.Click += btnLim_Click;
            // 
            // btncal
            // 
            btncal.BackColor = SystemColors.ControlLightLight;
            btncal.Location = new Point(479, 328);
            btncal.Name = "btncal";
            btncal.Size = new Size(112, 37);
            btncal.TabIndex = 10;
            btncal.Text = "Calcular";
            btncal.UseVisualStyleBackColor = false;
            btncal.Click += btncal_Click;
            // 
            // dgvFuturoGeometrico
            // 
            dgvFuturoGeometrico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFuturoGeometrico.Location = new Point(6, 159);
            dgvFuturoGeometrico.Name = "dgvFuturoGeometrico";
            dgvFuturoGeometrico.Size = new Size(729, 150);
            dgvFuturoGeometrico.TabIndex = 9;
            // 
            // txtPeriodoF
            // 
            txtPeriodoF.Location = new Point(543, 38);
            txtPeriodoF.Name = "txtPeriodoF";
            txtPeriodoF.Size = new Size(100, 26);
            txtPeriodoF.TabIndex = 7;
            // 
            // txtInteresFuturo
            // 
            txtInteresFuturo.Location = new Point(358, 38);
            txtInteresFuturo.Name = "txtInteresFuturo";
            txtInteresFuturo.Size = new Size(100, 26);
            txtInteresFuturo.TabIndex = 6;
            // 
            // txtAnualidadFuturo
            // 
            txtAnualidadFuturo.Location = new Point(112, 39);
            txtAnualidadFuturo.Name = "txtAnualidadFuturo";
            txtAnualidadFuturo.Size = new Size(100, 26);
            txtAnualidadFuturo.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(464, 39);
            label5.Name = "label5";
            label5.Size = new Size(73, 21);
            label5.TabIndex = 3;
            label5.Text = "Periodo :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(218, 39);
            label4.Name = "label4";
            label4.Size = new Size(143, 21);
            label4.TabIndex = 2;
            label4.Text = "Tasa de Interes (i):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 39);
            label2.Name = "label2";
            label2.Size = new Size(91, 21);
            label2.TabIndex = 0;
            label2.Text = "Anualidad :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(210, 24);
            label1.Name = "label1";
            label1.Size = new Size(377, 28);
            label1.TabIndex = 6;
            label1.Text = "Calculo de gradiente geometrico futuro\r\n";
            // 
            // FrmGeoFuturo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 460);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "FrmGeoFuturo";
            Text = "FrmGeoFuturo";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFuturoGeometrico).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtInteresJ;
        private Label label3;
        private Button btnLim;
        private Button btncal;
        private DataGridView dgvFuturoGeometrico;
        private TextBox txtPeriodoF;
        private TextBox txtInteresFuturo;
        private TextBox txtAnualidadFuturo;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private ComboBox cmbperi;
        private ComboBox cmbInteresF;
        private ComboBox cmbTasaNomF;
    }
}