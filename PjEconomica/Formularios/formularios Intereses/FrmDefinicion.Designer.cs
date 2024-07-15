namespace PjEconomica.Formularios.formularios_Intereses
{
    partial class FrmDefinicion
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
            pictureBox1 = new PictureBox();
            label2 = new Label();
            button1 = new Button();
            groupBox1 = new GroupBox();
            button3 = new Button();
            dtgvResultadosAcumulados = new DataGridView();
            cmbPeriodoAcum = new ComboBox();
            cmbInteresAcum = new ComboBox();
            txtPeriodo = new TextBox();
            button2 = new Button();
            txtTasaInteres = new TextBox();
            txtValorPresente = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvResultadosAcumulados).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(276, 29);
            label1.Name = "label1";
            label1.Size = new Size(206, 30);
            label1.TabIndex = 0;
            label1.Text = "¿Qué es el interes?";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.interes;
            pictureBox1.Location = new Point(30, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(191, 139);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(248, 77);
            label2.Name = "label2";
            label2.Size = new Size(349, 115);
            label2.TabIndex = 2;
            label2.Text = "Es el costo que se paga por el uso del dinero \r\nprestado o el rendimiento que se obtiene por \r\ndepositar dinero en una cuenta de ahorros o \r\ninversión.\r\n\r\n";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Sitka Text", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(650, 523);
            button1.Name = "button1";
            button1.Size = new Size(167, 32);
            button1.TabIndex = 3;
            button1.Text = "Menú de intereses";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(dtgvResultadosAcumulados);
            groupBox1.Controls.Add(cmbPeriodoAcum);
            groupBox1.Controls.Add(cmbInteresAcum);
            groupBox1.Controls.Add(txtPeriodo);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(txtTasaInteres);
            groupBox1.Controls.Add(txtValorPresente);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 210);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(805, 298);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Interés";
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(174, 248);
            button3.Name = "button3";
            button3.Size = new Size(138, 34);
            button3.TabIndex = 12;
            button3.Text = "Limpiar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // dtgvResultadosAcumulados
            // 
            dtgvResultadosAcumulados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvResultadosAcumulados.Location = new Point(379, 94);
            dtgvResultadosAcumulados.Name = "dtgvResultadosAcumulados";
            dtgvResultadosAcumulados.Size = new Size(408, 188);
            dtgvResultadosAcumulados.TabIndex = 11;
            // 
            // cmbPeriodoAcum
            // 
            cmbPeriodoAcum.FormattingEnabled = true;
            cmbPeriodoAcum.Items.AddRange(new object[] { "Años", "Meses", "Semestres", "Trimestres" });
            cmbPeriodoAcum.Location = new Point(218, 186);
            cmbPeriodoAcum.Name = "cmbPeriodoAcum";
            cmbPeriodoAcum.Size = new Size(94, 36);
            cmbPeriodoAcum.TabIndex = 10;
            // 
            // cmbInteresAcum
            // 
            cmbInteresAcum.FormattingEnabled = true;
            cmbInteresAcum.Items.AddRange(new object[] { "Anual", "Mensual", "Semestral", "Trimestral" });
            cmbInteresAcum.Location = new Point(264, 139);
            cmbInteresAcum.Name = "cmbInteresAcum";
            cmbInteresAcum.Size = new Size(94, 36);
            cmbInteresAcum.TabIndex = 9;
            // 
            // txtPeriodo
            // 
            txtPeriodo.Location = new Point(101, 183);
            txtPeriodo.Name = "txtPeriodo";
            txtPeriodo.Size = new Size(100, 31);
            txtPeriodo.TabIndex = 8;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(18, 248);
            button2.Name = "button2";
            button2.Size = new Size(138, 34);
            button2.TabIndex = 7;
            button2.Text = "Calcular";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // txtTasaInteres
            // 
            txtTasaInteres.Location = new Point(152, 139);
            txtTasaInteres.Name = "txtTasaInteres";
            txtTasaInteres.Size = new Size(100, 31);
            txtTasaInteres.TabIndex = 6;
            // 
            // txtValorPresente
            // 
            txtValorPresente.Location = new Point(152, 94);
            txtValorPresente.Name = "txtValorPresente";
            txtValorPresente.Size = new Size(100, 31);
            txtValorPresente.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Text", 12F);
            label6.Location = new Point(18, 186);
            label6.Name = "label6";
            label6.Size = new Size(77, 23);
            label6.TabIndex = 3;
            label6.Text = "periodo :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Text", 12F);
            label5.Location = new Point(18, 139);
            label5.Name = "label5";
            label5.Size = new Size(138, 23);
            label5.TabIndex = 2;
            label5.Text = "Tasa de interes : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Text", 12F);
            label4.Location = new Point(18, 94);
            label4.Name = "label4";
            label4.Size = new Size(128, 23);
            label4.TabIndex = 1;
            label4.Text = "Valor presente :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 41);
            label3.Name = "label3";
            label3.Size = new Size(172, 28);
            label3.TabIndex = 0;
            label3.Text = "Ingrese los datos";
            // 
            // FrmDefinicion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(829, 567);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "FrmDefinicion";
            Text = "FrmDefinicion";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvResultadosAcumulados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Button button1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtTasaInteres;
        private TextBox txtValorPresente;
        private Button button2;
        private TextBox txtPeriodo;
        private DataGridView dtgvResultadosAcumulados;
        private ComboBox cmbPeriodoAcum;
        private ComboBox cmbInteresAcum;
        private Button button3;
    }
}