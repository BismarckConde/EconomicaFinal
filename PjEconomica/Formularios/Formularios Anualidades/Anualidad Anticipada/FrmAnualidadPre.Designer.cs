namespace PjEconomica.Formularios.Formularios_Anualidades.Anualidad_Anticipada
{
    partial class FrmAnualidadPre
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
            dataGridView1 = new DataGridView();
            txtperi = new TextBox();
            label4 = new Label();
            txttasa = new TextBox();
            label3 = new Label();
            txtVP = new TextBox();
            label2 = new Label();
            label1 = new Label();
            cmbPeriodoFuturo = new ComboBox();
            cmbInteresAnualidadF = new ComboBox();
            groupBox1 = new GroupBox();
            rdbNoFuturo = new RadioButton();
            rdbSiFuturo = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLim
            // 
            btnLim.BackColor = Color.White;
            btnLim.Font = new Font("Sitka Text", 11.249999F);
            btnLim.Location = new Point(573, 353);
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
            btnCal.Location = new Point(441, 353);
            btnCal.Name = "btnCal";
            btnCal.Size = new Size(104, 32);
            btnCal.TabIndex = 19;
            btnCal.Text = "Calcular";
            btnCal.UseVisualStyleBackColor = false;
            btnCal.Click += btnCal_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(35, 189);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(642, 150);
            dataGridView1.TabIndex = 18;
            // 
            // txtperi
            // 
            txtperi.Font = new Font("Sitka Text", 11.249999F);
            txtperi.Location = new Point(577, 61);
            txtperi.Name = "txtperi";
            txtperi.Size = new Size(100, 26);
            txtperi.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Text", 11.249999F);
            label4.Location = new Point(498, 61);
            label4.Name = "label4";
            label4.Size = new Size(73, 21);
            label4.TabIndex = 16;
            label4.Text = "Periodo :";
            // 
            // txttasa
            // 
            txttasa.Font = new Font("Sitka Text", 11.249999F);
            txttasa.Location = new Point(380, 61);
            txttasa.Name = "txttasa";
            txttasa.Size = new Size(100, 26);
            txttasa.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Text", 11.249999F);
            label3.Location = new Point(252, 61);
            label3.Name = "label3";
            label3.Size = new Size(125, 21);
            label3.TabIndex = 14;
            label3.Text = "Tasa de interes :";
            // 
            // txtVP
            // 
            txtVP.Font = new Font("Sitka Text", 11.249999F);
            txtVP.Location = new Point(146, 61);
            txtVP.Name = "txtVP";
            txtVP.Size = new Size(100, 26);
            txtVP.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 11.249999F);
            label2.Location = new Point(18, 61);
            label2.Name = "label2";
            label2.Size = new Size(122, 21);
            label2.TabIndex = 12;
            label2.Text = "Valor Presente :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(252, 9);
            label1.Name = "label1";
            label1.Size = new Size(190, 30);
            label1.TabIndex = 11;
            label1.Text = "Ingrese los datos";
            // 
            // cmbPeriodoFuturo
            // 
            cmbPeriodoFuturo.FormattingEnabled = true;
            cmbPeriodoFuturo.Items.AddRange(new object[] { "Años", "Meses", "Semestres", "Trimestres" });
            cmbPeriodoFuturo.Location = new Point(577, 93);
            cmbPeriodoFuturo.Name = "cmbPeriodoFuturo";
            cmbPeriodoFuturo.Size = new Size(100, 23);
            cmbPeriodoFuturo.TabIndex = 27;
            // 
            // cmbInteresAnualidadF
            // 
            cmbInteresAnualidadF.FormattingEnabled = true;
            cmbInteresAnualidadF.Items.AddRange(new object[] { "Anual", "Mensual", "Semestral", "Trimestral" });
            cmbInteresAnualidadF.Location = new Point(380, 93);
            cmbInteresAnualidadF.Name = "cmbInteresAnualidadF";
            cmbInteresAnualidadF.Size = new Size(100, 23);
            cmbInteresAnualidadF.TabIndex = 26;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbNoFuturo);
            groupBox1.Controls.Add(rdbSiFuturo);
            groupBox1.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(18, 106);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 53);
            groupBox1.TabIndex = 25;
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
            // FrmAnualidadPre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 392);
            Controls.Add(cmbPeriodoFuturo);
            Controls.Add(cmbInteresAnualidadF);
            Controls.Add(groupBox1);
            Controls.Add(btnLim);
            Controls.Add(btnCal);
            Controls.Add(dataGridView1);
            Controls.Add(txtperi);
            Controls.Add(label4);
            Controls.Add(txttasa);
            Controls.Add(label3);
            Controls.Add(txtVP);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmAnualidadPre";
            Text = "FrmAnualidadPre";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnLim;
        private Button btnCal;
        private DataGridView dataGridView1;
        private TextBox txtperi;
        private Label label4;
        private TextBox txttasa;
        private Label label3;
        private TextBox txtVP;
        private Label label2;
        private Label label1;
        private ComboBox cmbPeriodoFuturo;
        private ComboBox cmbInteresAnualidadF;
        private GroupBox groupBox1;
        private RadioButton rdbNoFuturo;
        private RadioButton rdbSiFuturo;
    }
}