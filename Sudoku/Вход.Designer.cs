namespace Sudoku
{
    partial class Вход
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Вход));
            pictureBox1 = new System.Windows.Forms.PictureBox();
            rjButton1 = new CustomControls.RJControls.RJButton();
            rjButton2 = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(134, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(319, 297);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // rjButton1
            // 
            rjButton1.BackColor = System.Drawing.Color.DarkCyan;
            rjButton1.BackgroundColor = System.Drawing.Color.DarkCyan;
            rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            rjButton1.BorderRadius = 10;
            rjButton1.BorderSize = 0;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rjButton1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            rjButton1.ForeColor = System.Drawing.Color.White;
            rjButton1.Location = new System.Drawing.Point(164, 347);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new System.Drawing.Size(267, 72);
            rjButton1.TabIndex = 1;
            rjButton1.Text = "Начать игру";
            rjButton1.TextColor = System.Drawing.Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += rjButton1_Click;
            // 
            // rjButton2
            // 
            rjButton2.BackColor = System.Drawing.Color.FromArgb(0, 192, 192);
            rjButton2.BackgroundColor = System.Drawing.Color.FromArgb(0, 192, 192);
            rjButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            rjButton2.BorderRadius = 10;
            rjButton2.BorderSize = 0;
            rjButton2.FlatAppearance.BorderSize = 0;
            rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rjButton2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            rjButton2.ForeColor = System.Drawing.Color.White;
            rjButton2.Location = new System.Drawing.Point(196, 448);
            rjButton2.Name = "rjButton2";
            rjButton2.Size = new System.Drawing.Size(197, 49);
            rjButton2.TabIndex = 2;
            rjButton2.Text = "Правила игры";
            rjButton2.TextColor = System.Drawing.Color.White;
            rjButton2.UseVisualStyleBackColor = false;
            rjButton2.Click += rjButton2_Click;
            // 
            // Вход
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.MintCream;
            ClientSize = new System.Drawing.Size(593, 566);
            Controls.Add(rjButton2);
            Controls.Add(rjButton1);
            Controls.Add(pictureBox1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "Вход";
            Text = "Судоку";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private CustomControls.RJControls.RJButton rjButton1;
        private CustomControls.RJControls.RJButton rjButton2;
    }
}