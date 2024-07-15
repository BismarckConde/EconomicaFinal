namespace PjEconomica.Formularios.Formularios_Anualidades.Anualidad_Anticipada
{
    partial class FrmPresenteAnual
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
            label1 = new Label();
            label2 = new Label();
            txtanu = new TextBox();
            txttasa = new TextBox();
            label3 = new Label();
            txtperi = new TextBox();
            label4 = new Label();
            dgvResultadosPresente = new DataGridView();
            btnCal = new Button();
            btnLim = new Button();
            cmbInteresPresente = new ComboBox();
            cmbPeriodoPresente = new ComboBox();
            groupBox1 = new GroupBox();
            rdbNoFuturo = new RadioButton();
            rdbSiFuturo = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dgvResultadosPresente).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(262, 19);
            label1.Name = "label1";
            label1.Size = new Size(190, 30);
            label1.TabIndex = 0;
            label1.Text = "Ingrese los datos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 11.249999F);
            label2.Location = new Point(45, 71);
            label2.Name = "label2";
            label2.Size = new Size(91, 21);
            label2.TabIndex = 1;
            label2.Text = "Anualidad :";
            // 
            // txtanu
            // 
            txtanu.Font = new Font("Sitka Text", 11.249999F);
            txtanu.Location = new Point(142, 71);
            txtanu.Name = "txtanu";
            txtanu.Size = new Size(100, 26);
            txtanu.TabIndex = 2;
            // 
            // txttasa
            // 
            txttasa.Font = new Font("Sitka Text", 11.249999F);
            txttasa.Location = new Point(390, 71);
            txttasa.Name = "txttasa";
            txttasa.Size = new Size(100, 26);
            txttasa.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Text", 11.249999F);
            label3.Location = new Point(262, 71);
            label3.Name = "label3";
            label3.Size = new Size(125, 21);
            label3.TabIndex = 3;
            label3.Text = "Tasa de interes :";
            // 
            // txtperi
            // 
            txtperi.Font = new Font("Sitka Text", 11.249999F);
            txtperi.Location = new Point(587, 71);
            txtperi.Name = "txtperi";
            txtperi.Size = new Size(100, 26);
            txtperi.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Text", 11.249999F);
            label4.Location = new Point(508, 71);
            label4.Name = "label4";
            label4.Size = new Size(73, 21);
            label4.TabIndex = 5;
            label4.Text = "Periodo :";
            // 
            // dgvResultadosPresente
            // 
            dgvResultadosPresente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultadosPresente.Location = new Point(45, 185);
            dgvResultadosPresente.Name = "dgvResultadosPresente";
            dgvResultadosPresente.Size = new Size(642, 150);
            dgvResultadosPresente.TabIndex = 7;
            // 
            // btnCal
            // 
            btnCal.BackColor = Color.White;
            btnCal.Font = new Font("Sitka Text", 11.249999F);
            btnCal.Location = new Point(451, 349);
            btnCal.Name = "btnCal";
            btnCal.Size = new Size(104, 32);
            btnCal.TabIndex = 8;
            btnCal.Text = "Calcular";
            btnCal.UseVisualStyleBackColor = false;
            btnCal.Click += btnCal_Click;
            // 
            // btnLim
            // 
            btnLim.BackColor = Color.White;
            btnLim.Font = new Font("Sitka Text", 11.249999F);
            btnLim.Location = new Point(583, 349);
            btnLim.Name = "btnLim";
            btnLim.Size = new Size(104, 32);
            btnLim.TabIndex = 9;
            btnLim.Text = "Limpiar";
            btnLim.UseVisualStyleBackColor = false;
            btnLim.Click += btnLim_Click;
            // 
            // cmbInteresPresente
            // 
            cmbInteresPresente.FormattingEnabled = true;
            cmbInteresPresente.Items.AddRange(new object[] { "Anual", "Mensual", "Semestral", "Trimestral" });
            cmbInteresPresente.Location = new Point(390, 103);
            cmbInteresPresente.Name = "cmbInteresPresente";
            cmbInteresPresente.Size = new Size(100, 23);
            cmbInteresPresente.TabIndex = 2;
            // 
            // cmbPeriodoPresente
            // 
            cmbPeriodoPresente.FormattingEnabled = true;
            cmbPeriodoPresente.Items.AddRange(new object[] { "Años", "Meses", "Semestres", "Trimestres" });
            cmbPeriodoPresente.Location = new Point(587, 103);
            cmbPeriodoPresente.Name = "cmbPeriodoPresente";
            cmbPeriodoPresente.Size = new Size(100, 23);
            cmbPeriodoPresente.TabIndex = 11;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbNoFuturo);
            groupBox1.Controls.Add(rdbSiFuturo);
            groupBox1.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(45, 115);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 53);
            groupBox1.TabIndex = 23;
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
            // FrmPresenteAnual
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(715, 397);
            Controls.Add(groupBox1);
            Controls.Add(cmbPeriodoPresente);
            Controls.Add(cmbInteresPresente);
            Controls.Add(btnLim);
            Controls.Add(btnCal);
            Controls.Add(dgvResultadosPresente);
            Controls.Add(txtperi);
            Controls.Add(label4);
            Controls.Add(txttasa);
            Controls.Add(label3);
            Controls.Add(txtanu);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmPresenteAnual";
            Text = "FrmPresenteAnual";
            ((System.ComponentModel.ISupportInitialize)dgvResultadosPresente).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtanu;
        private TextBox txttasa;
        private Label label3;
        private TextBox txtperi;
        private Label label4;
        private DataGridView dgvResultadosPresente;
        private Button btnCal;
        private Button btnLim;
        private ComboBox cmbInteresPresente;
        private ComboBox cmbPeriodoPresente;
        private GroupBox groupBox1;
        private RadioButton rdbNoFuturo;
        private RadioButton rdbSiFuturo;
    }
}