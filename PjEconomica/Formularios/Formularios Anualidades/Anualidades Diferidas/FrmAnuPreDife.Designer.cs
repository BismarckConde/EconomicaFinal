namespace PjEconomica.Formularios.Formularios_Anualidades.Anualidades_Diferidas
{
    partial class FrmAnuPreDife
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
            label5 = new Label();
            groupBox1 = new GroupBox();
            rdbno = new RadioButton();
            rdbSi = new RadioButton();
            cmbPeriodoA = new ComboBox();
            cmbInteresA = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvResultadosAnualidadPresente).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLim
            // 
            btnLim.BackColor = Color.White;
            btnLim.Font = new Font("Sitka Text", 11.249999F);
            btnLim.Location = new Point(558, 363);
            btnLim.Name = "btnLim";
            btnLim.Size = new Size(104, 32);
            btnLim.TabIndex = 44;
            btnLim.Text = "Limpiar";
            btnLim.UseVisualStyleBackColor = false;
            btnLim.Click += btnLim_Click;
            // 
            // btnCal
            // 
            btnCal.BackColor = Color.White;
            btnCal.Font = new Font("Sitka Text", 11.249999F);
            btnCal.Location = new Point(426, 363);
            btnCal.Name = "btnCal";
            btnCal.Size = new Size(104, 32);
            btnCal.TabIndex = 43;
            btnCal.Text = "Calcular";
            btnCal.UseVisualStyleBackColor = false;
            btnCal.Click += btnCal_Click;
            // 
            // dgvResultadosAnualidadPresente
            // 
            dgvResultadosAnualidadPresente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultadosAnualidadPresente.Location = new Point(20, 199);
            dgvResultadosAnualidadPresente.Name = "dgvResultadosAnualidadPresente";
            dgvResultadosAnualidadPresente.Size = new Size(642, 150);
            dgvResultadosAnualidadPresente.TabIndex = 42;
            // 
            // txtPeriodoAnualidadVencida
            // 
            txtPeriodoAnualidadVencida.Font = new Font("Sitka Text", 11.249999F);
            txtPeriodoAnualidadVencida.Location = new Point(562, 65);
            txtPeriodoAnualidadVencida.Name = "txtPeriodoAnualidadVencida";
            txtPeriodoAnualidadVencida.Size = new Size(100, 26);
            txtPeriodoAnualidadVencida.TabIndex = 41;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Text", 11.249999F);
            label4.Location = new Point(483, 65);
            label4.Name = "label4";
            label4.Size = new Size(77, 21);
            label4.TabIndex = 40;
            label4.Text = "Periodo  :";
            // 
            // txtInteresAnualidadVencida
            // 
            txtInteresAnualidadVencida.Font = new Font("Sitka Text", 11.249999F);
            txtInteresAnualidadVencida.Location = new Point(377, 63);
            txtInteresAnualidadVencida.Name = "txtInteresAnualidadVencida";
            txtInteresAnualidadVencida.Size = new Size(100, 26);
            txtInteresAnualidadVencida.TabIndex = 39;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Text", 11.249999F);
            label3.Location = new Point(249, 63);
            label3.Name = "label3";
            label3.Size = new Size(125, 21);
            label3.TabIndex = 38;
            label3.Text = "Tasa de interes :";
            // 
            // txtValorPresenteAnualidadVencida
            // 
            txtValorPresenteAnualidadVencida.Font = new Font("Sitka Text", 11.249999F);
            txtValorPresenteAnualidadVencida.Location = new Point(143, 63);
            txtValorPresenteAnualidadVencida.Name = "txtValorPresenteAnualidadVencida";
            txtValorPresenteAnualidadVencida.Size = new Size(100, 26);
            txtValorPresenteAnualidadVencida.TabIndex = 37;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 11.249999F);
            label2.Location = new Point(15, 61);
            label2.Name = "label2";
            label2.Size = new Size(0, 21);
            label2.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(232, 9);
            label1.Name = "label1";
            label1.Size = new Size(190, 30);
            label1.TabIndex = 35;
            label1.Text = "Ingrese los datos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(9, 63);
            label5.Name = "label5";
            label5.Size = new Size(128, 23);
            label5.TabIndex = 46;
            label5.Text = "Valor Presente :";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbno);
            groupBox1.Controls.Add(rdbSi);
            groupBox1.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(15, 108);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(157, 60);
            groupBox1.TabIndex = 49;
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
            // cmbPeriodoA
            // 
            cmbPeriodoA.FormattingEnabled = true;
            cmbPeriodoA.Items.AddRange(new object[] { "Años", "Meses", "Semestres", "Trimestres" });
            cmbPeriodoA.Location = new Point(562, 108);
            cmbPeriodoA.Name = "cmbPeriodoA";
            cmbPeriodoA.Size = new Size(100, 23);
            cmbPeriodoA.TabIndex = 51;
            // 
            // cmbInteresA
            // 
            cmbInteresA.FormattingEnabled = true;
            cmbInteresA.Items.AddRange(new object[] { "Anual", "Mensual", "Semestral", "Trimestral" });
            cmbInteresA.Location = new Point(377, 108);
            cmbInteresA.Name = "cmbInteresA";
            cmbInteresA.Size = new Size(100, 23);
            cmbInteresA.TabIndex = 50;
            // 
            // FrmAnuPreDife
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(677, 408);
            Controls.Add(cmbPeriodoA);
            Controls.Add(cmbInteresA);
            Controls.Add(groupBox1);
            Controls.Add(label5);
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
            Name = "FrmAnuPreDife";
            Text = "FrmAnuPreDife";
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
        private Label label5;
        private GroupBox groupBox1;
        private RadioButton rdbno;
        private RadioButton rdbSi;
        private ComboBox cmbPeriodoA;
        private ComboBox cmbInteresA;
    }
}