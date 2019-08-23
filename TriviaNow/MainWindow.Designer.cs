namespace TriviaNow
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.questionListBox = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.viewSaveButton = new System.Windows.Forms.Button();
            this.detailsButton = new System.Windows.Forms.Button();
            this.questionDLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.playGameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(704, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.editToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.editToolStripMenuItem.Text = "&Edit Questions";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // playGameToolStripMenuItem
            // 
            this.playGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem});
            this.playGameToolStripMenuItem.Name = "playGameToolStripMenuItem";
            this.playGameToolStripMenuItem.Size = new System.Drawing.Size(75, 22);
            this.playGameToolStripMenuItem.Text = "Play &Game";
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.playToolStripMenuItem.Text = "&Play";
            // 
            // questionListBox
            // 
            this.questionListBox.BackColor = System.Drawing.Color.Thistle;
            this.questionListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionListBox.FormattingEnabled = true;
            this.questionListBox.HorizontalScrollbar = true;
            this.questionListBox.ItemHeight = 20;
            this.questionListBox.Location = new System.Drawing.Point(11, 107);
            this.questionListBox.Margin = new System.Windows.Forms.Padding(2);
            this.questionListBox.Name = "questionListBox";
            this.questionListBox.Size = new System.Drawing.Size(489, 284);
            this.questionListBox.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(520, 175);
            this.addButton.Margin = new System.Windows.Forms.Padding(2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(118, 50);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "&Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.Location = new System.Drawing.Point(520, 246);
            this.editButton.Margin = new System.Windows.Forms.Padding(2);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(118, 50);
            this.editButton.TabIndex = 3;
            this.editButton.Text = "&Edit";
            this.editButton.UseVisualStyleBackColor = false;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(520, 314);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(118, 50);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "&Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(393, 408);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(107, 52);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "&Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // viewSaveButton
            // 
            this.viewSaveButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.viewSaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewSaveButton.Location = new System.Drawing.Point(271, 408);
            this.viewSaveButton.Margin = new System.Windows.Forms.Padding(2);
            this.viewSaveButton.Name = "viewSaveButton";
            this.viewSaveButton.Size = new System.Drawing.Size(107, 52);
            this.viewSaveButton.TabIndex = 6;
            this.viewSaveButton.Text = "&Save";
            this.viewSaveButton.UseVisualStyleBackColor = false;
            this.viewSaveButton.Click += new System.EventHandler(this.mainSaveButton_Click);
            // 
            // detailsButton
            // 
            this.detailsButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.detailsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailsButton.Location = new System.Drawing.Point(520, 107);
            this.detailsButton.Margin = new System.Windows.Forms.Padding(2);
            this.detailsButton.Name = "detailsButton";
            this.detailsButton.Size = new System.Drawing.Size(118, 50);
            this.detailsButton.TabIndex = 7;
            this.detailsButton.Text = "&View";
            this.detailsButton.UseVisualStyleBackColor = false;
            this.detailsButton.Click += new System.EventHandler(this.detailsButton_Click);
            // 
            // questionDLabel
            // 
            this.questionDLabel.AutoSize = true;
            this.questionDLabel.BackColor = System.Drawing.Color.White;
            this.questionDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionDLabel.Location = new System.Drawing.Point(7, 81);
            this.questionDLabel.Name = "questionDLabel";
            this.questionDLabel.Size = new System.Drawing.Size(100, 24);
            this.questionDLabel.TabIndex = 8;
            this.questionDLabel.Text = "Questions:";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.BackColor = System.Drawing.Color.White;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(157, 253);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(81, 20);
            this.errorLabel.TabIndex = 9;
            this.errorLabel.Text = "errorLabel";
            this.errorLabel.Visible = false;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(11, 52);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(489, 26);
            this.searchTextBox.TabIndex = 10;
            this.searchTextBox.Text = "Enter Text You Would Like to Search for Here";
            this.searchTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.searchTextBox_MouseClick);
            this.searchTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchTextBox_KeyUp);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.searchButton.Location = new System.Drawing.Point(520, 52);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(118, 26);
            this.searchButton.TabIndex = 11;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(704, 472);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.questionDLabel);
            this.Controls.Add(this.detailsButton);
            this.Controls.Add(this.viewSaveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.questionListBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Harry Potter Quiz";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.mainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ListBox questionListBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button viewSaveButton;
        private System.Windows.Forms.Button detailsButton;
        private System.Windows.Forms.Label questionDLabel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
    }
}

