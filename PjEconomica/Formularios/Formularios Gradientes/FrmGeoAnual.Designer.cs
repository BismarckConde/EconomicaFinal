namespace PjEconomica.Formularios.Formularios_Gradientes
{
    partial class FrmGeoAnual
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
            txtNominal = new TextBox();
            label3 = new Label();
            btnLim = new Button();
            btncal = new Button();
            dataGridView1 = new DataGridView();
            txtPeri = new TextBox();
            txtinte = new TextBox();
            txtanu = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            cmbperi = new ComboBox();
            cmbInteresF = new ComboBox();
            cmbTasaNomF = new ComboBox();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbTasaNomF);
            groupBox1.Controls.Add(cmbperi);
            groupBox1.Controls.Add(cmbInteresF);
            groupBox1.Controls.Add(txtNominal);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnLim);
            groupBox1.Controls.Add(btncal);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(txtPeri);
            groupBox1.Controls.Add(txtinte);
            groupBox1.Controls.Add(txtanu);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Sitka Text", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(23, 50);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(763, 409);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingrese los datos";
            // 
            // txtNominal
            // 
            txtNominal.Location = new Point(182, 82);
            txtNominal.Name = "txtNominal";
            txtNominal.Size = new Size(100, 26);
            txtNominal.TabIndex = 13;
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
            btnLim.Location = new Point(634, 347);
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
            btncal.Location = new Point(490, 347);
            btncal.Name = "btncal";
            btncal.Size = new Size(112, 37);
            btncal.TabIndex = 10;
            btncal.Text = "Calcular";
            btncal.UseVisualStyleBackColor = false;
            btncal.Click += btncal_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(17, 178);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(729, 150);
            dataGridView1.TabIndex = 9;
            // 
            // txtPeri
            // 
            txtPeri.Location = new Point(543, 38);
            txtPeri.Name = "txtPeri";
            txtPeri.Size = new Size(100, 26);
            txtPeri.TabIndex = 7;
            // 
            // txtinte
            // 
            txtinte.Location = new Point(358, 38);
            txtinte.Name = "txtinte";
            txtinte.Size = new Size(100, 26);
            txtinte.TabIndex = 6;
            // 
            // txtanu
            // 
            txtanu.Location = new Point(112, 39);
            txtanu.Name = "txtanu";
            txtanu.Size = new Size(100, 26);
            txtanu.TabIndex = 4;
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
            label1.Location = new Point(214, 9);
            label1.Name = "label1";
            label1.Size = new Size(412, 28);
            label1.TabIndex = 8;
            label1.Text = "Calculo de gradiente geometrico anualidad\r\n";
            // 
            // cmbperi
            // 
            cmbperi.FormattingEnabled = true;
            cmbperi.Items.AddRange(new object[] { "Años", "Meses", "Trimestres", "Semestres" });
            cmbperi.Location = new Point(543, 85);
            cmbperi.Name = "cmbperi";
            cmbperi.Size = new Size(100, 29);
            cmbperi.TabIndex = 18;
            // 
            // cmbInteresF
            // 
            cmbInteresF.FormattingEnabled = true;
            cmbInteresF.Items.AddRange(new object[] { "Anual", "Mensual", "Trimestral", "Semestral" });
            cmbInteresF.Location = new Point(358, 82);
            cmbInteresF.Name = "cmbInteresF";
            cmbInteresF.Size = new Size(100, 29);
            cmbInteresF.TabIndex = 17;
            // 
            // cmbTasaNomF
            // 
            cmbTasaNomF.FormattingEnabled = true;
            cmbTasaNomF.Items.AddRange(new object[] { "Anual", "Mensual", "Trimestral", "Semestral" });
            cmbTasaNomF.Location = new Point(182, 124);
            cmbTasaNomF.Name = "cmbTasaNomF";
            cmbTasaNomF.Size = new Size(100, 29);
            cmbTasaNomF.TabIndex = 19;
            // 
            // Column1
            // 
            Column1.HeaderText = "Anualidad";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Tasa Interes (I)";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Tasa Nominal (J)";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Periodo";
            Column4.Name = "Column4";
            Column4.Width = 120;
            // 
            // Column5
            // 
            Column5.HeaderText = "Total";
            Column5.Name = "Column5";
            Column5.Width = 130;
            // 
            // FrmGeoAnual
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 476);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "FrmGeoAnual";
            Text = "FrmGeoAnual";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtNominal;
        private Label label3;
        private Button btnLim;
        private Button btncal;
        private DataGridView dataGridView1;
        private TextBox txtPeri;
        private TextBox txtinte;
        private TextBox txtanu;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private ComboBox cmbperi;
        private ComboBox cmbInteresF;
        private ComboBox cmbTasaNomF;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}