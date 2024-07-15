namespace PjEconomica.Formularios.Formularios_Anualidades.Anualidades_Diferidas
{
    partial class FrmPreDife
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
            txtp1 = new TextBox();
            label4 = new Label();
            txttasa = new TextBox();
            label3 = new Label();
            txtValorAnualidadPresente = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtp2 = new TextBox();
            label5 = new Label();
            cmbInteresPresente = new ComboBox();
            cmbPeriodoPresente = new ComboBox();
            cmbPeriodoPresente2 = new ComboBox();
            groupBox1 = new GroupBox();
            rdbno = new RadioButton();
            rdbSi = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnLim
            // 
            btnLim.BackColor = Color.White;
            btnLim.Font = new Font("Sitka Text", 11.249999F);
            btnLim.Location = new Point(698, 237);
            btnLim.Name = "btnLim";
            btnLim.Size = new Size(174, 32);
            btnLim.TabIndex = 31;
            btnLim.Text = "Limpiar";
            btnLim.UseVisualStyleBackColor = false;
            btnLim.Click += btnLim_Click;
            // 
            // btnCal
            // 
            btnCal.BackColor = Color.White;
            btnCal.Font = new Font("Sitka Text", 11.249999F);
            btnCal.Location = new Point(698, 178);
            btnCal.Name = "btnCal";
            btnCal.Size = new Size(174, 32);
            btnCal.TabIndex = 30;
            btnCal.Text = "Calcular";
            btnCal.UseVisualStyleBackColor = false;
            btnCal.Click += btnCal_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(33, 178);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(642, 150);
            dataGridView1.TabIndex = 29;
            // 
            // txtp1
            // 
            txtp1.Font = new Font("Sitka Text", 11.249999F);
            txtp1.Location = new Point(575, 61);
            txtp1.Name = "txtp1";
            txtp1.Size = new Size(100, 26);
            txtp1.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Text", 11.249999F);
            label4.Location = new Point(496, 61);
            label4.Name = "label4";
            label4.Size = new Size(84, 21);
            label4.TabIndex = 27;
            label4.Text = "Periodo 1 :";
            // 
            // txttasa
            // 
            txttasa.Font = new Font("Sitka Text", 11.249999F);
            txttasa.Location = new Point(378, 61);
            txttasa.Name = "txttasa";
            txttasa.Size = new Size(100, 26);
            txttasa.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Text", 11.249999F);
            label3.Location = new Point(250, 61);
            label3.Name = "label3";
            label3.Size = new Size(125, 21);
            label3.TabIndex = 25;
            label3.Text = "Tasa de interes :";
            // 
            // txtValorAnualidadPresente
            // 
            txtValorAnualidadPresente.Font = new Font("Sitka Text", 11.249999F);
            txtValorAnualidadPresente.Location = new Point(130, 61);
            txtValorAnualidadPresente.Name = "txtValorAnualidadPresente";
            txtValorAnualidadPresente.Size = new Size(100, 26);
            txtValorAnualidadPresente.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 11.249999F);
            label2.Location = new Point(33, 61);
            label2.Name = "label2";
            label2.Size = new Size(91, 21);
            label2.TabIndex = 23;
            label2.Text = "Anualidad :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(367, 9);
            label1.Name = "label1";
            label1.Size = new Size(190, 30);
            label1.TabIndex = 22;
            label1.Text = "Ingrese los datos";
            // 
            // txtp2
            // 
            txtp2.Font = new Font("Sitka Text", 11.249999F);
            txtp2.Location = new Point(772, 64);
            txtp2.Name = "txtp2";
            txtp2.Size = new Size(100, 26);
            txtp2.TabIndex = 34;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Text", 11.249999F);
            label5.Location = new Point(681, 64);
            label5.Name = "label5";
            label5.Size = new Size(86, 21);
            label5.TabIndex = 33;
            label5.Text = "Periodo 2 :";
            // 
            // cmbInteresPresente
            // 
            cmbInteresPresente.FormattingEnabled = true;
            cmbInteresPresente.Items.AddRange(new object[] { "Anual", "Mensual", "Semestral", "Trimestral" });
            cmbInteresPresente.Location = new Point(378, 102);
            cmbInteresPresente.Name = "cmbInteresPresente";
            cmbInteresPresente.Size = new Size(100, 23);
            cmbInteresPresente.TabIndex = 35;
            // 
            // cmbPeriodoPresente
            // 
            cmbPeriodoPresente.FormattingEnabled = true;
            cmbPeriodoPresente.Items.AddRange(new object[] { "Años", "Meses", "Semestres", "Trimestres" });
            cmbPeriodoPresente.Location = new Point(575, 102);
            cmbPeriodoPresente.Name = "cmbPeriodoPresente";
            cmbPeriodoPresente.Size = new Size(100, 23);
            cmbPeriodoPresente.TabIndex = 36;
            // 
            // cmbPeriodoPresente2
            // 
            cmbPeriodoPresente2.FormattingEnabled = true;
            cmbPeriodoPresente2.Items.AddRange(new object[] { "Años", "Meses", "Semestres", "Trimestres" });
            cmbPeriodoPresente2.Location = new Point(772, 102);
            cmbPeriodoPresente2.Name = "cmbPeriodoPresente2";
            cmbPeriodoPresente2.Size = new Size(100, 23);
            cmbPeriodoPresente2.TabIndex = 37;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbno);
            groupBox1.Controls.Add(rdbSi);
            groupBox1.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(33, 102);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(157, 60);
            groupBox1.TabIndex = 38;
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
            // FrmPreDife
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 354);
            Controls.Add(groupBox1);
            Controls.Add(cmbPeriodoPresente2);
            Controls.Add(cmbPeriodoPresente);
            Controls.Add(cmbInteresPresente);
            Controls.Add(txtp2);
            Controls.Add(label5);
            Controls.Add(btnLim);
            Controls.Add(btnCal);
            Controls.Add(dataGridView1);
            Controls.Add(txtp1);
            Controls.Add(label4);
            Controls.Add(txttasa);
            Controls.Add(label3);
            Controls.Add(txtValorAnualidadPresente);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmPreDife";
            Text = "FrmPreDife";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chCapi;
        private Button btnLim;
        private Button btnCal;
        private DataGridView dataGridView1;
        private TextBox txtp1;
        private Label label4;
        private TextBox txttasa;
        private Label label3;
        private TextBox txtValorAnualidadPresente;
        private Label label2;
        private Label label1;
        private TextBox txtp2;
        private Label label5;
        private ComboBox cmbInteresPresente;
        private ComboBox cmbPeriodoPresente;
        private ComboBox cmbPeriodoPresente2;
        private GroupBox groupBox1;
        private RadioButton rdbno;
        private RadioButton rdbSi;
    }
}