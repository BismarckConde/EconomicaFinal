namespace PjEconomica
{
    partial class FrmDfinicionEconomica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDfinicionEconomica));
            label1 = new Label();
            label2 = new Label();
            btnMenuOp = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(146, 9);
            label1.Name = "label1";
            label1.Size = new Size(408, 35);
            label1.TabIndex = 0;
            label1.Text = "¿Qué es la ingeniería económica?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(203, 71);
            label2.Name = "label2";
            label2.Size = new Size(472, 138);
            label2.TabIndex = 1;
            label2.Text = resources.GetString("label2.Text");
            // 
            // btnMenuOp
            // 
            btnMenuOp.BackColor = Color.White;
            btnMenuOp.Font = new Font("Sitka Text", 11.249999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenuOp.Location = new Point(526, 222);
            btnMenuOp.Name = "btnMenuOp";
            btnMenuOp.Size = new Size(149, 34);
            btnMenuOp.TabIndex = 2;
            btnMenuOp.Text = "Menú de opciones";
            btnMenuOp.UseVisualStyleBackColor = false;
            btnMenuOp.Click += btnMenuOp_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._16_11;
            pictureBox1.Location = new Point(12, 71);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(185, 153);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // FrmDfinicionEconomica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(708, 268);
            Controls.Add(pictureBox1);
            Controls.Add(btnMenuOp);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmDfinicionEconomica";
            Text = "FrmDfinicionEconomica";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnMenuOp;
        private PictureBox pictureBox1;
    }
}