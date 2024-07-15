namespace PjEconomica.Formularios.Formularios_Indicadores
{
    partial class FrmCAUE
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
            btnValorpresent = new Button();
            btnFondoAmort = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(166, 9);
            label1.Name = "label1";
            label1.Size = new Size(301, 30);
            label1.TabIndex = 8;
            label1.Text = "¡Seleccione el tipo de CAUE!";
            // 
            // btnValorpresent
            // 
            btnValorpresent.BackColor = Color.White;
            btnValorpresent.Font = new Font("Sitka Text", 12F, FontStyle.Bold);
            btnValorpresent.Location = new Point(363, 76);
            btnValorpresent.Name = "btnValorpresent";
            btnValorpresent.Size = new Size(211, 64);
            btnValorpresent.TabIndex = 7;
            btnValorpresent.Text = "Valor presente de\r\nsalvamiento";
            btnValorpresent.UseVisualStyleBackColor = false;
            btnValorpresent.Click += btnValorpresent_Click;
            // 
            // btnFondoAmort
            // 
            btnFondoAmort.BackColor = Color.White;
            btnFondoAmort.Font = new Font("Sitka Text", 12F, FontStyle.Bold);
            btnFondoAmort.Location = new Point(104, 76);
            btnFondoAmort.Name = "btnFondoAmort";
            btnFondoAmort.Size = new Size(211, 64);
            btnFondoAmort.TabIndex = 6;
            btnFondoAmort.Text = "Fondo de amortización\r\nde salvamiento";
            btnFondoAmort.UseVisualStyleBackColor = false;
            btnFondoAmort.Click += btnFondoAmort_Click;
            // 
            // FrmCAUE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 200);
            Controls.Add(label1);
            Controls.Add(btnValorpresent);
            Controls.Add(btnFondoAmort);
            Name = "FrmCAUE";
            Text = "FrmCAUE";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnValorpresent;
        private Button btnFondoAmort;
    }
}