namespace PjEconomica.Formularios.Formularios_Indicadores
{
    partial class FrmIndicadores
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
            btnCaue = new Button();
            btnVpn = new Button();
            label1 = new Label();
            btnTir = new Button();
            btntmar = new Button();
            SuspendLayout();
            // 
            // btnCaue
            // 
            btnCaue.BackColor = Color.White;
            btnCaue.Font = new Font("Sitka Text", 12F, FontStyle.Bold);
            btnCaue.Location = new Point(365, 206);
            btnCaue.Name = "btnCaue";
            btnCaue.Size = new Size(211, 64);
            btnCaue.TabIndex = 15;
            btnCaue.Text = "CAUE";
            btnCaue.UseVisualStyleBackColor = false;
            btnCaue.Click += btnCaue_Click;
            // 
            // btnVpn
            // 
            btnVpn.BackColor = Color.White;
            btnVpn.Font = new Font("Sitka Text", 12F, FontStyle.Bold);
            btnVpn.Location = new Point(106, 206);
            btnVpn.Name = "btnVpn";
            btnVpn.Size = new Size(211, 64);
            btnVpn.TabIndex = 14;
            btnVpn.Text = "VPN";
            btnVpn.UseVisualStyleBackColor = false;
            btnVpn.Click += btnVpn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(148, 28);
            label1.Name = "label1";
            label1.Size = new Size(344, 30);
            label1.TabIndex = 13;
            label1.Text = "¡Seleccione el tipo de indicador!";
            // 
            // btnTir
            // 
            btnTir.BackColor = Color.White;
            btnTir.Font = new Font("Sitka Text", 12F, FontStyle.Bold);
            btnTir.Location = new Point(365, 106);
            btnTir.Name = "btnTir";
            btnTir.Size = new Size(211, 64);
            btnTir.TabIndex = 12;
            btnTir.Text = "TIR";
            btnTir.UseVisualStyleBackColor = false;
            btnTir.Click += btnTir_Click;
            // 
            // btntmar
            // 
            btntmar.BackColor = Color.White;
            btntmar.Font = new Font("Sitka Text", 12F, FontStyle.Bold);
            btntmar.Location = new Point(106, 106);
            btntmar.Name = "btntmar";
            btntmar.Size = new Size(211, 64);
            btntmar.TabIndex = 11;
            btntmar.Text = "TMAR";
            btntmar.UseVisualStyleBackColor = false;
            btntmar.Click += btntmar_Click;
            // 
            // FrmIndicadores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 299);
            Controls.Add(btnCaue);
            Controls.Add(btnVpn);
            Controls.Add(label1);
            Controls.Add(btnTir);
            Controls.Add(btntmar);
            Name = "FrmIndicadores";
            Text = "FrmIndicadores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCaue;
        private Button btnVpn;
        private Label label1;
        private Button btnTir;
        private Button btntmar;
    }
}