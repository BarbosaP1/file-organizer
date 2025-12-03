using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace FileOrganizer
{
    public partial class FileOrganizerMainWindow : Form
    {

        [DllImport("kernel32.dll")]
        static extern bool AllocConsole();
        public FileOrganizerMainWindow()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            SetInterfaceState(true, InterfaceState.MainMenu);
        }

        public enum InterfaceState
        {
            MainMenu,
            AboutMenu
        }

        public static InterfaceState currentState = InterfaceState.MainMenu;
        public void SetInterfaceState(bool updateObjects, InterfaceState state)
        {
            if (state == InterfaceState.MainMenu)
            {
                currentState = InterfaceState.MainMenu;
                if (updateObjects)
                {
                    FileOrganizerIcon.Visible = true;
                    MainMenuTitleLabel.Visible = true;
                    CreditsLabel.Visible = true;
                    SelectFolderButton.Visible = true;
                    ResetButton.Visible = true;
                    SelectedFolderLabel.Visible = true;
                    OrganizeButton.Visible = true;
                    GithubButton.Left = 440; GithubButton.Top = 368;
                    AboutLabel.Visible = false;
                    LabelDesc.Visible = false;
                    LinkLabelGithubRepo.Visible = false;
                    GithubRepoLabel.Visible = false;
                    GlobalHelpLabel.Visible = false;
                }
            }
            else if (state == InterfaceState.AboutMenu)
            {
                currentState = InterfaceState.AboutMenu;
                if (updateObjects)
                {
                    FileOrganizerIcon.Visible = false;
                    MainMenuTitleLabel.Visible = false;
                    CreditsLabel.Visible = false;
                    SelectFolderButton.Visible = false;
                    ResetButton.Visible = false;
                    SelectedFolderLabel.Visible = false;
                    OrganizeButton.Visible = false;
                    GithubButton.Left = 12; GithubButton.Top = 285;
                    AboutLabel.Visible = true;
                    LabelDesc.Visible = true;
                    LinkLabelGithubRepo.Visible = true;
                    GithubRepoLabel.Visible = true;
                }
            }

        }
        private void AboutButton_Click(object sender, EventArgs e)
        {
            if (currentState == InterfaceState.MainMenu)
                SetInterfaceState(true, InterfaceState.AboutMenu);

            else if (currentState == InterfaceState.AboutMenu)
                SetInterfaceState(true, InterfaceState.MainMenu);
        }
        private void OrganizeButton_Click(object sender, EventArgs e)
        {
            Console.Out.WriteLine("Organize Button Clicked");
            if (selectedFolder == "Insert Folder Location..." || selectedFolder == null)
                MessageBox.Show("You must enter a folder location to organize your files!", "File Organizer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!selectedFolder.Contains(@"\") || !Directory.Exists(selectedFolder))
            {
                MessageBox.Show("You must enter a valid folder location to organize your files!", "File Organizer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                OrganizationLogic.OrganizeFilesInFolder(selectedFolder);
            }
        }
        internal class FileTypes
        {
            public static string[] picturesExtensions =
            [
                ".jpg", "jpeg", ".png",".gif", ".bmp", ".tiff", ".svg", ".webp", ".ico"
            ];
            public static string[] documentsExtensions =
            [
                ".pdf", ".docx", ".txt", ".xls", ".pptx", ".odt", ".csv"
            ];
            public static string[] audiosExtensions =
            [
                ".mp3", ".wav", ".flac", ".ogg", ".aac"
            ];
            public static string[] videosExtensions =
            [
                ".mp4", ".mkv", ".mov", ".avi", ".wmv"
            ];
            public static string[] compressionsExtensions =
            [
                ".zip", ".rar", ".7z", ".tar", ".gz"
            ];
            public static string[] applicationsExtensions =
            [
                ".exe", ".msi", ".apk", ".bat", ".cmd", ".jar", ".xapk"
            ];
            public static string[] codingExtensions =
            [
                ".cs", ".js", ".ts", ".java", ".py", ".cpp", ".json", ".xml", ".html", ".css"
            ];
            public static string[] projectsExtensions =
            [
                ".psd", ".ai", ".xd", ".fig", ".xcf", ".blend", ".prproj"
            ];
            public static string[] gamingExtensions =
            [
                ".iso", ".bin", ".cue", ".rom", ".nes", ".sfc", ".gba", ".n64"
            ];
            public static string[] fontExtensions = 
            { 
                ".ttf", ".otf", ".ttc", ".otc", ".woff", ".woff2", ".eot", ".svg", ".fnt", ".bdf", ".pfb", ".pfm" 
            };
        }

        internal class OrganizationLogic
        {
            private static string GetFolderByExtension(string fileName)
            {
                foreach (var extension in FileTypes.documentsExtensions)
                {
                    if (fileName.EndsWith(extension))
                    {
                        return "Documents";
                    }
                }
                foreach (var extension in FileTypes.picturesExtensions)
                {
                    if (fileName.EndsWith(extension))
                    {
                        return "Pictures";
                    }
                }
                foreach (var extension in FileTypes.audiosExtensions)
                {
                    if (fileName.EndsWith(extension))
                    {
                        return "Audios";
                    }
                }
                foreach (var extension in FileTypes.videosExtensions)
                {
                    if (fileName.EndsWith(extension))
                    {
                        return "Videos";
                    }
                }
                foreach (var extension in FileTypes.compressionsExtensions)
                {
                    if (fileName.EndsWith(extension))
                    {
                        return "Compressed Files";
                    }
                }
                foreach (var extension in FileTypes.applicationsExtensions)
                {
                    if (fileName.EndsWith(extension))
                    {
                        return "Applications";
                    }
                }
                foreach (var extension in FileTypes.codingExtensions)
                {
                    if (fileName.EndsWith(extension))
                    {
                        return "Coding Files";
                    }
                }
                foreach (var extension in FileTypes.projectsExtensions)
                {
                    if (fileName.EndsWith(extension))
                    {
                        return "Projects";
                    }
                }
                foreach (var extension in FileTypes.gamingExtensions)
                {
                    if (fileName.EndsWith(extension))
                    {
                        return "Games";
                    }
                }
                foreach (var extension in FileTypes.fontExtensions)
                {
                    if (fileName.EndsWith(extension))
                    {
                        return "Fonts";
                    }
                }
                return "Miscellaneous";
            }
            public static void OrganizeFilesInFolder(string folderLocation)
            {
                Directory.GetFiles(folderLocation);
                string[] files = Directory.GetFiles(folderLocation);

                foreach (string file in files)
                {
                    string folder = GetFolderByExtension(file);
                    Console.Out.WriteLine(folder);
                    if (!Directory.Exists(folderLocation + folder))
                    {
                        Directory.CreateDirectory(folderLocation + @"\" + folder);
                    }
                    try
                    {
                        File.Move(file, folderLocation + @"\" + folder + @"\" + Path.GetFileName(file), false);
                    }
                    catch (IOException ex)
                    {
                        Console.WriteLine("Error moving file: " + ex.Message);
                    }

                }
                MessageBox.Show("Files have been organized successfully!", "File Organizer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void FolderLocationTextBox_Enter(object sender, EventArgs e)
        {
            if (selectedFolder == "Insert Folder Location...")
                selectedFolder = "";
        }

        private void FolderLocationTextBox_Leave(object sender, EventArgs e)
        {
            if (selectedFolder == null)
                selectedFolder = "Insert Folder Location...";
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            if (Debugger.IsAttached || Properties.Settings.Default.DeveloperMode)
            {
                AllocConsole();
            }
            Console.WriteLine("Console Enabled");
        }
        public bool hasAgreedToOpenBrowser = false;
        private void GithubButton_Click(object sender, EventArgs e)
        {
            if (!hasAgreedToOpenBrowser)
            {
                var result = MessageBox.Show("If you continue, your browser will open. Proceed?", "File Organizer", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    hasAgreedToOpenBrowser = true;
                    OpenWebsite("https://github.com/BarbosaP1");
                }
            }
            else
            {
                OpenWebsite("https://github.com/BarbosaP1");
            }
        }
        public static void OpenWebsite(string url)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }
        string selectedFolder = "";
        private void SelectFolderButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                dialog.Description = "Select a folder";
                dialog.UseDescriptionForTitle = true;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    selectedFolder = dialog.SelectedPath;
                    Console.WriteLine("Selected folder: " + selectedFolder);
                    SelectedFolderLabel.Text = "Selected Folder: " + selectedFolder;
                    SelectedFolderLabel.Left = (this.ClientSize.Width - SelectedFolderLabel.Width) / 2;
                }
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            selectedFolder = string.Empty;
            SelectedFolderLabel.Text = "Select a folder to organize...";
            SelectedFolderLabel.Left = (this.ClientSize.Width - SelectedFolderLabel.Width) / 2;
        }

        private void GlobalMouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = System.Drawing.Color.LightGray;

            if (btn.Name == "GithubButton")
                ControlHelpLabels(true, "Github");
            else if (btn.Name == "AboutButton")
                ControlHelpLabels(true, "About");
        }
        private void GlobalMouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = System.Drawing.Color.Transparent;

            if (btn.Name == "GithubButton")
                ControlHelpLabels(false, "Github");
            else if (btn.Name == "AboutButton")
                ControlHelpLabels(false, "About");
        }
        private void ControlHelpLabels(bool visible, string button)
        {
            GlobalHelpLabel.Visible = visible;
            if (button == "Github")
            {
                GlobalHelpLabel.Left = GithubButton.Left - 4; GlobalHelpLabel.Top = GithubButton.Top - 35;
                GlobalHelpLabel.Text = "Barbosa's \r\nGithub Profile";
            }
            if (button == "About")
            {
                GlobalHelpLabel.Left = AboutButton.Left + 15; GlobalHelpLabel.Top = AboutButton.Top - 20;
                GlobalHelpLabel.Text = "About";
            }
        }

        private void GithubButton_MouseEnter(object sender, EventArgs e)
        {
            GithubButton.BackColor = System.Drawing.Color.LightGray;
        }

        private void GithubButton_MouseLeave(object sender, EventArgs e)
        {
            GithubButton.BackColor = System.Drawing.Color.Transparent;
        }

        private void LinkLabelGithubRepo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenWebsite("https://github.com/BarbosaP1/file-organizer");
        }
    }
}
