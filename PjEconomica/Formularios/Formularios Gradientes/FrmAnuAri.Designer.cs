namespace PjEconomica.Formularios.Formularios_Gradientes
{
    partial class FrmAnuAri
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
            cmbPeriodoGA = new ComboBox();
            cmbInteresGA = new ComboBox();
            txtAnualidadGA = new TextBox();
            label3 = new Label();
            groupBox2 = new GroupBox();
            rdbPresenteDecrece = new RadioButton();
            rdbPresenteIncrementa = new RadioButton();
            btnLimpiar = new Button();
            btncalcular = new Button();
            dgvResultadosGA = new DataGridView();
            txtPeriodoGA = new TextBox();
            txtInteresGA = new TextBox();
            txtGradienteGA = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResultadosGA).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbPeriodoGA);
            groupBox1.Controls.Add(cmbInteresGA);
            groupBox1.Controls.Add(txtAnualidadGA);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Controls.Add(btncalcular);
            groupBox1.Controls.Add(dgvResultadosGA);
            groupBox1.Controls.Add(txtPeriodoGA);
            groupBox1.Controls.Add(txtInteresGA);
            groupBox1.Controls.Add(txtGradienteGA);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(23, 40);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(693, 436);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingrese los datos";
            // 
            // cmbPeriodoGA
            // 
            cmbPeriodoGA.FormattingEnabled = true;
            cmbPeriodoGA.Items.AddRange(new object[] { "Años", "Meses", "Semestres", "Trimestres" });
            cmbPeriodoGA.Location = new Point(558, 77);
            cmbPeriodoGA.Name = "cmbPeriodoGA";
            cmbPeriodoGA.Size = new Size(100, 31);
            cmbPeriodoGA.TabIndex = 20;
            // 
            // cmbInteresGA
            // 
            cmbInteresGA.FormattingEnabled = true;
            cmbInteresGA.Items.AddRange(new object[] { "Anual", "Mensual", "Semestral", "Trimestral" });
            cmbInteresGA.Location = new Point(360, 80);
            cmbInteresGA.Name = "cmbInteresGA";
            cmbInteresGA.Size = new Size(100, 31);
            cmbInteresGA.TabIndex = 19;
            // 
            // txtAnualidadGA
            // 
            txtAnualidadGA.Location = new Point(114, 77);
            txtAnualidadGA.Name = "txtAnualidadGA";
            txtAnualidadGA.Size = new Size(100, 28);
            txtAnualidadGA.TabIndex = 18;
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
            groupBox2.Controls.Add(rdbPresenteDecrece);
            groupBox2.Controls.Add(rdbPresenteIncrementa);
            groupBox2.Location = new Point(23, 122);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(234, 64);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Opción";
            // 
            // rdbPresenteDecrece
            // 
            rdbPresenteDecrece.AutoSize = true;
            rdbPresenteDecrece.Location = new Point(126, 27);
            rdbPresenteDecrece.Name = "rdbPresenteDecrece";
            rdbPresenteDecrece.Size = new Size(86, 27);
            rdbPresenteDecrece.TabIndex = 18;
            rdbPresenteDecrece.TabStop = true;
            rdbPresenteDecrece.Text = "Decrece";
            rdbPresenteDecrece.UseVisualStyleBackColor = true;
            // 
            // rdbPresenteIncrementa
            // 
            rdbPresenteIncrementa.AutoSize = true;
            rdbPresenteIncrementa.Location = new Point(6, 27);
            rdbPresenteIncrementa.Name = "rdbPresenteIncrementa";
            rdbPresenteIncrementa.Size = new Size(114, 27);
            rdbPresenteIncrementa.TabIndex = 17;
            rdbPresenteIncrementa.TabStop = true;
            rdbPresenteIncrementa.Text = "Incrementa";
            rdbPresenteIncrementa.UseVisualStyleBackColor = true;
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
            // dgvResultadosGA
            // 
            dgvResultadosGA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultadosGA.Location = new Point(23, 203);
            dgvResultadosGA.Name = "dgvResultadosGA";
            dgvResultadosGA.Size = new Size(641, 150);
            dgvResultadosGA.TabIndex = 2;
            // 
            // txtPeriodoGA
            // 
            txtPeriodoGA.Location = new Point(558, 33);
            txtPeriodoGA.Name = "txtPeriodoGA";
            txtPeriodoGA.Size = new Size(100, 28);
            txtPeriodoGA.TabIndex = 7;
            // 
            // txtInteresGA
            // 
            txtInteresGA.Location = new Point(360, 36);
            txtInteresGA.Name = "txtInteresGA";
            txtInteresGA.Size = new Size(100, 28);
            txtInteresGA.TabIndex = 6;
            // 
            // txtGradienteGA
            // 
            txtGradienteGA.Location = new Point(114, 36);
            txtGradienteGA.Name = "txtGradienteGA";
            txtGradienteGA.Size = new Size(100, 28);
            txtGradienteGA.TabIndex = 4;
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
            label1.Location = new Point(171, 9);
            label1.Name = "label1";
            label1.Size = new Size(408, 28);
            label1.TabIndex = 9;
            label1.Text = "Calculo de gradiente aritmetico Anualidad\r\n";
            // 
            // FrmAnuAri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 493);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "FrmAnuAri";
            Text = "FrmAnuAri";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResultadosGA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cmbPeriodoGA;
        private ComboBox cmbInteresGA;
        private TextBox txtAnualidadGA;
        private Label label3;
        private GroupBox groupBox2;
        private RadioButton rdbPresenteDecrece;
        private RadioButton rdbPresenteIncrementa;
        private Button btnLimpiar;
        private Button btncalcular;
        private DataGridView dgvResultadosGA;
        private TextBox txtPeriodoGA;
        private TextBox txtInteresGA;
        private TextBox txtGradienteGA;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
    }
}