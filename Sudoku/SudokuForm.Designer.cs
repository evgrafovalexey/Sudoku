
namespace Sudoku
{
    partial class SudokuForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SudokuForm));
            lblTimer = new System.Windows.Forms.Label();
            timer = new System.Windows.Forms.Timer(components);
            cmbBoxMode = new System.Windows.Forms.ComboBox();
            cmbBoxGrid = new System.Windows.Forms.ComboBox();
            lblMode = new System.Windows.Forms.Label();
            lblGrid = new System.Windows.Forms.Label();
            lblStatus = new System.Windows.Forms.Label();
            gridView = new System.Windows.Forms.DataGridView();
            messageTimer = new System.Windows.Forms.Timer(components);
            rjButton1 = new CustomControls.RJControls.RJButton();
            rjButton2 = new CustomControls.RJControls.RJButton();
            rjButton3 = new CustomControls.RJControls.RJButton();
            rjButton4 = new CustomControls.RJControls.RJButton();
            rjButton5 = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
            SuspendLayout();
            // 
            // lblTimer
            // 
            lblTimer.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblTimer.AutoSize = true;
            lblTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            lblTimer.Font = new System.Drawing.Font("Maiandra GD", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblTimer.ForeColor = System.Drawing.Color.White;
            lblTimer.Location = new System.Drawing.Point(388, 6);
            lblTimer.Name = "lblTimer";
            lblTimer.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);
            lblTimer.Size = new System.Drawing.Size(174, 62);
            lblTimer.TabIndex = 7;
            lblTimer.Text = "00:00:00";
            lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            // 
            // cmbBoxMode
            // 
            cmbBoxMode.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cmbBoxMode.BackColor = System.Drawing.Color.PaleTurquoise;
            cmbBoxMode.Cursor = System.Windows.Forms.Cursors.Hand;
            cmbBoxMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbBoxMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cmbBoxMode.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cmbBoxMode.FormattingEnabled = true;
            cmbBoxMode.Items.AddRange(new object[] { "Easy ", "Medium", "Master" });
            cmbBoxMode.Location = new System.Drawing.Point(12, 44);
            cmbBoxMode.Name = "cmbBoxMode";
            cmbBoxMode.Size = new System.Drawing.Size(168, 24);
            cmbBoxMode.TabIndex = 4;
            cmbBoxMode.SelectedIndexChanged += CmbBoxMode_SelectedIndexChanged;
            // 
            // cmbBoxGrid
            // 
            cmbBoxGrid.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cmbBoxGrid.BackColor = System.Drawing.Color.PaleTurquoise;
            cmbBoxGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            cmbBoxGrid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbBoxGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cmbBoxGrid.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cmbBoxGrid.FormattingEnabled = true;
            cmbBoxGrid.Items.AddRange(new object[] { "4 X 4", "9 X 9" });
            cmbBoxGrid.Location = new System.Drawing.Point(12, 101);
            cmbBoxGrid.Name = "cmbBoxGrid";
            cmbBoxGrid.Size = new System.Drawing.Size(168, 24);
            cmbBoxGrid.TabIndex = 5;
            cmbBoxGrid.SelectedIndexChanged += CmbBoxGrid_SelectedIndexChanged;
            // 
            // lblMode
            // 
            lblMode.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblMode.AutoSize = true;
            lblMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            lblMode.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblMode.ForeColor = System.Drawing.Color.Teal;
            lblMode.Location = new System.Drawing.Point(12, 17);
            lblMode.Name = "lblMode";
            lblMode.Size = new System.Drawing.Size(185, 22);
            lblMode.TabIndex = 6;
            lblMode.Text = "Уровень сложности:";
            // 
            // lblGrid
            // 
            lblGrid.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblGrid.AutoSize = true;
            lblGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            lblGrid.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblGrid.ForeColor = System.Drawing.Color.Teal;
            lblGrid.Location = new System.Drawing.Point(12, 73);
            lblGrid.Name = "lblGrid";
            lblGrid.Size = new System.Drawing.Size(76, 22);
            lblGrid.TabIndex = 7;
            lblGrid.Text = "Размер:";
            // 
            // lblStatus
            // 
            lblStatus.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblStatus.AutoSize = true;
            lblStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            lblStatus.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblStatus.ForeColor = System.Drawing.Color.Teal;
            lblStatus.Location = new System.Drawing.Point(259, 73);
            lblStatus.MinimumSize = new System.Drawing.Size(431, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new System.Drawing.Size(431, 20);
            lblStatus.TabIndex = 8;
            lblStatus.Text = "Начните решать головоломку";
            lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblStatus.Click += lblStatus_Click;
            // 
            // gridView
            // 
            gridView.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            gridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            gridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            gridView.BackgroundColor = System.Drawing.Color.Gray;
            gridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            gridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridView.GridColor = System.Drawing.Color.White;
            gridView.Location = new System.Drawing.Point(259, 101);
            gridView.Name = "gridView";
            gridView.RowTemplate.Height = 25;
            gridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            gridView.Size = new System.Drawing.Size(388, 386);
            gridView.TabIndex = 6;
            // 
            // messageTimer
            // 
            messageTimer.Enabled = true;
            messageTimer.Interval = 5000;
            messageTimer.Tick += MessageTimer_Tick;
            // 
            // rjButton1
            // 
            rjButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            rjButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            rjButton1.BorderRadius = 10;
            rjButton1.BorderSize = 0;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rjButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            rjButton1.ForeColor = System.Drawing.Color.White;
            rjButton1.Location = new System.Drawing.Point(725, 137);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new System.Drawing.Size(166, 46);
            rjButton1.TabIndex = 9;
            rjButton1.Text = "Новая игра";
            rjButton1.TextColor = System.Drawing.Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += rjButton1_Click;
            // 
            // rjButton2
            // 
            rjButton2.BackColor = System.Drawing.Color.RoyalBlue;
            rjButton2.BackgroundColor = System.Drawing.Color.RoyalBlue;
            rjButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            rjButton2.BorderRadius = 10;
            rjButton2.BorderSize = 0;
            rjButton2.FlatAppearance.BorderSize = 0;
            rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rjButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            rjButton2.ForeColor = System.Drawing.Color.White;
            rjButton2.Location = new System.Drawing.Point(725, 203);
            rjButton2.Name = "rjButton2";
            rjButton2.Size = new System.Drawing.Size(166, 46);
            rjButton2.TabIndex = 10;
            rjButton2.Text = "Проверить";
            rjButton2.TextColor = System.Drawing.Color.White;
            rjButton2.UseVisualStyleBackColor = false;
            rjButton2.Click += rjButton2_Click;
            // 
            // rjButton3
            // 
            rjButton3.BackColor = System.Drawing.Color.Green;
            rjButton3.BackgroundColor = System.Drawing.Color.Green;
            rjButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            rjButton3.BorderRadius = 10;
            rjButton3.BorderSize = 0;
            rjButton3.FlatAppearance.BorderSize = 0;
            rjButton3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            rjButton3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            rjButton3.ForeColor = System.Drawing.Color.White;
            rjButton3.Location = new System.Drawing.Point(725, 267);
            rjButton3.Name = "rjButton3";
            rjButton3.Size = new System.Drawing.Size(166, 46);
            rjButton3.TabIndex = 11;
            rjButton3.Text = "Решение";
            rjButton3.TextColor = System.Drawing.Color.White;
            rjButton3.UseVisualStyleBackColor = false;
            rjButton3.Click += rjButton3_Click;
            // 
            // rjButton4
            // 
            rjButton4.BackColor = System.Drawing.Color.Red;
            rjButton4.BackgroundColor = System.Drawing.Color.Red;
            rjButton4.BorderColor = System.Drawing.Color.PaleVioletRed;
            rjButton4.BorderRadius = 10;
            rjButton4.BorderSize = 0;
            rjButton4.FlatAppearance.BorderSize = 0;
            rjButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rjButton4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            rjButton4.ForeColor = System.Drawing.Color.White;
            rjButton4.Location = new System.Drawing.Point(725, 329);
            rjButton4.Name = "rjButton4";
            rjButton4.Size = new System.Drawing.Size(166, 46);
            rjButton4.TabIndex = 12;
            rjButton4.Text = "Очистить";
            rjButton4.TextColor = System.Drawing.Color.White;
            rjButton4.UseVisualStyleBackColor = false;
            rjButton4.Click += rjButton4_Click;
            // 
            // rjButton5
            // 
            rjButton5.BackColor = System.Drawing.Color.Teal;
            rjButton5.BackgroundColor = System.Drawing.Color.Teal;
            rjButton5.BorderColor = System.Drawing.Color.PaleVioletRed;
            rjButton5.BorderRadius = 10;
            rjButton5.BorderSize = 0;
            rjButton5.DialogResult = System.Windows.Forms.DialogResult.Yes;
            rjButton5.FlatAppearance.BorderSize = 0;
            rjButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            rjButton5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            rjButton5.ForeColor = System.Drawing.Color.White;
            rjButton5.Location = new System.Drawing.Point(708, 452);
            rjButton5.Name = "rjButton5";
            rjButton5.Size = new System.Drawing.Size(197, 35);
            rjButton5.TabIndex = 13;
            rjButton5.Text = "Правила игры";
            rjButton5.TextColor = System.Drawing.Color.White;
            rjButton5.UseVisualStyleBackColor = false;
            rjButton5.Click += rjButton5_Click;
            // 
            // SudokuForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.LightBlue;
            ClientSize = new System.Drawing.Size(950, 613);
            Controls.Add(rjButton5);
            Controls.Add(rjButton4);
            Controls.Add(rjButton3);
            Controls.Add(rjButton2);
            Controls.Add(rjButton1);
            Controls.Add(gridView);
            Controls.Add(lblStatus);
            Controls.Add(lblGrid);
            Controls.Add(lblMode);
            Controls.Add(cmbBoxGrid);
            Controls.Add(cmbBoxMode);
            Controls.Add(lblTimer);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "SudokuForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Судоку";
            Load += SudokuForm_Load;
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ComboBox cmbBoxMode;
        private System.Windows.Forms.ComboBox cmbBoxGrid;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.Label lblGrid;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.Timer messageTimer;
        private CustomControls.RJControls.RJButton rjButton1;
        private CustomControls.RJControls.RJButton rjButton2;
        private CustomControls.RJControls.RJButton rjButton3;
        private CustomControls.RJControls.RJButton rjButton4;
        private CustomControls.RJControls.RJButton rjButton5;
    }
}

