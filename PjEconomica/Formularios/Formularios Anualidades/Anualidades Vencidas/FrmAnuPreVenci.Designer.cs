namespace PjEconomica.Formularios.Formularios_Anualidades.Anualidades_Vencidas
{
    partial class FrmAnuPreVenci
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
            dgvResultadosAnualidadPresente = new DataGridView();
            txtPeriodoAnualidadVencida = new TextBox();
            label4 = new Label();
            txtInteresAnualidadVencida = new TextBox();
            label3 = new Label();
            txtValorPresenteAnualidadVencida = new TextBox();
            label2 = new Label();
            label1 = new Label();
            cmbPeriodoA = new ComboBox();
            cmbInteresA = new ComboBox();
            groupBox1 = new GroupBox();
            rdbNoFuturo = new RadioButton();
            rdbSiFuturo = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dgvResultadosAnualidadPresente).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLim
            // 
            btnLim.BackColor = Color.White;
            btnLim.Font = new Font("Sitka Text", 11.249999F);
            btnLim.Location = new Point(574, 345);
            btnLim.Name = "btnLim";
            btnLim.Size = new Size(104, 32);
            btnLim.TabIndex = 31;
            btnLim.Text = "Limpiar";
            btnLim.UseVisualStyleBackColor = false;
            btnLim.Click += btnLim_Click;
            // 
            // btnCal
            // 
            btnCal.BackColor = Color.White;
            btnCal.Font = new Font("Sitka Text", 11.249999F);
            btnCal.Location = new Point(442, 345);
            btnCal.Name = "btnCal";
            btnCal.Size = new Size(104, 32);
            btnCal.TabIndex = 30;
            btnCal.Text = "Calcular";
            btnCal.UseVisualStyleBackColor = false;
            btnCal.Click += btnCal_Click;
            // 
            // dgvResultadosAnualidadPresente
            // 
            dgvResultadosAnualidadPresente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultadosAnualidadPresente.Location = new Point(36, 181);
            dgvResultadosAnualidadPresente.Name = "dgvResultadosAnualidadPresente";
            dgvResultadosAnualidadPresente.Size = new Size(642, 150);
            dgvResultadosAnualidadPresente.TabIndex = 29;
            // 
            // txtPeriodoAnualidadVencida
            // 
            txtPeriodoAnualidadVencida.Font = new Font("Sitka Text", 11.249999F);
            txtPeriodoAnualidadVencida.Location = new Point(580, 61);
            txtPeriodoAnualidadVencida.Name = "txtPeriodoAnualidadVencida";
            txtPeriodoAnualidadVencida.Size = new Size(100, 26);
            txtPeriodoAnualidadVencida.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Text", 11.249999F);
            label4.Location = new Point(501, 61);
            label4.Name = "label4";
            label4.Size = new Size(73, 21);
            label4.TabIndex = 27;
            label4.Text = "Periodo :";
            // 
            // txtInteresAnualidadVencida
            // 
            txtInteresAnualidadVencida.Font = new Font("Sitka Text", 11.249999F);
            txtInteresAnualidadVencida.Location = new Point(383, 61);
            txtInteresAnualidadVencida.Name = "txtInteresAnualidadVencida";
            txtInteresAnualidadVencida.Size = new Size(100, 26);
            txtInteresAnualidadVencida.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Text", 11.249999F);
            label3.Location = new Point(255, 61);
            label3.Name = "label3";
            label3.Size = new Size(125, 21);
            label3.TabIndex = 25;
            label3.Text = "Tasa de interes :";
            // 
            // txtValorPresenteAnualidadVencida
            // 
            txtValorPresenteAnualidadVencida.Font = new Font("Sitka Text", 11.249999F);
            txtValorPresenteAnualidadVencida.Location = new Point(149, 61);
            txtValorPresenteAnualidadVencida.Name = "txtValorPresenteAnualidadVencida";
            txtValorPresenteAnualidadVencida.Size = new Size(100, 26);
            txtValorPresenteAnualidadVencida.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 11.249999F);
            label2.Location = new Point(17, 61);
            label2.Name = "label2";
            label2.Size = new Size(126, 21);
            label2.TabIndex = 23;
            label2.Text = "Valor Presente : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(238, 9);
            label1.Name = "label1";
            label1.Size = new Size(190, 30);
            label1.TabIndex = 22;
            label1.Text = "Ingrese los datos";
            // 
            // cmbPeriodoA
            // 
            cmbPeriodoA.FormattingEnabled = true;
            cmbPeriodoA.Items.AddRange(new object[] { "Años", "Meses", "Semestres", "Trimestres" });
            cmbPeriodoA.Location = new Point(578, 98);
            cmbPeriodoA.Name = "cmbPeriodoA";
            cmbPeriodoA.Size = new Size(100, 23);
            cmbPeriodoA.TabIndex = 34;
            // 
            // cmbInteresA
            // 
            cmbInteresA.FormattingEnabled = true;
            cmbInteresA.Items.AddRange(new object[] { "Anual", "Mensual", "Semestral", "Trimestral" });
            cmbInteresA.Location = new Point(381, 98);
            cmbInteresA.Name = "cmbInteresA";
            cmbInteresA.Size = new Size(100, 23);
            cmbInteresA.TabIndex = 33;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbNoFuturo);
            groupBox1.Controls.Add(rdbSiFuturo);
            groupBox1.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(36, 107);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 53);
            groupBox1.TabIndex = 32;
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
            // FrmAnuPreVenci
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 388);
            Controls.Add(cmbPeriodoA);
            Controls.Add(cmbInteresA);
            Controls.Add(groupBox1);
            Controls.Add(btnLim);
            Controls.Add(btnCal);
            Controls.Add(dgvResultadosAnualidadPresente);
            Controls.Add(txtPeriodoAnualidadVencida);
            Controls.Add(label4);
            Controls.Add(txtInteresAnualidadVencida);
            Controls.Add(label3);
            Controls.Add(txtValorPresenteAnualidadVencida);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmAnuPreVenci";
            Text = "FrmAnuPreVenci";
            ((System.ComponentModel.ISupportInitialize)dgvResultadosAnualidadPresente).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnLim;
        private Button btnCal;
        private DataGridView dgvResultadosAnualidadPresente;
        private TextBox txtPeriodoAnualidadVencida;
        private Label label4;
        private TextBox txtInteresAnualidadVencida;
        private Label label3;
        private TextBox txtValorPresenteAnualidadVencida;
        private Label label2;
        private Label label1;
        private ComboBox cmbPeriodoA;
        private ComboBox cmbInteresA;
        private GroupBox groupBox1;
        private RadioButton rdbNoFuturo;
        private RadioButton rdbSiFuturo;
    }
}