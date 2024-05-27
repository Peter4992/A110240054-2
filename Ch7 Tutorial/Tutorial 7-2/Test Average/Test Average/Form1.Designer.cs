namespace Test_Average
{
    partial class Form1
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
            this.averageScoreDescriptionLabel = new System.Windows.Forms.Label();
            this.lowScoreDescriptionLabel = new System.Windows.Forms.Label();
            this.highScoreDescriptionLabel = new System.Windows.Forms.Label();
            this.testScoresListBox = new System.Windows.Forms.ListBox();
            this.testScoresDescriptionLabel = new System.Windows.Forms.Label();
            this.highScoreLabel = new System.Windows.Forms.Label();
            this.lowScoreLabel = new System.Windows.Forms.Label();
            this.averageScoreLabel = new System.Windows.Forms.Label();
            this.getScoresButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.medianScoreLabel = new System.Windows.Forms.Label();
            this.medianScoreDescriptionLabel = new System.Windows.Forms.Label();
            this.sortedScoresListBox = new System.Windows.Forms.ListBox();
            this.sortedScoresDescriptionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // averageScoreDescriptionLabel
            // 
            this.averageScoreDescriptionLabel.AutoSize = true;
            this.averageScoreDescriptionLabel.Location = new System.Drawing.Point(464, 171);
            this.averageScoreDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.averageScoreDescriptionLabel.Name = "averageScoreDescriptionLabel";
            this.averageScoreDescriptionLabel.Size = new System.Drawing.Size(110, 18);
            this.averageScoreDescriptionLabel.TabIndex = 9;
            this.averageScoreDescriptionLabel.Text = "Average Score";
            // 
            // lowScoreDescriptionLabel
            // 
            this.lowScoreDescriptionLabel.AutoSize = true;
            this.lowScoreDescriptionLabel.Location = new System.Drawing.Point(468, 121);
            this.lowScoreDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lowScoreDescriptionLabel.Name = "lowScoreDescriptionLabel";
            this.lowScoreDescriptionLabel.Size = new System.Drawing.Size(102, 18);
            this.lowScoreDescriptionLabel.TabIndex = 8;
            this.lowScoreDescriptionLabel.Text = "Lowest Score";
            // 
            // highScoreDescriptionLabel
            // 
            this.highScoreDescriptionLabel.AutoSize = true;
            this.highScoreDescriptionLabel.Location = new System.Drawing.Point(467, 72);
            this.highScoreDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.highScoreDescriptionLabel.Name = "highScoreDescriptionLabel";
            this.highScoreDescriptionLabel.Size = new System.Drawing.Size(105, 18);
            this.highScoreDescriptionLabel.TabIndex = 7;
            this.highScoreDescriptionLabel.Text = "Highest Score";
            // 
            // testScoresListBox
            // 
            this.testScoresListBox.FormattingEnabled = true;
            this.testScoresListBox.ItemHeight = 18;
            this.testScoresListBox.Location = new System.Drawing.Point(18, 40);
            this.testScoresListBox.Margin = new System.Windows.Forms.Padding(4);
            this.testScoresListBox.Name = "testScoresListBox";
            this.testScoresListBox.Size = new System.Drawing.Size(178, 292);
            this.testScoresListBox.TabIndex = 6;
            // 
            // testScoresDescriptionLabel
            // 
            this.testScoresDescriptionLabel.AutoSize = true;
            this.testScoresDescriptionLabel.Location = new System.Drawing.Point(18, 18);
            this.testScoresDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.testScoresDescriptionLabel.Name = "testScoresDescriptionLabel";
            this.testScoresDescriptionLabel.Size = new System.Drawing.Size(89, 18);
            this.testScoresDescriptionLabel.TabIndex = 5;
            this.testScoresDescriptionLabel.Text = "Test Scores";
            // 
            // highScoreLabel
            // 
            this.highScoreLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.highScoreLabel.Location = new System.Drawing.Point(585, 64);
            this.highScoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.highScoreLabel.Name = "highScoreLabel";
            this.highScoreLabel.Size = new System.Drawing.Size(149, 31);
            this.highScoreLabel.TabIndex = 10;
            this.highScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lowScoreLabel
            // 
            this.lowScoreLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lowScoreLabel.Location = new System.Drawing.Point(585, 114);
            this.lowScoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lowScoreLabel.Name = "lowScoreLabel";
            this.lowScoreLabel.Size = new System.Drawing.Size(149, 31);
            this.lowScoreLabel.TabIndex = 11;
            this.lowScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // averageScoreLabel
            // 
            this.averageScoreLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.averageScoreLabel.Location = new System.Drawing.Point(585, 164);
            this.averageScoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.averageScoreLabel.Name = "averageScoreLabel";
            this.averageScoreLabel.Size = new System.Drawing.Size(149, 31);
            this.averageScoreLabel.TabIndex = 12;
            this.averageScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // getScoresButton
            // 
            this.getScoresButton.Location = new System.Drawing.Point(467, 298);
            this.getScoresButton.Margin = new System.Windows.Forms.Padding(4);
            this.getScoresButton.Name = "getScoresButton";
            this.getScoresButton.Size = new System.Drawing.Size(112, 32);
            this.getScoresButton.TabIndex = 13;
            this.getScoresButton.Text = "Get Scores";
            this.getScoresButton.UseVisualStyleBackColor = true;
            this.getScoresButton.Click += new System.EventHandler(this.getScoresButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(628, 298);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(112, 32);
            this.exitButton.TabIndex = 14;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // medianScoreLabel
            // 
            this.medianScoreLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.medianScoreLabel.Location = new System.Drawing.Point(586, 217);
            this.medianScoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.medianScoreLabel.Name = "medianScoreLabel";
            this.medianScoreLabel.Size = new System.Drawing.Size(149, 31);
            this.medianScoreLabel.TabIndex = 16;
            this.medianScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // medianScoreDescriptionLabel
            // 
            this.medianScoreDescriptionLabel.AutoSize = true;
            this.medianScoreDescriptionLabel.Location = new System.Drawing.Point(464, 224);
            this.medianScoreDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.medianScoreDescriptionLabel.Name = "medianScoreDescriptionLabel";
            this.medianScoreDescriptionLabel.Size = new System.Drawing.Size(104, 18);
            this.medianScoreDescriptionLabel.TabIndex = 15;
            this.medianScoreDescriptionLabel.Text = "Median Score";
            // 
            // sortedScoresListBox
            // 
            this.sortedScoresListBox.FormattingEnabled = true;
            this.sortedScoresListBox.ItemHeight = 18;
            this.sortedScoresListBox.Location = new System.Drawing.Point(242, 40);
            this.sortedScoresListBox.Margin = new System.Windows.Forms.Padding(4);
            this.sortedScoresListBox.Name = "sortedScoresListBox";
            this.sortedScoresListBox.Size = new System.Drawing.Size(175, 292);
            this.sortedScoresListBox.TabIndex = 18;
            // 
            // sortedScoresDescriptionLabel
            // 
            this.sortedScoresDescriptionLabel.AutoSize = true;
            this.sortedScoresDescriptionLabel.Location = new System.Drawing.Point(242, 18);
            this.sortedScoresDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sortedScoresDescriptionLabel.Name = "sortedScoresDescriptionLabel";
            this.sortedScoresDescriptionLabel.Size = new System.Drawing.Size(103, 18);
            this.sortedScoresDescriptionLabel.TabIndex = 17;
            this.sortedScoresDescriptionLabel.Text = "Sorted Scores";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 366);
            this.Controls.Add(this.sortedScoresListBox);
            this.Controls.Add(this.sortedScoresDescriptionLabel);
            this.Controls.Add(this.medianScoreLabel);
            this.Controls.Add(this.medianScoreDescriptionLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.getScoresButton);
            this.Controls.Add(this.averageScoreLabel);
            this.Controls.Add(this.lowScoreLabel);
            this.Controls.Add(this.highScoreLabel);
            this.Controls.Add(this.averageScoreDescriptionLabel);
            this.Controls.Add(this.lowScoreDescriptionLabel);
            this.Controls.Add(this.highScoreDescriptionLabel);
            this.Controls.Add(this.testScoresListBox);
            this.Controls.Add(this.testScoresDescriptionLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Test Average";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label averageScoreDescriptionLabel;
        private System.Windows.Forms.Label lowScoreDescriptionLabel;
        private System.Windows.Forms.Label highScoreDescriptionLabel;
        private System.Windows.Forms.ListBox testScoresListBox;
        private System.Windows.Forms.Label testScoresDescriptionLabel;
        private System.Windows.Forms.Label highScoreLabel;
        private System.Windows.Forms.Label lowScoreLabel;
        private System.Windows.Forms.Label averageScoreLabel;
        private System.Windows.Forms.Button getScoresButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Label medianScoreLabel;
        private System.Windows.Forms.Label medianScoreDescriptionLabel;
        private System.Windows.Forms.ListBox sortedScoresListBox;
        private System.Windows.Forms.Label sortedScoresDescriptionLabel;
    }
}

