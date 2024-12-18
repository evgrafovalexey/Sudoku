﻿
namespace Sudoku
{
    partial class NumpadGrid4Dialog
    {

        private System.ComponentModel.IContainer components = null;

        // очистка
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        // редактор кнопок
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NumpadGrid4Dialog));
            btnNumber1 = new System.Windows.Forms.Button();
            btnNumber2 = new System.Windows.Forms.Button();
            btnNumber3 = new System.Windows.Forms.Button();
            btnNumber4 = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            btnClear = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btnNumber1
            // 
            btnNumber1.BackColor = System.Drawing.Color.DarkGreen;
            btnNumber1.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNumber1.FlatAppearance.BorderSize = 0;
            btnNumber1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNumber1.ForeColor = System.Drawing.Color.GhostWhite;
            btnNumber1.Location = new System.Drawing.Point(18, 12);
            btnNumber1.Name = "btnNumber1";
            btnNumber1.Size = new System.Drawing.Size(79, 29);
            btnNumber1.TabIndex = 0;
            btnNumber1.Text = "1";
            btnNumber1.UseVisualStyleBackColor = false;
            btnNumber1.Click += BtnNumber_Click;
            // 
            // btnNumber2
            // 
            btnNumber2.BackColor = System.Drawing.Color.DarkGreen;
            btnNumber2.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNumber2.FlatAppearance.BorderSize = 0;
            btnNumber2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNumber2.ForeColor = System.Drawing.Color.GhostWhite;
            btnNumber2.Location = new System.Drawing.Point(103, 12);
            btnNumber2.Name = "btnNumber2";
            btnNumber2.Size = new System.Drawing.Size(81, 29);
            btnNumber2.TabIndex = 1;
            btnNumber2.Text = "2";
            btnNumber2.UseVisualStyleBackColor = false;
            btnNumber2.Click += BtnNumber_Click;
            // 
            // btnNumber3
            // 
            btnNumber3.BackColor = System.Drawing.Color.DarkGreen;
            btnNumber3.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNumber3.FlatAppearance.BorderSize = 0;
            btnNumber3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNumber3.ForeColor = System.Drawing.Color.GhostWhite;
            btnNumber3.Location = new System.Drawing.Point(18, 57);
            btnNumber3.Name = "btnNumber3";
            btnNumber3.Size = new System.Drawing.Size(79, 29);
            btnNumber3.TabIndex = 2;
            btnNumber3.Text = "3";
            btnNumber3.UseVisualStyleBackColor = false;
            btnNumber3.Click += BtnNumber_Click;
            // 
            // btnNumber4
            // 
            btnNumber4.BackColor = System.Drawing.Color.DarkGreen;
            btnNumber4.Cursor = System.Windows.Forms.Cursors.Hand;
            btnNumber4.FlatAppearance.BorderSize = 0;
            btnNumber4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNumber4.ForeColor = System.Drawing.Color.GhostWhite;
            btnNumber4.Location = new System.Drawing.Point(103, 57);
            btnNumber4.Name = "btnNumber4";
            btnNumber4.Size = new System.Drawing.Size(81, 29);
            btnNumber4.TabIndex = 3;
            btnNumber4.Text = "4";
            btnNumber4.UseVisualStyleBackColor = false;
            btnNumber4.Click += BtnNumber_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = System.Drawing.Color.ForestGreen;
            btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.ForeColor = System.Drawing.Color.GhostWhite;
            btnCancel.Location = new System.Drawing.Point(18, 107);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(79, 29);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += BtnCancel_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = System.Drawing.Color.Red;
            btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClear.ForeColor = System.Drawing.Color.GhostWhite;
            btnClear.Location = new System.Drawing.Point(103, 107);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(81, 29);
            btnClear.TabIndex = 9;
            btnClear.Text = "Удалить";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += BtnClear_Click;
            // 
            // NumpadGrid4Dialog
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(205, 169);
            Controls.Add(btnCancel);
            Controls.Add(btnClear);
            Controls.Add(btnNumber4);
            Controls.Add(btnNumber3);
            Controls.Add(btnNumber2);
            Controls.Add(btnNumber1);
            Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NumpadGrid4Dialog";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Ввод значений";
            Load += NumpadGrid4Dialog_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnNumber1;
        private System.Windows.Forms.Button btnNumber2;
        private System.Windows.Forms.Button btnNumber3;
        private System.Windows.Forms.Button btnNumber4;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClear;
    }
}