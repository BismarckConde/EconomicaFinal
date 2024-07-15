namespace PjEconomica.Formularios.Formularios_Indicadores
{
    partial class FrmFondoAmortizacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFondoAmortizacion));
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            txtValorC = new TextBox();
            label7 = new Label();
            dgvAmort = new DataGridView();
            btnLimpiar = new Button();
            btnCalcular = new Button();
            txtperiodo = new TextBox();
            txtInteres = new TextBox();
            txtValorVs = new TextBox();
            txtValorI = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAmort).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(141, 26);
            label1.Name = "label1";
            label1.Size = new Size(522, 30);
            label1.TabIndex = 0;
            label1.Text = "¿Qué es el fondo de amortización de salvamento?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(236, 71);
            label2.Name = "label2";
            label2.Size = new Size(448, 138);
            label2.TabIndex = 1;
            label2.Text = resources.GetString("label2.Text");
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Gradientes;
            pictureBox1.Location = new Point(23, 71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(185, 131);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtValorC);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(dgvAmort);
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Controls.Add(btnCalcular);
            groupBox1.Controls.Add(txtperiodo);
            groupBox1.Controls.Add(txtInteres);
            groupBox1.Controls.Add(txtValorVs);
            groupBox1.Controls.Add(txtValorI);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 226);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(722, 364);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingrese los datos";
            // 
            // txtValorC
            // 
            txtValorC.Location = new Point(579, 38);
            txtValorC.Name = "txtValorC";
            txtValorC.Size = new Size(100, 31);
            txtValorC.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Text", 12F);
            label7.Location = new Point(493, 39);
            label7.Name = "label7";
            label7.Size = new Size(75, 23);
            label7.TabIndex = 12;
            label7.Text = "Valor C :";
            // 
            // dgvAmort
            // 
            dgvAmort.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAmort.Location = new Point(19, 140);
            dgvAmort.Name = "dgvAmort";
            dgvAmort.Size = new Size(667, 208);
            dgvAmort.TabIndex = 11;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.White;
            btnLimpiar.Location = new Point(584, 86);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(102, 34);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.White;
            btnCalcular.Location = new Point(463, 86);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(115, 35);
            btnCalcular.TabIndex = 9;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtperiodo
            // 
            txtperiodo.Location = new Point(336, 84);
            txtperiodo.Name = "txtperiodo";
            txtperiodo.Size = new Size(100, 31);
            txtperiodo.TabIndex = 7;
            // 
            // txtInteres
            // 
            txtInteres.Location = new Point(336, 38);
            txtInteres.Name = "txtInteres";
            txtInteres.Size = new Size(100, 31);
            txtInteres.TabIndex = 6;
            // 
            // txtValorVs
            // 
            txtValorVs.Location = new Point(129, 85);
            txtValorVs.Name = "txtValorVs";
            txtValorVs.Size = new Size(100, 31);
            txtValorVs.TabIndex = 5;
            // 
            // txtValorI
            // 
            txtValorI.Location = new Point(129, 39);
            txtValorI.Name = "txtValorI";
            txtValorI.Size = new Size(100, 31);
            txtValorI.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Text", 12F);
            label6.Location = new Point(250, 85);
            label6.Name = "label6";
            label6.Size = new Size(77, 23);
            label6.TabIndex = 3;
            label6.Text = "Periodo :\r\n";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Text", 12F);
            label5.Location = new Point(250, 39);
            label5.Name = "label5";
            label5.Size = new Size(73, 23);
            label5.TabIndex = 2;
            label5.Text = "Interes :\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Text", 12F);
            label4.Location = new Point(19, 85);
            label4.Name = "label4";
            label4.Size = new Size(84, 23);
            label4.TabIndex = 1;
            label4.Text = "Valor VS :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Text", 12F);
            label3.Location = new Point(19, 39);
            label3.Name = "label3";
            label3.Size = new Size(71, 23);
            label3.TabIndex = 0;
            label3.Text = "Valor I :\r\n";
            // 
            // FrmFondoAmortizacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(757, 600);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmFondoAmortizacion";
            Text = "FrmFondoAmortizacion";
            Load += FrmFondoAmortizacion_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAmort).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private DataGridView dgvAmort;
        private Button btnLimpiar;
        private Button btnCalcular;
        private TextBox txtperiodo;
        private TextBox txtInteres;
        private TextBox txtValorVs;
        private TextBox txtValorI;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtValorC;
        private Label label7;
    }
}