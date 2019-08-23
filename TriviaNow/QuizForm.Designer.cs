namespace TriviaNow
{
    partial class QuizForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizForm));
            this.questionTrackerLabel = new System.Windows.Forms.Label();
            this.questionTextLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.questionPanel = new System.Windows.Forms.Panel();
            this.feedbackDisplayLabel = new System.Windows.Forms.Label();
            this.answerFourRadioButton = new System.Windows.Forms.RadioButton();
            this.answerThreeRadioButton = new System.Windows.Forms.RadioButton();
            this.answerTwoRadioButton = new System.Windows.Forms.RadioButton();
            this.answerOneRadioButton = new System.Windows.Forms.RadioButton();
            this.submitButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.finalTotalLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.questionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // questionTrackerLabel
            // 
            this.questionTrackerLabel.AutoSize = true;
            this.questionTrackerLabel.BackColor = System.Drawing.Color.Thistle;
            this.questionTrackerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionTrackerLabel.Location = new System.Drawing.Point(12, 44);
            this.questionTrackerLabel.Name = "questionTrackerLabel";
            this.questionTrackerLabel.Size = new System.Drawing.Size(45, 20);
            this.questionTrackerLabel.TabIndex = 0;
            this.questionTrackerLabel.Text = "total";
            // 
            // questionTextLabel
            // 
            this.questionTextLabel.AutoSize = true;
            this.questionTextLabel.BackColor = System.Drawing.Color.White;
            this.questionTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionTextLabel.Location = new System.Drawing.Point(12, 83);
            this.questionTextLabel.MaximumSize = new System.Drawing.Size(600, 0);
            this.questionTextLabel.Name = "questionTextLabel";
            this.questionTextLabel.Size = new System.Drawing.Size(148, 29);
            this.questionTextLabel.TabIndex = 1;
            this.questionTextLabel.Text = "question text";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(704, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.quitToolStripMenuItem.Text = "&Quit";
            // 
            // questionPanel
            // 
            this.questionPanel.BackColor = System.Drawing.Color.Thistle;
            this.questionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.questionPanel.Controls.Add(this.feedbackDisplayLabel);
            this.questionPanel.Controls.Add(this.answerFourRadioButton);
            this.questionPanel.Controls.Add(this.answerThreeRadioButton);
            this.questionPanel.Controls.Add(this.answerTwoRadioButton);
            this.questionPanel.Controls.Add(this.answerOneRadioButton);
            this.questionPanel.Location = new System.Drawing.Point(16, 142);
            this.questionPanel.Name = "questionPanel";
            this.questionPanel.Size = new System.Drawing.Size(638, 230);
            this.questionPanel.TabIndex = 3;
            // 
            // feedbackDisplayLabel
            // 
            this.feedbackDisplayLabel.AutoSize = true;
            this.feedbackDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedbackDisplayLabel.Location = new System.Drawing.Point(15, 22);
            this.feedbackDisplayLabel.Name = "feedbackDisplayLabel";
            this.feedbackDisplayLabel.Size = new System.Drawing.Size(83, 20);
            this.feedbackDisplayLabel.TabIndex = 6;
            this.feedbackDisplayLabel.Text = "feedback";
            // 
            // answerFourRadioButton
            // 
            this.answerFourRadioButton.AutoSize = true;
            this.answerFourRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerFourRadioButton.Location = new System.Drawing.Point(19, 182);
            this.answerFourRadioButton.Name = "answerFourRadioButton";
            this.answerFourRadioButton.Size = new System.Drawing.Size(119, 24);
            this.answerFourRadioButton.TabIndex = 3;
            this.answerFourRadioButton.TabStop = true;
            this.answerFourRadioButton.Text = "radioButton4";
            this.answerFourRadioButton.UseVisualStyleBackColor = true;
            // 
            // answerThreeRadioButton
            // 
            this.answerThreeRadioButton.AutoSize = true;
            this.answerThreeRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerThreeRadioButton.Location = new System.Drawing.Point(19, 143);
            this.answerThreeRadioButton.Name = "answerThreeRadioButton";
            this.answerThreeRadioButton.Size = new System.Drawing.Size(119, 24);
            this.answerThreeRadioButton.TabIndex = 2;
            this.answerThreeRadioButton.TabStop = true;
            this.answerThreeRadioButton.Text = "radioButton3";
            this.answerThreeRadioButton.UseVisualStyleBackColor = true;
            // 
            // answerTwoRadioButton
            // 
            this.answerTwoRadioButton.AutoSize = true;
            this.answerTwoRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerTwoRadioButton.Location = new System.Drawing.Point(19, 102);
            this.answerTwoRadioButton.Name = "answerTwoRadioButton";
            this.answerTwoRadioButton.Size = new System.Drawing.Size(119, 24);
            this.answerTwoRadioButton.TabIndex = 1;
            this.answerTwoRadioButton.TabStop = true;
            this.answerTwoRadioButton.Text = "radioButton2";
            this.answerTwoRadioButton.UseVisualStyleBackColor = true;
            // 
            // answerOneRadioButton
            // 
            this.answerOneRadioButton.AutoSize = true;
            this.answerOneRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerOneRadioButton.Location = new System.Drawing.Point(19, 62);
            this.answerOneRadioButton.Name = "answerOneRadioButton";
            this.answerOneRadioButton.Size = new System.Drawing.Size(119, 24);
            this.answerOneRadioButton.TabIndex = 0;
            this.answerOneRadioButton.TabStop = true;
            this.answerOneRadioButton.Tag = "";
            this.answerOneRadioButton.Text = "radioButton1";
            this.answerOneRadioButton.UseVisualStyleBackColor = true;
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(467, 407);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(98, 44);
            this.submitButton.TabIndex = 4;
            this.submitButton.Text = "&Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(594, 407);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(98, 44);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "&Quit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // finalTotalLabel
            // 
            this.finalTotalLabel.AutoSize = true;
            this.finalTotalLabel.BackColor = System.Drawing.Color.White;
            this.finalTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalTotalLabel.Location = new System.Drawing.Point(356, 375);
            this.finalTotalLabel.Name = "finalTotalLabel";
            this.finalTotalLabel.Size = new System.Drawing.Size(60, 24);
            this.finalTotalLabel.TabIndex = 6;
            this.finalTotalLabel.Text = "label1";
            // 
            // QuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(704, 472);
            this.Controls.Add(this.finalTotalLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.questionPanel);
            this.Controls.Add(this.questionTextLabel);
            this.Controls.Add(this.questionTrackerLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QuizForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Harry Potter Quiz";
            this.Load += new System.EventHandler(this.QuizForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.questionPanel.ResumeLayout(false);
            this.questionPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionTrackerLabel;
        private System.Windows.Forms.Label questionTextLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Panel questionPanel;
        private System.Windows.Forms.Label feedbackDisplayLabel;
        private System.Windows.Forms.RadioButton answerFourRadioButton;
        private System.Windows.Forms.RadioButton answerThreeRadioButton;
        private System.Windows.Forms.RadioButton answerTwoRadioButton;
        private System.Windows.Forms.RadioButton answerOneRadioButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label finalTotalLabel;
    }
}