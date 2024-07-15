namespace PjEconomica.Formularios.Formularios_Gradientes
{
    partial class FrmGeoPresent
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
            cmbPeriodo = new ComboBox();
            cmbTasaNom = new ComboBox();
            cmbTasaInt = new ComboBox();
            txtIntNomPGeom = new TextBox();
            label3 = new Label();
            btnLim = new Button();
            btncal = new Button();
            dgvCalculoPGeometrico = new DataGridView();
            txtPeriodoPGeom = new TextBox();
            txtIntPGeom = new TextBox();
            txtAnuualidadPGeom = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            Anualidad = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCalculoPGeometrico).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbPeriodo);
            groupBox1.Controls.Add(cmbTasaNom);
            groupBox1.Controls.Add(cmbTasaInt);
            groupBox1.Controls.Add(txtIntNomPGeom);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnLim);
            groupBox1.Controls.Add(btncal);
            groupBox1.Controls.Add(dgvCalculoPGeometrico);
            groupBox1.Controls.Add(txtPeriodoPGeom);
            groupBox1.Controls.Add(txtIntPGeom);
            groupBox1.Controls.Add(txtAnuualidadPGeom);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Sitka Text", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(20, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(778, 395);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingrese los datos";
            // 
            // cmbPeriodo
            // 
            cmbPeriodo.FormattingEnabled = true;
            cmbPeriodo.Location = new Point(96, 128);
            cmbPeriodo.Name = "cmbPeriodo";
            cmbPeriodo.Size = new Size(100, 29);
            cmbPeriodo.TabIndex = 16;
            // 
            // cmbTasaNom
            // 
            cmbTasaNom.FormattingEnabled = true;
            cmbTasaNom.Location = new Point(645, 82);
            cmbTasaNom.Name = "cmbTasaNom";
            cmbTasaNom.Size = new Size(100, 29);
            cmbTasaNom.TabIndex = 15;
            // 
            // cmbTasaInt
            // 
            cmbTasaInt.FormattingEnabled = true;
            cmbTasaInt.Location = new Point(358, 85);
            cmbTasaInt.Name = "cmbTasaInt";
            cmbTasaInt.Size = new Size(100, 29);
            cmbTasaInt.TabIndex = 14;
            // 
            // txtIntNomPGeom
            // 
            txtIntNomPGeom.Location = new Point(645, 36);
            txtIntNomPGeom.Name = "txtIntNomPGeom";
            txtIntNomPGeom.Size = new Size(100, 26);
            txtIntNomPGeom.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(480, 39);
            label3.Name = "label3";
            label3.Size = new Size(159, 21);
            label3.TabIndex = 12;
            label3.Text = " Interes Nominal (j) :";
            // 
            // btnLim
            // 
            btnLim.BackColor = Color.White;
            btnLim.Location = new Point(637, 339);
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
            btncal.Location = new Point(493, 339);
            btncal.Name = "btncal";
            btncal.Size = new Size(112, 37);
            btncal.TabIndex = 10;
            btncal.Text = "Calcular";
            btncal.UseVisualStyleBackColor = false;
            btncal.Click += btncal_Click;
            // 
            // dgvCalculoPGeometrico
            // 
            dgvCalculoPGeometrico.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCalculoPGeometrico.Columns.AddRange(new DataGridViewColumn[] { Anualidad, Column1, Column3, Column2, Column4 });
            dgvCalculoPGeometrico.Location = new Point(17, 172);
            dgvCalculoPGeometrico.Name = "dgvCalculoPGeometrico";
            dgvCalculoPGeometrico.Size = new Size(729, 150);
            dgvCalculoPGeometrico.TabIndex = 9;
            // 
            // txtPeriodoPGeom
            // 
            txtPeriodoPGeom.Location = new Point(96, 85);
            txtPeriodoPGeom.Name = "txtPeriodoPGeom";
            txtPeriodoPGeom.Size = new Size(100, 26);
            txtPeriodoPGeom.TabIndex = 7;
            // 
            // txtIntPGeom
            // 
            txtIntPGeom.Location = new Point(358, 38);
            txtIntPGeom.Name = "txtIntPGeom";
            txtIntPGeom.Size = new Size(100, 26);
            txtIntPGeom.TabIndex = 6;
            // 
            // txtAnuualidadPGeom
            // 
            txtAnuualidadPGeom.Location = new Point(112, 39);
            txtAnuualidadPGeom.Name = "txtAnuualidadPGeom";
            txtAnuualidadPGeom.Size = new Size(100, 26);
            txtAnuualidadPGeom.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 86);
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
            label1.Location = new Point(193, 21);
            label1.Name = "label1";
            label1.Size = new Size(398, 28);
            label1.TabIndex = 4;
            label1.Text = "Calculo de gradiente geometrico presente\r\n";
            // 
            // Anualidad
            // 
            Anualidad.HeaderText = "Anualidad";
            Anualidad.Name = "Anualidad";
            // 
            // Column1
            // 
            Column1.HeaderText = "Tasa Interes (I)";
            Column1.Name = "Column1";
            // 
            // Column3
            // 
            Column3.HeaderText = "Tasa Nominal (J)";
            Column3.Name = "Column3";
            Column3.Width = 130;
            // 
            // Column2
            // 
            Column2.HeaderText = "Periodo";
            Column2.Name = "Column2";
            // 
            // Column4
            // 
            Column4.HeaderText = "Total";
            Column4.Name = "Column4";
            Column4.Width = 130;
            // 
            // FrmGeoPresent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 483);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "FrmGeoPresent";
            Text = "FrmGeoPresent";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCalculoPGeometrico).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnLim;
        private Button btncal;
        private DataGridView dgvCalculoPGeometrico;
        private TextBox txtPeriodoPGeom;
        private TextBox txtIntPGeom;
        private TextBox txtAnuualidadPGeom;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox txtIntNomPGeom;
        private Label label3;
        private ComboBox cmbPeriodo;
        private ComboBox cmbTasaNom;
        private ComboBox cmbTasaInt;
        private DataGridViewTextBoxColumn Anualidad;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
    }
}