namespace PjEconomica.Formularios.Formularios_Indicadores
{
    partial class FrmVPN
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
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            txtFne = new TextBox();
            label7 = new Label();
            cboPeri = new ComboBox();
            txtnomi = new TextBox();
            label6 = new Label();
            cboNomi = new ComboBox();
            dataGridView1 = new DataGridView();
            btnLimpiar = new Button();
            btnCalcular = new Button();
            txtAños = new TextBox();
            txtTasaDescuento = new TextBox();
            txtInverIni = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(202, 22);
            label1.Name = "label1";
            label1.Size = new Size(387, 35);
            label1.TabIndex = 0;
            label1.Text = "¿Qué es el Valor Presente Neto?\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(218, 67);
            label2.Name = "label2";
            label2.Size = new Size(362, 92);
            label2.TabIndex = 1;
            label2.Text = "El método de valor presente neto (VPN),\r\nes una de los criterios económicos más usados,\r\nel cual significa traer el futuro al presente\r\ncantidades monetarias su valor equialente.";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.VAN;
            pictureBox1.Location = new Point(12, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 123);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtFne);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(cboPeri);
            groupBox1.Controls.Add(txtnomi);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(cboNomi);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Controls.Add(btnCalcular);
            groupBox1.Controls.Add(txtAños);
            groupBox1.Controls.Add(txtTasaDescuento);
            groupBox1.Controls.Add(txtInverIni);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 221);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(832, 439);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingrese loa datos";
            // 
            // txtFne
            // 
            txtFne.Location = new Point(484, 113);
            txtFne.Name = "txtFne";
            txtFne.Size = new Size(100, 31);
            txtFne.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(413, 113);
            label7.Name = "label7";
            label7.Size = new Size(62, 28);
            label7.TabIndex = 14;
            label7.Text = "FNE :";
            // 
            // cboPeri
            // 
            cboPeri.FormattingEnabled = true;
            cboPeri.Location = new Point(724, 105);
            cboPeri.Name = "cboPeri";
            cboPeri.Size = new Size(100, 36);
            cboPeri.TabIndex = 13;
            // 
            // txtnomi
            // 
            txtnomi.Location = new Point(173, 113);
            txtnomi.Name = "txtnomi";
            txtnomi.Size = new Size(100, 31);
            txtnomi.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 113);
            label6.Name = "label6";
            label6.Size = new Size(146, 28);
            label6.TabIndex = 11;
            label6.Text = "Tasa Nominal :";
            // 
            // cboNomi
            // 
            cboNomi.FormattingEnabled = true;
            cboNomi.Location = new Point(293, 110);
            cboNomi.Name = "cboNomi";
            cboNomi.Size = new Size(100, 36);
            cboNomi.TabIndex = 10;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView1.Location = new Point(21, 205);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(803, 150);
            dataGridView1.TabIndex = 9;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.White;
            btnLimpiar.Location = new Point(708, 385);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(116, 39);
            btnLimpiar.TabIndex = 8;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.White;
            btnCalcular.Location = new Point(561, 385);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(116, 39);
            btnCalcular.TabIndex = 7;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtAños
            // 
            txtAños.Location = new Point(724, 53);
            txtAños.Name = "txtAños";
            txtAños.Size = new Size(100, 31);
            txtAños.TabIndex = 5;
            // 
            // txtTasaDescuento
            // 
            txtTasaDescuento.Location = new Point(517, 50);
            txtTasaDescuento.Name = "txtTasaDescuento";
            txtTasaDescuento.Size = new Size(100, 31);
            txtTasaDescuento.TabIndex = 4;
            // 
            // txtInverIni
            // 
            txtInverIni.Location = new Point(198, 50);
            txtInverIni.Name = "txtInverIni";
            txtInverIni.Size = new Size(100, 31);
            txtInverIni.TabIndex = 3;
            txtInverIni.TextChanged += textBox1_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(653, 53);
            label5.Name = "label5";
            label5.Size = new Size(68, 28);
            label5.TabIndex = 2;
            label5.Text = "Años :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(332, 53);
            label4.Name = "label4";
            label4.Size = new Size(187, 28);
            label4.TabIndex = 1;
            label4.Text = "Tasa de Descuento :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 53);
            label3.Name = "label3";
            label3.Size = new Size(171, 28);
            label3.TabIndex = 0;
            label3.Text = "Inversion Inicial :";
            // 
            // Column1
            // 
            Column1.HeaderText = "Inversion Inicial";
            Column1.Name = "Column1";
            Column1.Width = 120;
            // 
            // Column2
            // 
            Column2.HeaderText = "Tasa Interes (I)";
            Column2.Name = "Column2";
            Column2.Width = 120;
            // 
            // Column3
            // 
            Column3.HeaderText = "Tasa Nominal (J)";
            Column3.Name = "Column3";
            Column3.Width = 120;
            // 
            // Column4
            // 
            Column4.HeaderText = "FNE";
            Column4.Name = "Column4";
            Column4.Width = 120;
            // 
            // Column5
            // 
            Column5.HeaderText = "Periodo";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Total";
            Column6.Name = "Column6";
            Column6.Width = 120;
            // 
            // FrmVPN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 672);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmVPN";
            Text = "FrmVPN";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Button btnLimpiar;
        private Button btnCalcular;
        private TextBox txtAños;
        private TextBox txtTasaDescuento;
        private TextBox txtInverIni;
        private Label label5;
        private Label label4;
        private Label label3;
        private DataGridView dataGridView1;
        private TextBox txtFne;
        private Label label7;
        private ComboBox cboPeri;
        private TextBox txtnomi;
        private Label label6;
        private ComboBox cboNomi;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}