namespace PjEconomica.Formularios.Formularios_Indicadores
{
    partial class FrmTMAR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTMAR));
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            dgvResultados = new DataGridView();
            txtCPP = new TextBox();
            label7 = new Label();
            btnLimpiar = new Button();
            btnCalcular = new Button();
            txtPA = new TextBox();
            txtCD = new TextBox();
            txtMD = new TextBox();
            txtITP = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 29);
            label1.Name = "label1";
            label1.Size = new Size(728, 35);
            label1.TabIndex = 0;
            label1.Text = "¿Qué es la Tasa Mínima Atractiva de Rendimiento (TMAR) ?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 12.7499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(249, 81);
            label2.Name = "label2";
            label2.Size = new Size(382, 144);
            label2.TabIndex = 1;
            label2.Text = resources.GetString("label2.Text");
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(22, 103);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(196, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvResultados);
            groupBox1.Controls.Add(txtCPP);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Controls.Add(btnCalcular);
            groupBox1.Controls.Add(txtPA);
            groupBox1.Controls.Add(txtCD);
            groupBox1.Controls.Add(txtMD);
            groupBox1.Controls.Add(txtITP);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(15, 244);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(858, 344);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingrese los datos";
            // 
            // dgvResultados
            // 
            dgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultados.Location = new Point(358, 97);
            dgvResultados.Name = "dgvResultados";
            dgvResultados.Size = new Size(484, 220);
            dgvResultados.TabIndex = 13;
            // 
            // txtCPP
            // 
            txtCPP.Location = new Point(224, 234);
            txtCPP.Name = "txtCPP";
            txtCPP.Size = new Size(100, 31);
            txtCPP.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Text", 12F);
            label7.Location = new Point(20, 234);
            label7.Name = "label7";
            label7.Size = new Size(198, 23);
            label7.TabIndex = 11;
            label7.Text = "Costo del capital propio :\r\n";
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.White;
            btnLimpiar.Location = new Point(161, 279);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(105, 49);
            btnLimpiar.TabIndex = 10;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.White;
            btnCalcular.Location = new Point(19, 279);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(105, 49);
            btnCalcular.TabIndex = 9;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtPA
            // 
            txtPA.Location = new Point(202, 182);
            txtPA.Name = "txtPA";
            txtPA.Size = new Size(100, 31);
            txtPA.TabIndex = 7;
            // 
            // txtCD
            // 
            txtCD.Location = new Point(179, 130);
            txtCD.Name = "txtCD";
            txtCD.Size = new Size(100, 31);
            txtCD.TabIndex = 6;
            txtCD.TextChanged += textBox3_TextChanged;
            // 
            // txtMD
            // 
            txtMD.Location = new Point(190, 85);
            txtMD.Name = "txtMD";
            txtMD.Size = new Size(100, 31);
            txtMD.TabIndex = 5;
            // 
            // txtITP
            // 
            txtITP.Location = new Point(262, 39);
            txtITP.Name = "txtITP";
            txtITP.Size = new Size(100, 31);
            txtITP.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Text", 12F);
            label6.Location = new Point(20, 182);
            label6.Name = "label6";
            label6.Size = new Size(176, 23);
            label6.TabIndex = 3;
            label6.Text = "Patrimonio aportado :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Text", 12F);
            label5.Location = new Point(20, 137);
            label5.Name = "label5";
            label5.Size = new Size(153, 23);
            label5.TabIndex = 2;
            label5.Text = "Costo de la deuda :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Text", 12F);
            label4.Location = new Point(19, 85);
            label4.Name = "label4";
            label4.Size = new Size(165, 23);
            label4.TabIndex = 1;
            label4.Text = "Monto de la deuda : \r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Text", 12F);
            label3.Location = new Point(19, 39);
            label3.Name = "label3";
            label3.Size = new Size(237, 23);
            label3.TabIndex = 0;
            label3.Text = "Inversión Total del Proyecto : ";
            // 
            // FrmTMAR
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(885, 600);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmTMAR";
            Text = "FrmTMAR";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnLimpiar;
        private Button btnCalcular;
        private TextBox txtPA;
        private TextBox txtCD;
        private TextBox txtMD;
        private TextBox txtITP;
        private TextBox txtCPP;
        private Label label7;
        private DataGridView dgvResultados;
    }
}