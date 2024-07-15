namespace PjEconomica.Formularios.formularios_Intereses
{
    partial class FrmFuturo
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
            label3 = new Label();
            label4 = new Label();
            txtValorPresenteF = new TextBox();
            txtTasaInteresF = new TextBox();
            txtPeriodoF = new TextBox();
            btnCal = new Button();
            btnLim = new Button();
            dgvResultadosF = new DataGridView();
            cmbInteresSimple = new ComboBox();
            cmbPeriodoSimple = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvResultadosF).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(315, 9);
            label1.Name = "label1";
            label1.Size = new Size(310, 35);
            label1.TabIndex = 0;
            label1.Text = "Calculo de interes futuro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 12F);
            label2.Location = new Point(28, 79);
            label2.Name = "label2";
            label2.Size = new Size(128, 23);
            label2.TabIndex = 1;
            label2.Text = "Valor Presente :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Text", 12F);
            label3.Location = new Point(28, 119);
            label3.Name = "label3";
            label3.Size = new Size(134, 23);
            label3.TabIndex = 2;
            label3.Text = "Tasa de Interes :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Text", 12F);
            label4.Location = new Point(28, 155);
            label4.Name = "label4";
            label4.Size = new Size(77, 23);
            label4.TabIndex = 3;
            label4.Text = "Periodo :";
            // 
            // txtValorPresenteF
            // 
            txtValorPresenteF.Location = new Point(162, 76);
            txtValorPresenteF.Name = "txtValorPresenteF";
            txtValorPresenteF.Size = new Size(100, 23);
            txtValorPresenteF.TabIndex = 5;
            // 
            // txtTasaInteresF
            // 
            txtTasaInteresF.Location = new Point(162, 119);
            txtTasaInteresF.Name = "txtTasaInteresF";
            txtTasaInteresF.Size = new Size(100, 23);
            txtTasaInteresF.TabIndex = 6;
            // 
            // txtPeriodoF
            // 
            txtPeriodoF.Location = new Point(162, 155);
            txtPeriodoF.Name = "txtPeriodoF";
            txtPeriodoF.Size = new Size(100, 23);
            txtPeriodoF.TabIndex = 7;
            // 
            // btnCal
            // 
            btnCal.Font = new Font("Sitka Text", 12F);
            btnCal.Location = new Point(28, 201);
            btnCal.Name = "btnCal";
            btnCal.Size = new Size(134, 35);
            btnCal.TabIndex = 8;
            btnCal.Text = "Calcular";
            btnCal.UseVisualStyleBackColor = true;
            btnCal.Click += btnCal_Click;
            // 
            // btnLim
            // 
            btnLim.Font = new Font("Sitka Text", 12F);
            btnLim.Location = new Point(196, 201);
            btnLim.Name = "btnLim";
            btnLim.Size = new Size(134, 35);
            btnLim.TabIndex = 9;
            btnLim.Text = "Limpiar";
            btnLim.UseVisualStyleBackColor = true;
            btnLim.Click += btnLim_Click;
            // 
            // dgvResultadosF
            // 
            dgvResultadosF.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultadosF.Location = new Point(379, 76);
            dgvResultadosF.Name = "dgvResultadosF";
            dgvResultadosF.Size = new Size(501, 160);
            dgvResultadosF.TabIndex = 10;
            dgvResultadosF.CellContentClick += dgvResultadosF_CellContentClick;
            // 
            // cmbInteresSimple
            // 
            cmbInteresSimple.FormattingEnabled = true;
            cmbInteresSimple.Items.AddRange(new object[] { "Anual", "Mensual", "Semestral", "Trimestral" });
            cmbInteresSimple.Location = new Point(285, 119);
            cmbInteresSimple.Name = "cmbInteresSimple";
            cmbInteresSimple.Size = new Size(88, 23);
            cmbInteresSimple.TabIndex = 11;
            // 
            // cmbPeriodoSimple
            // 
            cmbPeriodoSimple.FormattingEnabled = true;
            cmbPeriodoSimple.Items.AddRange(new object[] { "Años", "Meses", "Semestres", "Trimestres" });
            cmbPeriodoSimple.Location = new Point(285, 158);
            cmbPeriodoSimple.Name = "cmbPeriodoSimple";
            cmbPeriodoSimple.Size = new Size(88, 23);
            cmbPeriodoSimple.TabIndex = 12;
            // 
            // FrmFuturo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 266);
            Controls.Add(cmbPeriodoSimple);
            Controls.Add(cmbInteresSimple);
            Controls.Add(dgvResultadosF);
            Controls.Add(btnLim);
            Controls.Add(btnCal);
            Controls.Add(txtPeriodoF);
            Controls.Add(txtTasaInteresF);
            Controls.Add(txtValorPresenteF);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmFuturo";
            Text = "FrmFuturo";
            ((System.ComponentModel.ISupportInitialize)dgvResultadosF).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtValorPresenteF;
        private TextBox txtTasaInteresF;
        private TextBox txtPeriodoF;
        private Button btnCal;
        private Button btnLim;
        private DataGridView dgvResultadosF;
        private ComboBox cmbInteresSimple;
        private ComboBox cmbPeriodoSimple;
    }
}