namespace Activity_5
{
    partial class ConvertTheWords
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
            this.NamesListBox = new System.Windows.Forms.ListBox();
            this.ShowNamesButton = new System.Windows.Forms.Button();
            this.ConvertNamesTextBox = new System.Windows.Forms.TextBox();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.OpenWordFile = new System.Windows.Forms.OpenFileDialog();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NamesListBox
            // 
            this.NamesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.NamesListBox.FormattingEnabled = true;
            this.NamesListBox.ItemHeight = 55;
            this.NamesListBox.Location = new System.Drawing.Point(81, 135);
            this.NamesListBox.Name = "NamesListBox";
            this.NamesListBox.Size = new System.Drawing.Size(622, 334);
            this.NamesListBox.TabIndex = 0;
            this.NamesListBox.SelectedIndexChanged += new System.EventHandler(this.NamesListBox_SelectedIndexChanged);
            // 
            // ShowNamesButton
            // 
            this.ShowNamesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ShowNamesButton.Location = new System.Drawing.Point(228, 481);
            this.ShowNamesButton.Name = "ShowNamesButton";
            this.ShowNamesButton.Size = new System.Drawing.Size(335, 160);
            this.ShowNamesButton.TabIndex = 1;
            this.ShowNamesButton.Text = "Show Names";
            this.ShowNamesButton.UseVisualStyleBackColor = true;
            this.ShowNamesButton.Click += new System.EventHandler(this.ShowNamesButton_Click);
            // 
            // ConvertNamesTextBox
            // 
            this.ConvertNamesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.ConvertNamesTextBox.Location = new System.Drawing.Point(803, 135);
            this.ConvertNamesTextBox.Multiline = true;
            this.ConvertNamesTextBox.Name = "ConvertNamesTextBox";
            this.ConvertNamesTextBox.Size = new System.Drawing.Size(622, 334);
            this.ConvertNamesTextBox.TabIndex = 2;
            // 
            // ConvertButton
            // 
            this.ConvertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ConvertButton.Location = new System.Drawing.Point(893, 481);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(335, 160);
            this.ConvertButton.TabIndex = 3;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // OpenWordFile
            // 
            this.OpenWordFile.FileName = "OpenWordFile";
            // 
            // TitleLabel
            // 
            this.TitleLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.TitleLabel.Location = new System.Drawing.Point(398, 26);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(767, 80);
            this.TitleLabel.TabIndex = 4;
            this.TitleLabel.Text = "Convert The Words!";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ClearButton.Location = new System.Drawing.Point(228, 705);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(335, 154);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ExitButton.Location = new System.Drawing.Point(893, 705);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(335, 154);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ConvertTheWords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1474, 929);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.ConvertNamesTextBox);
            this.Controls.Add(this.ShowNamesButton);
            this.Controls.Add(this.NamesListBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.Name = "ConvertTheWords";
            this.Text = "Convert The Words";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox NamesListBox;
        private System.Windows.Forms.Button ShowNamesButton;
        private System.Windows.Forms.TextBox ConvertNamesTextBox;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.OpenFileDialog OpenWordFile;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

