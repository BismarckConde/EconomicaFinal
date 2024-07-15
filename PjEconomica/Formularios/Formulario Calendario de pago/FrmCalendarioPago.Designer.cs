namespace PjEconomica.Formularios.Formulario_Calendario_de_pago
{
    partial class FrmCalendarioPago
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
            groupBox1 = new GroupBox();
            button1 = new Button();
            label4 = new Label();
            button2 = new Button();
            txtInteres = new TextBox();
            button3 = new Button();
            label3 = new Label();
            txtSaldo = new TextBox();
            label2 = new Label();
            dgvCalendario = new DataGridView();
            txtPeriodos = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCalendario).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(290, 18);
            label1.Name = "label1";
            label1.Size = new Size(273, 39);
            label1.TabIndex = 0;
            label1.Text = "Calendario de pago";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPeriodos);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(txtInteres);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtSaldo);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Sitka Text", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 71);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(790, 165);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ingresa los datos";
            // 
            // button1
            // 
            button1.Font = new Font("Sitka Text", 12F);
            button1.Location = new Point(619, 110);
            button1.Name = "button1";
            button1.Size = new Size(156, 43);
            button1.TabIndex = 2;
            button1.Text = "Limpiar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Text", 12F);
            label4.Location = new Point(555, 45);
            label4.Name = "label4";
            label4.Size = new Size(77, 23);
            label4.TabIndex = 4;
            label4.Text = "periodo :";
            // 
            // button2
            // 
            button2.Font = new Font("Sitka Text", 12F);
            button2.Location = new Point(361, 110);
            button2.Name = "button2";
            button2.Size = new Size(156, 43);
            button2.TabIndex = 6;
            button2.Text = "Exportar a Excel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtInteres
            // 
            txtInteres.Font = new Font("Sitka Text", 12F);
            txtInteres.Location = new Point(417, 42);
            txtInteres.Name = "txtInteres";
            txtInteres.Size = new Size(100, 28);
            txtInteres.TabIndex = 3;
            // 
            // button3
            // 
            button3.Font = new Font("Sitka Text", 12F);
            button3.Location = new Point(16, 110);
            button3.Name = "button3";
            button3.Size = new Size(219, 43);
            button3.TabIndex = 7;
            button3.Text = "Generar Calendario";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Text", 12F);
            label3.Location = new Point(278, 42);
            label3.Name = "label3";
            label3.Size = new Size(133, 23);
            label3.TabIndex = 2;
            label3.Text = "Tasa de interes :";
            // 
            // txtSaldo
            // 
            txtSaldo.Font = new Font("Sitka Text", 12F);
            txtSaldo.Location = new Point(126, 39);
            txtSaldo.Name = "txtSaldo";
            txtSaldo.Size = new Size(100, 28);
            txtSaldo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 12F);
            label2.Location = new Point(6, 42);
            label2.Name = "label2";
            label2.Size = new Size(114, 23);
            label2.TabIndex = 0;
            label2.Text = "Saldo inicial :";
            // 
            // dgvCalendario
            // 
            dgvCalendario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCalendario.Location = new Point(18, 242);
            dgvCalendario.Name = "dgvCalendario";
            dgvCalendario.Size = new Size(784, 196);
            dgvCalendario.TabIndex = 8;
            // 
            // txtPeriodos
            // 
            txtPeriodos.Location = new Point(638, 45);
            txtPeriodos.Name = "txtPeriodos";
            txtPeriodos.Size = new Size(100, 31);
            txtPeriodos.TabIndex = 8;
            // 
            // FrmCalendarioPago
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 450);
            Controls.Add(dgvCalendario);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "FrmCalendarioPago";
            Text = "FrmCalendarioPago";
            Load += FrmCalendarioPago_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCalendario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtInteres;
        private Label label3;
        private TextBox txtSaldo;
        private Label label2;
        private Label label4;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dgvCalendario;
        private TextBox txtPeriodos;
    }
}