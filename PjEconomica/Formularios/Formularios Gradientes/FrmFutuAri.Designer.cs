namespace PjEconomica.Formularios.Formularios_Gradientes
{
    partial class FrmFutuAri
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
            cmbPeriodoFG = new ComboBox();
            cmbInteresFG = new ComboBox();
            txtAnualidadFG = new TextBox();
            label3 = new Label();
            groupBox2 = new GroupBox();
            rdbDecreceFG = new RadioButton();
            rdbIncrementaFG = new RadioButton();
            btnLimpiar = new Button();
            btncalcular = new Button();
            dgvResultadosFG = new DataGridView();
            txtPeriodoFG = new TextBox();
            txtInteresFG = new TextBox();
            txtGradienteFG = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResultadosFG).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbPeriodoFG);
            groupBox1.Controls.Add(cmbInteresFG);
            groupBox1.Controls.Add(txtAnualidadFG);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Controls.Add(btncalcular);
            groupBox1.Controls.Add(dgvResultadosFG);
            groupBox1.Controls.Add(txtPeriodoFG);
            groupBox1.Controls.Add(txtInteresFG);
            groupBox1.Controls.Add(txtGradienteFG);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(18, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(693, 436);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingrese los datos";
            // 
            // cmbPeriodoFG
            // 
            cmbPeriodoFG.FormattingEnabled = true;
            cmbPeriodoFG.Items.AddRange(new object[] { "Años", "Meses", "Semestres", "Trimestres" });
            cmbPeriodoFG.Location = new Point(558, 77);
            cmbPeriodoFG.Name = "cmbPeriodoFG";
            cmbPeriodoFG.Size = new Size(100, 31);
            cmbPeriodoFG.TabIndex = 20;
            // 
            // cmbInteresFG
            // 
            cmbInteresFG.FormattingEnabled = true;
            cmbInteresFG.Items.AddRange(new object[] { "Anual", "Mensual", "Semestral", "Trimestral" });
            cmbInteresFG.Location = new Point(360, 80);
            cmbInteresFG.Name = "cmbInteresFG";
            cmbInteresFG.Size = new Size(100, 31);
            cmbInteresFG.TabIndex = 19;
            // 
            // txtAnualidadFG
            // 
            txtAnualidadFG.Location = new Point(114, 77);
            txtAnualidadFG.Name = "txtAnualidadFG";
            txtAnualidadFG.Size = new Size(100, 28);
            txtAnualidadFG.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 80);
            label3.Name = "label3";
            label3.Size = new Size(97, 23);
            label3.TabIndex = 17;
            label3.Text = "Anualidad :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rdbDecreceFG);
            groupBox2.Controls.Add(rdbIncrementaFG);
            groupBox2.Location = new Point(23, 122);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(234, 64);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Opción";
            // 
            // rdbDecreceFG
            // 
            rdbDecreceFG.AutoSize = true;
            rdbDecreceFG.Location = new Point(126, 27);
            rdbDecreceFG.Name = "rdbDecreceFG";
            rdbDecreceFG.Size = new Size(86, 27);
            rdbDecreceFG.TabIndex = 18;
            rdbDecreceFG.TabStop = true;
            rdbDecreceFG.Text = "Decrece";
            rdbDecreceFG.UseVisualStyleBackColor = true;
            // 
            // rdbIncrementaFG
            // 
            rdbIncrementaFG.AutoSize = true;
            rdbIncrementaFG.Location = new Point(6, 27);
            rdbIncrementaFG.Name = "rdbIncrementaFG";
            rdbIncrementaFG.Size = new Size(114, 27);
            rdbIncrementaFG.TabIndex = 17;
            rdbIncrementaFG.TabStop = true;
            rdbIncrementaFG.Text = "Incrementa";
            rdbIncrementaFG.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.White;
            btnLimpiar.Location = new Point(555, 384);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(112, 37);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btncalcular
            // 
            btncalcular.BackColor = SystemColors.ControlLightLight;
            btncalcular.Location = new Point(411, 384);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(112, 37);
            btncalcular.TabIndex = 12;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = false;
            btncalcular.Click += btncalcular_Click;
            // 
            // dgvResultadosFG
            // 
            dgvResultadosFG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultadosFG.Location = new Point(23, 203);
            dgvResultadosFG.Name = "dgvResultadosFG";
            dgvResultadosFG.Size = new Size(641, 150);
            dgvResultadosFG.TabIndex = 2;
            // 
            // txtPeriodoFG
            // 
            txtPeriodoFG.Location = new Point(558, 33);
            txtPeriodoFG.Name = "txtPeriodoFG";
            txtPeriodoFG.Size = new Size(100, 28);
            txtPeriodoFG.TabIndex = 7;
            // 
            // txtInteresFG
            // 
            txtInteresFG.Location = new Point(360, 36);
            txtInteresFG.Name = "txtInteresFG";
            txtInteresFG.Size = new Size(100, 28);
            txtInteresFG.TabIndex = 6;
            // 
            // txtGradienteFG
            // 
            txtGradienteFG.Location = new Point(114, 36);
            txtGradienteFG.Name = "txtGradienteFG";
            txtGradienteFG.Size = new Size(100, 28);
            txtGradienteFG.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(475, 36);
            label5.Name = "label5";
            label5.Size = new Size(77, 23);
            label5.TabIndex = 3;
            label5.Text = "Periodo :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(220, 39);
            label4.Name = "label4";
            label4.Size = new Size(134, 23);
            label4.TabIndex = 2;
            label4.Text = "Tasa de Interes :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 39);
            label2.Name = "label2";
            label2.Size = new Size(94, 23);
            label2.TabIndex = 0;
            label2.Text = "Gradiente :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(166, 9);
            label1.Name = "label1";
            label1.Size = new Size(375, 28);
            label1.TabIndex = 7;
            label1.Text = "Calculo de gradiente aritmetico Futuro\r\n";
            // 
            // FrmFutuAri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 490);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "FrmFutuAri";
            Text = "FrmFutuAri";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResultadosFG).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cmbPeriodoFG;
        private ComboBox cmbInteresFG;
        private TextBox txtAnualidadFG;
        private Label label3;
        private GroupBox groupBox2;
        private RadioButton rdbDecreceFG;
        private RadioButton rdbIncrementaFG;
        private Button btnLimpiar;
        private Button btncalcular;
        private DataGridView dgvResultadosFG;
        private TextBox txtPeriodoFG;
        private TextBox txtInteresFG;
        private TextBox txtGradienteFG;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
    }
}