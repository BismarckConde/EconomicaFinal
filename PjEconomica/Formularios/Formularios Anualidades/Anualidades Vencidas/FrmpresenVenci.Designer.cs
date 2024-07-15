namespace PjEconomica.Formularios.Formularios_Anualidades.Anualidades_Vencidas
{
    partial class FrmpresenVenci
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
            dgvResultadosPresente = new DataGridView();
            txtPeriodoAnualidadPresente = new TextBox();
            label4 = new Label();
            txtTasaInteresAnualidadPresente = new TextBox();
            label3 = new Label();
            txtValorAnualidadPresente = new TextBox();
            label2 = new Label();
            label1 = new Label();
            cmbPeriodoAnualidadPresente = new ComboBox();
            cmbInteresAnualidadPresente = new ComboBox();
            groupBox1 = new GroupBox();
            rdbNoFuturo = new RadioButton();
            rdbSiFuturo = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dgvResultadosPresente).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLim
            // 
            btnLim.BackColor = Color.White;
            btnLim.Font = new Font("Sitka Text", 11.249999F);
            btnLim.Location = new Point(572, 354);
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
            btnCal.Location = new Point(440, 354);
            btnCal.Name = "btnCal";
            btnCal.Size = new Size(104, 32);
            btnCal.TabIndex = 19;
            btnCal.Text = "Calcular";
            btnCal.UseVisualStyleBackColor = false;
            btnCal.Click += btnCal_Click;
            // 
            // dgvResultadosPresente
            // 
            dgvResultadosPresente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultadosPresente.Location = new Point(34, 190);
            dgvResultadosPresente.Name = "dgvResultadosPresente";
            dgvResultadosPresente.Size = new Size(642, 150);
            dgvResultadosPresente.TabIndex = 18;
            // 
            // txtPeriodoAnualidadPresente
            // 
            txtPeriodoAnualidadPresente.Font = new Font("Sitka Text", 11.249999F);
            txtPeriodoAnualidadPresente.Location = new Point(576, 61);
            txtPeriodoAnualidadPresente.Name = "txtPeriodoAnualidadPresente";
            txtPeriodoAnualidadPresente.Size = new Size(100, 26);
            txtPeriodoAnualidadPresente.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Text", 11.249999F);
            label4.Location = new Point(497, 61);
            label4.Name = "label4";
            label4.Size = new Size(73, 21);
            label4.TabIndex = 16;
            label4.Text = "Periodo :";
            // 
            // txtTasaInteresAnualidadPresente
            // 
            txtTasaInteresAnualidadPresente.Font = new Font("Sitka Text", 11.249999F);
            txtTasaInteresAnualidadPresente.Location = new Point(379, 61);
            txtTasaInteresAnualidadPresente.Name = "txtTasaInteresAnualidadPresente";
            txtTasaInteresAnualidadPresente.Size = new Size(100, 26);
            txtTasaInteresAnualidadPresente.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Text", 11.249999F);
            label3.Location = new Point(251, 61);
            label3.Name = "label3";
            label3.Size = new Size(125, 21);
            label3.TabIndex = 14;
            label3.Text = "Tasa de interes :";
            // 
            // txtValorAnualidadPresente
            // 
            txtValorAnualidadPresente.Font = new Font("Sitka Text", 11.249999F);
            txtValorAnualidadPresente.Location = new Point(131, 61);
            txtValorAnualidadPresente.Name = "txtValorAnualidadPresente";
            txtValorAnualidadPresente.Size = new Size(100, 26);
            txtValorAnualidadPresente.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 11.249999F);
            label2.Location = new Point(34, 61);
            label2.Name = "label2";
            label2.Size = new Size(91, 21);
            label2.TabIndex = 12;
            label2.Text = "Anualidad :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(251, 9);
            label1.Name = "label1";
            label1.Size = new Size(190, 30);
            label1.TabIndex = 11;
            label1.Text = "Ingrese los datos";
            // 
            // cmbPeriodoAnualidadPresente
            // 
            cmbPeriodoAnualidadPresente.FormattingEnabled = true;
            cmbPeriodoAnualidadPresente.Items.AddRange(new object[] { "Años", "Meses", "Semestres", "Trimestres" });
            cmbPeriodoAnualidadPresente.Location = new Point(576, 101);
            cmbPeriodoAnualidadPresente.Name = "cmbPeriodoAnualidadPresente";
            cmbPeriodoAnualidadPresente.Size = new Size(100, 23);
            cmbPeriodoAnualidadPresente.TabIndex = 27;
            // 
            // cmbInteresAnualidadPresente
            // 
            cmbInteresAnualidadPresente.FormattingEnabled = true;
            cmbInteresAnualidadPresente.Items.AddRange(new object[] { "Anual", "Mensual", "Semestral", "Trimestral" });
            cmbInteresAnualidadPresente.Location = new Point(379, 101);
            cmbInteresAnualidadPresente.Name = "cmbInteresAnualidadPresente";
            cmbInteresAnualidadPresente.Size = new Size(100, 23);
            cmbInteresAnualidadPresente.TabIndex = 26;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbNoFuturo);
            groupBox1.Controls.Add(rdbSiFuturo);
            groupBox1.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(34, 110);
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
            // FrmpresenVenci
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 391);
            Controls.Add(cmbPeriodoAnualidadPresente);
            Controls.Add(cmbInteresAnualidadPresente);
            Controls.Add(groupBox1);
            Controls.Add(btnLim);
            Controls.Add(btnCal);
            Controls.Add(dgvResultadosPresente);
            Controls.Add(txtPeriodoAnualidadPresente);
            Controls.Add(label4);
            Controls.Add(txtTasaInteresAnualidadPresente);
            Controls.Add(label3);
            Controls.Add(txtValorAnualidadPresente);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmpresenVenci";
            Text = "FrmpresenVenci";
            ((System.ComponentModel.ISupportInitialize)dgvResultadosPresente).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnLim;
        private Button btnCal;
        private DataGridView dgvResultadosPresente;
        private TextBox txtPeriodoAnualidadPresente;
        private Label label4;
        private TextBox txtTasaInteresAnualidadPresente;
        private Label label3;
        private TextBox txtValorAnualidadPresente;
        private Label label2;
        private Label label1;
        private ComboBox cmbPeriodoAnualidadPresente;
        private ComboBox cmbInteresAnualidadPresente;
        private GroupBox groupBox1;
        private RadioButton rdbNoFuturo;
        private RadioButton rdbSiFuturo;
    }
}