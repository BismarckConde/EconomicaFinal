namespace PjEconomica.Formularios.formularios_Intereses
{
    partial class FrmPeriodo
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
            dgvResultadosN = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvResultadosN).BeginInit();
            SuspendLayout();
            // 
            // btnLim
            // 
            btnLim.Font = new Font("Sitka Text", 12F);
            btnLim.Location = new Point(204, 186);
            btnLim.Name = "btnLim";
            btnLim.Size = new Size(134, 35);
            btnLim.TabIndex = 29;
            btnLim.Text = "Limpiar";
            btnLim.UseVisualStyleBackColor = true;
            btnLim.Click += btnLim_Click;
            // 
            // btnCal
            // 
            btnCal.Font = new Font("Sitka Text", 12F);
            btnCal.Location = new Point(36, 186);
            btnCal.Name = "btnCal";
            btnCal.Size = new Size(134, 35);
            btnCal.TabIndex = 28;
            btnCal.Text = "Calcular";
            btnCal.UseVisualStyleBackColor = true;
            btnCal.Click += btnCal_Click;
            // 
            // txtValorPresenteN
            // 
            txtValorPresenteN.Location = new Point(170, 105);
            txtValorPresenteN.Name = "txtValorPresenteN";
            txtValorPresenteN.Size = new Size(100, 23);
            txtValorPresenteN.TabIndex = 27;
            // 
            // txtTasaInteresN
            // 
            txtTasaInteresN.Location = new Point(170, 139);
            txtTasaInteresN.Name = "txtTasaInteresN";
            txtTasaInteresN.Size = new Size(100, 23);
            txtTasaInteresN.TabIndex = 26;
            // 
            // txtValorFuturoN
            // 
            txtValorFuturoN.Location = new Point(170, 64);
            txtValorFuturoN.Name = "txtValorFuturoN";
            txtValorFuturoN.Size = new Size(100, 23);
            txtValorFuturoN.TabIndex = 25;
            txtValorFuturoN.TextChanged += txtVF_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Text", 12F);
            label4.Location = new Point(36, 105);
            label4.Name = "label4";
            label4.Size = new Size(117, 23);
            label4.TabIndex = 23;
            label4.Text = "Valor Presente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Text", 12F);
            label3.Location = new Point(36, 139);
            label3.Name = "label3";
            label3.Size = new Size(134, 23);
            label3.TabIndex = 22;
            label3.Text = "Tasa de Interes :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 12F);
            label2.Location = new Point(36, 67);
            label2.Name = "label2";
            label2.Size = new Size(116, 23);
            label2.TabIndex = 21;
            label2.Text = "Valor Futuro :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(296, 9);
            label1.Name = "label1";
            label1.Size = new Size(235, 70);
            label1.TabIndex = 20;
            label1.Text = "Calculo de periodo\r\n\r\n";
            // 
            // dgvResultadosN
            // 
            dgvResultadosN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultadosN.Location = new Point(360, 64);
            dgvResultadosN.Name = "dgvResultadosN";
            dgvResultadosN.Size = new Size(445, 132);
            dgvResultadosN.TabIndex = 30;
            // 
            // FrmPeriodo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 250);
            Controls.Add(dgvResultadosN);
            Controls.Add(btnLim);
            Controls.Add(btnCal);
            Controls.Add(txtValorPresenteN);
            Controls.Add(txtTasaInteresN);
            Controls.Add(txtValorFuturoN);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmPeriodo";
            Text = "FrmPeriodo";
            Load += FrmPeriodo_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResultadosN).EndInit();
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
        private DataGridView dgvResultadosN;
    }
}