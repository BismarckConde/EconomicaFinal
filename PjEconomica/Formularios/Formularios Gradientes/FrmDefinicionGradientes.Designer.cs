namespace PjEconomica.Formularios.Formularios_Gradientes
{
    partial class FrmDefinicionGradientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDefinicionGradientes));
            pictureBox1 = new PictureBox();
            btnMenuOp = new Button();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._16_11;
            pictureBox1.Location = new Point(12, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(185, 153);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // btnMenuOp
            // 
            btnMenuOp.BackColor = Color.White;
            btnMenuOp.Font = new Font("Sitka Text", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenuOp.Location = new Point(540, 208);
            btnMenuOp.Name = "btnMenuOp";
            btnMenuOp.Size = new Size(166, 34);
            btnMenuOp.TabIndex = 6;
            btnMenuOp.Text = "Menú de Gradientes";
            btnMenuOp.UseVisualStyleBackColor = false;
            btnMenuOp.Click += btnMenuOp_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(203, 77);
            label2.Name = "label2";
            label2.Size = new Size(535, 115);
            label2.TabIndex = 5;
            label2.Text = resources.GetString("label2.Text");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(225, 21);
            label1.Name = "label1";
            label1.Size = new Size(310, 35);
            label1.TabIndex = 4;
            label1.Text = "¿Qué son los Gradientes?";
            // 
            // FrmDefinicionGradientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(747, 251);
            Controls.Add(pictureBox1);
            Controls.Add(btnMenuOp);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmDefinicionGradientes";
            Text = "FrmDefinicionGradientes";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnMenuOp;
        private Label label2;
        private Label label1;
    }
}