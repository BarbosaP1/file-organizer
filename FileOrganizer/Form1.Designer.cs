namespace FileOrganizer
{
    partial class FileOrganizerMainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileOrganizerMainWindow));
            OrganizeButton = new Button();
            MainMenuTitleLabel = new Label();
            GithubButton = new Button();
            CreditsLabel = new Label();
            SelectedFolderLabel = new Label();
            SelectFolderButton = new Button();
            ResetButton = new Button();
            FileOrganizerIcon = new PictureBox();
            AboutButton = new Button();
            AboutLabel = new Label();
            LabelDesc = new Label();
            LinkLabelGithubRepo = new LinkLabel();
            GithubRepoLabel = new Label();
            GlobalHelpLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)FileOrganizerIcon).BeginInit();
            SuspendLayout();
            // 
            // OrganizeButton
            // 
            OrganizeButton.Cursor = Cursors.Hand;
            OrganizeButton.Location = new Point(134, 368);
            OrganizeButton.Name = "OrganizeButton";
            OrganizeButton.Size = new Size(255, 70);
            OrganizeButton.TabIndex = 0;
            OrganizeButton.Text = "Organize";
            OrganizeButton.UseVisualStyleBackColor = true;
            OrganizeButton.Click += OrganizeButton_Click;
            OrganizeButton.MouseEnter += GlobalMouseEnter;
            OrganizeButton.MouseLeave += GlobalMouseLeave;
            // 
            // MainMenuTitleLabel
            // 
            MainMenuTitleLabel.AutoSize = true;
            MainMenuTitleLabel.Font = new Font("Yu Gothic", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuTitleLabel.Location = new Point(156, 91);
            MainMenuTitleLabel.Name = "MainMenuTitleLabel";
            MainMenuTitleLabel.Size = new Size(245, 45);
            MainMenuTitleLabel.TabIndex = 1;
            MainMenuTitleLabel.Text = "File Organizer";
            MainMenuTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GithubButton
            // 
            GithubButton.BackgroundImage = (Image)resources.GetObject("GithubButton.BackgroundImage");
            GithubButton.BackgroundImageLayout = ImageLayout.Zoom;
            GithubButton.Cursor = Cursors.Hand;
            GithubButton.Location = new Point(440, 368);
            GithubButton.Name = "GithubButton";
            GithubButton.Size = new Size(73, 70);
            GithubButton.TabIndex = 3;
            GithubButton.TextAlign = ContentAlignment.BottomCenter;
            GithubButton.UseVisualStyleBackColor = true;
            GithubButton.Click += GithubButton_Click;
            GithubButton.MouseEnter += GlobalMouseEnter;
            GithubButton.MouseLeave += GlobalMouseLeave;
            // 
            // CreditsLabel
            // 
            CreditsLabel.AutoSize = true;
            CreditsLabel.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CreditsLabel.Location = new Point(163, 136);
            CreditsLabel.Name = "CreditsLabel";
            CreditsLabel.Size = new Size(115, 21);
            CreditsLabel.TabIndex = 4;
            CreditsLabel.Text = "By BarbosaP1";
            CreditsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SelectedFolderLabel
            // 
            SelectedFolderLabel.AutoSize = true;
            SelectedFolderLabel.Location = new Point(186, 340);
            SelectedFolderLabel.Name = "SelectedFolderLabel";
            SelectedFolderLabel.Size = new Size(152, 15);
            SelectedFolderLabel.TabIndex = 5;
            SelectedFolderLabel.Text = "Select a folder to organize...";
            // 
            // SelectFolderButton
            // 
            SelectFolderButton.BackColor = Color.Transparent;
            SelectFolderButton.Cursor = Cursors.Hand;
            SelectFolderButton.ForeColor = SystemColors.ActiveCaptionText;
            SelectFolderButton.Location = new Point(183, 276);
            SelectFolderButton.Name = "SelectFolderButton";
            SelectFolderButton.Size = new Size(90, 37);
            SelectFolderButton.TabIndex = 6;
            SelectFolderButton.Text = "Select Folder";
            SelectFolderButton.UseVisualStyleBackColor = false;
            SelectFolderButton.Click += SelectFolderButton_Click;
            SelectFolderButton.MouseEnter += GlobalMouseEnter;
            SelectFolderButton.MouseLeave += GlobalMouseLeave;
            // 
            // ResetButton
            // 
            ResetButton.Cursor = Cursors.Hand;
            ResetButton.Location = new Point(279, 276);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(57, 37);
            ResetButton.TabIndex = 7;
            ResetButton.Text = "Reset";
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.Click += ResetButton_Click;
            ResetButton.MouseEnter += GlobalMouseEnter;
            ResetButton.MouseLeave += GlobalMouseLeave;
            // 
            // FileOrganizerIcon
            // 
            FileOrganizerIcon.Image = (Image)resources.GetObject("FileOrganizerIcon.Image");
            FileOrganizerIcon.Location = new Point(82, 73);
            FileOrganizerIcon.Name = "FileOrganizerIcon";
            FileOrganizerIcon.Size = new Size(100, 103);
            FileOrganizerIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            FileOrganizerIcon.TabIndex = 8;
            FileOrganizerIcon.TabStop = false;
            // 
            // AboutButton
            // 
            AboutButton.BackgroundImage = (Image)resources.GetObject("AboutButton.BackgroundImage");
            AboutButton.BackgroundImageLayout = ImageLayout.Zoom;
            AboutButton.Cursor = Cursors.Hand;
            AboutButton.Location = new Point(12, 368);
            AboutButton.Name = "AboutButton";
            AboutButton.Size = new Size(73, 70);
            AboutButton.TabIndex = 9;
            AboutButton.TextAlign = ContentAlignment.BottomCenter;
            AboutButton.UseVisualStyleBackColor = true;
            AboutButton.Click += AboutButton_Click;
            AboutButton.MouseEnter += GlobalMouseEnter;
            AboutButton.MouseLeave += GlobalMouseLeave;
            // 
            // AboutLabel
            // 
            AboutLabel.AutoSize = true;
            AboutLabel.Font = new Font("Yu Gothic", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AboutLabel.Location = new Point(200, 9);
            AboutLabel.Name = "AboutLabel";
            AboutLabel.Size = new Size(115, 45);
            AboutLabel.TabIndex = 10;
            AboutLabel.Text = "About";
            AboutLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LabelDesc
            // 
            LabelDesc.AutoSize = true;
            LabelDesc.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelDesc.Location = new Point(5, 73);
            LabelDesc.Name = "LabelDesc";
            LabelDesc.Size = new Size(515, 160);
            LabelDesc.TabIndex = 11;
            LabelDesc.Text = resources.GetString("LabelDesc.Text");
            LabelDesc.TextAlign = ContentAlignment.TopCenter;
            // 
            // LinkLabelGithubRepo
            // 
            LinkLabelGithubRepo.AutoSize = true;
            LinkLabelGithubRepo.Cursor = Cursors.Hand;
            LinkLabelGithubRepo.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LinkLabelGithubRepo.Location = new Point(285, 428);
            LinkLabelGithubRepo.Name = "LinkLabelGithubRepo";
            LinkLabelGithubRepo.Size = new Size(235, 13);
            LinkLabelGithubRepo.TabIndex = 12;
            LinkLabelGithubRepo.TabStop = true;
            LinkLabelGithubRepo.Text = "https://github.com/BarbosaP1/file-organizer";
            LinkLabelGithubRepo.LinkClicked += LinkLabelGithubRepo_LinkClicked;
            // 
            // GithubRepoLabel
            // 
            GithubRepoLabel.AutoSize = true;
            GithubRepoLabel.Location = new Point(352, 407);
            GithubRepoLabel.Name = "GithubRepoLabel";
            GithubRepoLabel.Size = new Size(102, 15);
            GithubRepoLabel.TabIndex = 13;
            GithubRepoLabel.Text = "Github Repository";
            // 
            // GlobalHelpLabel
            // 
            GlobalHelpLabel.AutoSize = true;
            GlobalHelpLabel.BorderStyle = BorderStyle.FixedSingle;
            GlobalHelpLabel.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GlobalHelpLabel.Location = new Point(436, 333);
            GlobalHelpLabel.Name = "GlobalHelpLabel";
            GlobalHelpLabel.Size = new Size(81, 28);
            GlobalHelpLabel.TabIndex = 14;
            GlobalHelpLabel.Text = "Barbosa's \r\nGithub Profile";
            GlobalHelpLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FileOrganizerMainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(525, 450);
            Controls.Add(LabelDesc);
            Controls.Add(MainMenuTitleLabel);
            Controls.Add(GlobalHelpLabel);
            Controls.Add(GithubRepoLabel);
            Controls.Add(LinkLabelGithubRepo);
            Controls.Add(AboutLabel);
            Controls.Add(AboutButton);
            Controls.Add(ResetButton);
            Controls.Add(SelectFolderButton);
            Controls.Add(SelectedFolderLabel);
            Controls.Add(GithubButton);
            Controls.Add(OrganizeButton);
            Controls.Add(CreditsLabel);
            Controls.Add(FileOrganizerIcon);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FileOrganizerMainWindow";
            Text = "File Organizer";
            Load += MainWindow_Load;
            ((System.ComponentModel.ISupportInitialize)FileOrganizerIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button OrganizeButton;
        private Label MainMenuTitleLabel;
        private Button GithubButton;
        private Label CreditsLabel;
        private Label SelectedFolderLabel;
        private Button SelectFolderButton;
        private Button ResetButton;
        private PictureBox FileOrganizerIcon;
        private Button AboutButton;
        private Label AboutLabel;
        private Label LabelDesc;
        private LinkLabel LinkLabelGithubRepo;
        private Label GithubRepoLabel;
        private Label GlobalHelpLabel;
    }
}
