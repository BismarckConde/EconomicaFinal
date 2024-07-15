namespace PjEconomica.Formularios.Formularios_Gradientes
{
    partial class FrmGradientes
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
            btnGraGeo = new Button();
            btnGraArit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(148, 22);
            label1.Name = "label1";
            label1.Size = new Size(355, 30);
            label1.TabIndex = 5;
            label1.Text = "¡Seleccione el tipo de gradientes!";
            // 
            // btnGraGeo
            // 
            btnGraGeo.BackColor = Color.White;
            btnGraGeo.Font = new Font("Sitka Text", 12F, FontStyle.Bold);
            btnGraGeo.Location = new Point(365, 100);
            btnGraGeo.Name = "btnGraGeo";
            btnGraGeo.Size = new Size(211, 64);
            btnGraGeo.TabIndex = 4;
            btnGraGeo.Text = "Geométrico";
            btnGraGeo.UseVisualStyleBackColor = false;
            btnGraGeo.Click += btnGraGeo_Click;
            // 
            // btnGraArit
            // 
            btnGraArit.BackColor = Color.White;
            btnGraArit.Font = new Font("Sitka Text", 12F, FontStyle.Bold);
            btnGraArit.Location = new Point(106, 100);
            btnGraArit.Name = "btnGraArit";
            btnGraArit.Size = new Size(211, 64);
            btnGraArit.TabIndex = 3;
            btnGraArit.Text = "Aritmético";
            btnGraArit.UseVisualStyleBackColor = false;
            btnGraArit.Click += btnGraArit_Click;
            // 
            // FrmGradientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 200);
            Controls.Add(label1);
            Controls.Add(btnGraGeo);
            Controls.Add(btnGraArit);
            Name = "FrmGradientes";
            Text = "FrmGradientes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnGraGeo;
        private Button btnGraArit;
    }
}