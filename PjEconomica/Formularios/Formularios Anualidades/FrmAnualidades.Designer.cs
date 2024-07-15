namespace PjEconomica.Formularios.Formularios_Anualidades
{
    partial class FrmAnualidades
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
            btnAnuAnticipadas = new Button();
            btnAnuVencida = new Button();
            btnAnuPerpetuas = new Button();
            btnAnuDiferidas = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(148, 29);
            label1.Name = "label1";
            label1.Size = new Size(348, 30);
            label1.TabIndex = 8;
            label1.Text = "¡Seleccione el tipo de anualidad!";
            // 
            // btnAnuAnticipadas
            // 
            btnAnuAnticipadas.BackColor = Color.White;
            btnAnuAnticipadas.Font = new Font("Sitka Text", 12F, FontStyle.Bold);
            btnAnuAnticipadas.Location = new Point(365, 107);
            btnAnuAnticipadas.Name = "btnAnuAnticipadas";
            btnAnuAnticipadas.Size = new Size(211, 64);
            btnAnuAnticipadas.TabIndex = 7;
            btnAnuAnticipadas.Text = "Anticipadas";
            btnAnuAnticipadas.UseVisualStyleBackColor = false;
            btnAnuAnticipadas.Click += btnAnuAnticipadas_Click;
            // 
            // btnAnuVencida
            // 
            btnAnuVencida.BackColor = Color.White;
            btnAnuVencida.Font = new Font("Sitka Text", 12F, FontStyle.Bold);
            btnAnuVencida.Location = new Point(106, 107);
            btnAnuVencida.Name = "btnAnuVencida";
            btnAnuVencida.Size = new Size(211, 64);
            btnAnuVencida.TabIndex = 6;
            btnAnuVencida.Text = "Vencidas";
            btnAnuVencida.UseVisualStyleBackColor = false;
            btnAnuVencida.Click += btnAnuVencida_Click;
            // 
            // btnAnuPerpetuas
            // 
            btnAnuPerpetuas.BackColor = Color.White;
            btnAnuPerpetuas.Font = new Font("Sitka Text", 12F, FontStyle.Bold);
            btnAnuPerpetuas.Location = new Point(365, 207);
            btnAnuPerpetuas.Name = "btnAnuPerpetuas";
            btnAnuPerpetuas.Size = new Size(211, 64);
            btnAnuPerpetuas.TabIndex = 10;
            btnAnuPerpetuas.Text = "Perpetuas";
            btnAnuPerpetuas.UseVisualStyleBackColor = false;
            btnAnuPerpetuas.Click += btnAnuPerpetuas_Click;
            // 
            // btnAnuDiferidas
            // 
            btnAnuDiferidas.BackColor = Color.White;
            btnAnuDiferidas.Font = new Font("Sitka Text", 12F, FontStyle.Bold);
            btnAnuDiferidas.Location = new Point(106, 207);
            btnAnuDiferidas.Name = "btnAnuDiferidas";
            btnAnuDiferidas.Size = new Size(211, 64);
            btnAnuDiferidas.TabIndex = 9;
            btnAnuDiferidas.Text = "Diferidas";
            btnAnuDiferidas.UseVisualStyleBackColor = false;
            btnAnuDiferidas.Click += btnAnuDiferidas_Click;
            // 
            // FrmAnualidades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 299);
            Controls.Add(btnAnuPerpetuas);
            Controls.Add(btnAnuDiferidas);
            Controls.Add(label1);
            Controls.Add(btnAnuAnticipadas);
            Controls.Add(btnAnuVencida);
            Name = "FrmAnualidades";
            Text = "FrmAnualidades";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAnuAnticipadas;
        private Button btnAnuVencida;
        private Button btnAnuPerpetuas;
        private Button btnAnuDiferidas;
    }
}