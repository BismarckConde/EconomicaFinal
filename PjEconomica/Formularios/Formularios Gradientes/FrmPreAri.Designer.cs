namespace PjEconomica.Formularios.Formularios_Gradientes
{
    partial class FrmPreAri
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
            txtAnualidadPG = new TextBox();
            label3 = new Label();
            groupBox2 = new GroupBox();
            rdbDecrecePG = new RadioButton();
            rdbIncrementaPG = new RadioButton();
            btnLimpiar = new Button();
            btncalcular = new Button();
            dgvResultadosPG = new DataGridView();
            txtPeriodoPG = new TextBox();
            txtInteresPG = new TextBox();
            txtGradientePG = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            cmbInteresPG = new ComboBox();
            cmbPeriodoPG = new ComboBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResultadosPG).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbPeriodoPG);
            groupBox1.Controls.Add(cmbInteresPG);
            groupBox1.Controls.Add(txtAnualidadPG);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Controls.Add(btncalcular);
            groupBox1.Controls.Add(dgvResultadosPG);
            groupBox1.Controls.Add(txtPeriodoPG);
            groupBox1.Controls.Add(txtInteresPG);
            groupBox1.Controls.Add(txtGradientePG);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(17, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(693, 436);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingrese los datos";
            // 
            // txtAnualidadPG
            // 
            txtAnualidadPG.Location = new Point(114, 77);
            txtAnualidadPG.Name = "txtAnualidadPG";
            txtAnualidadPG.Size = new Size(100, 28);
            txtAnualidadPG.TabIndex = 18;
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
            groupBox2.Controls.Add(rdbDecrecePG);
            groupBox2.Controls.Add(rdbIncrementaPG);
            groupBox2.Location = new Point(23, 122);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(234, 64);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Opción";
            // 
            // rdbDecrecePG
            // 
            rdbDecrecePG.AutoSize = true;
            rdbDecrecePG.Location = new Point(126, 27);
            rdbDecrecePG.Name = "rdbDecrecePG";
            rdbDecrecePG.Size = new Size(86, 27);
            rdbDecrecePG.TabIndex = 18;
            rdbDecrecePG.TabStop = true;
            rdbDecrecePG.Text = "Decrece";
            rdbDecrecePG.UseVisualStyleBackColor = true;
            // 
            // rdbIncrementaPG
            // 
            rdbIncrementaPG.AutoSize = true;
            rdbIncrementaPG.Location = new Point(6, 27);
            rdbIncrementaPG.Name = "rdbIncrementaPG";
            rdbIncrementaPG.Size = new Size(114, 27);
            rdbIncrementaPG.TabIndex = 17;
            rdbIncrementaPG.TabStop = true;
            rdbIncrementaPG.Text = "Incrementa";
            rdbIncrementaPG.UseVisualStyleBackColor = true;
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
            // dgvResultadosPG
            // 
            dgvResultadosPG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultadosPG.Location = new Point(23, 203);
            dgvResultadosPG.Name = "dgvResultadosPG";
            dgvResultadosPG.Size = new Size(641, 150);
            dgvResultadosPG.TabIndex = 2;
            // 
            // txtPeriodoPG
            // 
            txtPeriodoPG.Location = new Point(558, 33);
            txtPeriodoPG.Name = "txtPeriodoPG";
            txtPeriodoPG.Size = new Size(100, 28);
            txtPeriodoPG.TabIndex = 7;
            // 
            // txtInteresPG
            // 
            txtInteresPG.Location = new Point(360, 36);
            txtInteresPG.Name = "txtInteresPG";
            txtInteresPG.Size = new Size(100, 28);
            txtInteresPG.TabIndex = 6;
            // 
            // txtGradientePG
            // 
            txtGradientePG.Location = new Point(114, 36);
            txtGradientePG.Name = "txtGradientePG";
            txtGradientePG.Size = new Size(100, 28);
            txtGradientePG.TabIndex = 4;
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
            label1.Location = new Point(165, 9);
            label1.Name = "label1";
            label1.Size = new Size(392, 28);
            label1.TabIndex = 5;
            label1.Text = "Calculo de gradiente aritmetico Presente\r\n";
            // 
            // cmbInteresPG
            // 
            cmbInteresPG.FormattingEnabled = true;
            cmbInteresPG.Items.AddRange(new object[] { "Anual", "Mensual", "Semestral", "Trimestral" });
            cmbInteresPG.Location = new Point(360, 80);
            cmbInteresPG.Name = "cmbInteresPG";
            cmbInteresPG.Size = new Size(100, 31);
            cmbInteresPG.TabIndex = 19;
            // 
            // cmbPeriodoPG
            // 
            cmbPeriodoPG.FormattingEnabled = true;
            cmbPeriodoPG.Items.AddRange(new object[] { "Años", "Meses", "Semestres", "Trimestres" });
            cmbPeriodoPG.Location = new Point(558, 77);
            cmbPeriodoPG.Name = "cmbPeriodoPG";
            cmbPeriodoPG.Size = new Size(100, 31);
            cmbPeriodoPG.TabIndex = 20;
            // 
            // FrmPreAri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 495);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "FrmPreAri";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResultadosPG).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtAnualidadPG;
        private Label label3;
        private GroupBox groupBox2;
        private RadioButton rdbDecrecePG;
        private RadioButton rdbIncrementaPG;
        private Button btnLimpiar;
        private Button btncalcular;
        private DataGridView dgvResultadosPG;
        private TextBox txtPeriodoPG;
        private TextBox txtInteresPG;
        private TextBox txtGradientePG;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private ComboBox cmbPeriodoPG;
        private ComboBox cmbInteresPG;
    }
}