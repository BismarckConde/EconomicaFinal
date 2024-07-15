namespace PjEconomica.Formularios.formularios_Intereses
{
    partial class FrmPeriodoCompuesto
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
            txtValorPresenteN = new TextBox();
            txtTasaInteresN = new TextBox();
            txtValorFuturoN = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cmbInteresN = new ComboBox();
            dgvIntCompP = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvIntCompP).BeginInit();
            SuspendLayout();
            // 
            // btnLim
            // 
            btnLim.Font = new Font("Sitka Text", 12F);
            btnLim.Location = new Point(198, 190);
            btnLim.Name = "btnLim";
            btnLim.Size = new Size(134, 35);
            btnLim.TabIndex = 39;
            btnLim.Text = "Limpiar";
            btnLim.UseVisualStyleBackColor = true;
            btnLim.Click += btnLim_Click;
            // 
            // btnCal
            // 
            btnCal.Font = new Font("Sitka Text", 12F);
            btnCal.Location = new Point(30, 190);
            btnCal.Name = "btnCal";
            btnCal.Size = new Size(134, 35);
            btnCal.TabIndex = 38;
            btnCal.Text = "Calcular";
            btnCal.UseVisualStyleBackColor = true;
            btnCal.Click += btnCal_Click_1;
            // 
            // txtValorPresenteN
            // 
            txtValorPresenteN.Location = new Point(164, 109);
            txtValorPresenteN.Name = "txtValorPresenteN";
            txtValorPresenteN.Size = new Size(100, 23);
            txtValorPresenteN.TabIndex = 37;
            // 
            // txtTasaInteresN
            // 
            txtTasaInteresN.Location = new Point(164, 143);
            txtTasaInteresN.Name = "txtTasaInteresN";
            txtTasaInteresN.Size = new Size(100, 23);
            txtTasaInteresN.TabIndex = 36;
            // 
            // txtValorFuturoN
            // 
            txtValorFuturoN.Location = new Point(164, 68);
            txtValorFuturoN.Name = "txtValorFuturoN";
            txtValorFuturoN.Size = new Size(100, 23);
            txtValorFuturoN.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Text", 12F);
            label4.Location = new Point(30, 109);
            label4.Name = "label4";
            label4.Size = new Size(117, 23);
            label4.TabIndex = 33;
            label4.Text = "Valor Presente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Text", 12F);
            label3.Location = new Point(30, 143);
            label3.Name = "label3";
            label3.Size = new Size(134, 23);
            label3.TabIndex = 32;
            label3.Text = "Tasa de Interes :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 12F);
            label2.Location = new Point(30, 71);
            label2.Name = "label2";
            label2.Size = new Size(116, 23);
            label2.TabIndex = 31;
            label2.Text = "Valor Futuro :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(255, 13);
            label1.Name = "label1";
            label1.Size = new Size(235, 70);
            label1.TabIndex = 30;
            label1.Text = "Calculo de periodo\r\n\r\n";
            // 
            // cmbInteresN
            // 
            cmbInteresN.FormattingEnabled = true;
            cmbInteresN.Items.AddRange(new object[] { "Mensual", "Semestral", "Trimestral", "Anual" });
            cmbInteresN.Location = new Point(270, 143);
            cmbInteresN.Name = "cmbInteresN";
            cmbInteresN.Size = new Size(100, 23);
            cmbInteresN.TabIndex = 40;
            // 
            // dgvIntCompP
            // 
            dgvIntCompP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIntCompP.Location = new Point(385, 68);
            dgvIntCompP.Name = "dgvIntCompP";
            dgvIntCompP.Size = new Size(428, 150);
            dgvIntCompP.TabIndex = 41;
            // 
            // FrmPeriodoCompuesto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 239);
            Controls.Add(dgvIntCompP);
            Controls.Add(cmbInteresN);
            Controls.Add(btnLim);
            Controls.Add(btnCal);
            Controls.Add(txtValorPresenteN);
            Controls.Add(txtTasaInteresN);
            Controls.Add(txtValorFuturoN);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmPeriodoCompuesto";
            Text = "FrmPeriodoCompuesto";
            ((System.ComponentModel.ISupportInitialize)dgvIntCompP).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLim;
        private Button btnCal;
        private TextBox txtValorPresenteN;
        private TextBox txtTasaInteresN;
        private TextBox txtValorFuturoN;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cmbInteresN;
        private DataGridView dgvIntCompP;
    }
}