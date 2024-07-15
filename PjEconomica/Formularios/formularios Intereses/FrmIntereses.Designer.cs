namespace PjEconomica.Formularios.formularios_Intereses
{
    partial class FrmIntereses
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
            btnIteresSimple = new Button();
            btnIntrescompuesto = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnIteresSimple
            // 
            btnIteresSimple.BackColor = Color.White;
            btnIteresSimple.Font = new Font("Sitka Text", 12F, FontStyle.Bold);
            btnIteresSimple.Location = new Point(101, 85);
            btnIteresSimple.Name = "btnIteresSimple";
            btnIteresSimple.Size = new Size(211, 64);
            btnIteresSimple.TabIndex = 0;
            btnIteresSimple.Text = "Simple";
            btnIteresSimple.UseVisualStyleBackColor = false;
            btnIteresSimple.Click += btnIteresSimple_Click;
            // 
            // btnIntrescompuesto
            // 
            btnIntrescompuesto.BackColor = Color.White;
            btnIntrescompuesto.Font = new Font("Sitka Text", 12F, FontStyle.Bold);
            btnIntrescompuesto.Location = new Point(360, 85);
            btnIntrescompuesto.Name = "btnIntrescompuesto";
            btnIntrescompuesto.Size = new Size(211, 64);
            btnIntrescompuesto.TabIndex = 1;
            btnIntrescompuesto.Text = "Compuesto";
            btnIntrescompuesto.UseVisualStyleBackColor = false;
            btnIntrescompuesto.Click += btnIntrescompuesto_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(190, 22);
            label1.Name = "label1";
            label1.Size = new Size(318, 30);
            label1.TabIndex = 2;
            label1.Text = "¡Seleccione el tipo de interes!";
            // 
            // FrmIntereses
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(682, 194);
            Controls.Add(label1);
            Controls.Add(btnIntrescompuesto);
            Controls.Add(btnIteresSimple);
            Name = "FrmIntereses";
            Text = "FrmIntereses";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIteresSimple;
        private Button btnIntrescompuesto;
        private Label label1;
    }
}