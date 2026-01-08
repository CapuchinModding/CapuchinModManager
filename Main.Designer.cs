namespace CapuchinModManager
{
    partial class Main
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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "Mod Name", "Author" }, -1);
            mainStatusReporter = new StatusStrip();
            taskLabel = new ToolStripStatusLabel();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            taskProgress = new ToolStripProgressBar();
            modsList = new ListView();
            modListName = new ColumnHeader();
            modListDeveloper = new ColumnHeader();
            installButton = new Button();
            mainStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            installToolStripMenuItem = new ToolStripMenuItem();
            fromRepositoryToolStripMenuItem = new ToolStripMenuItem();
            fromComputerToolStripMenuItem = new ToolStripMenuItem();
            refreshListToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            quitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            capuchinModdingCommunityToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            aboutCapuchinModManagerToolStripMenuItem = new ToolStripMenuItem();
            gitRepositoryToolStripMenuItem = new ToolStripMenuItem();
            modListVersion = new ColumnHeader();
            mainStatusReporter.SuspendLayout();
            mainStrip.SuspendLayout();
            SuspendLayout();
            // 
            // mainStatusReporter
            // 
            mainStatusReporter.Items.AddRange(new ToolStripItem[] { taskLabel, toolStripStatusLabel1, taskProgress });
            mainStatusReporter.Location = new Point(0, 458);
            mainStatusReporter.Name = "mainStatusReporter";
            mainStatusReporter.RightToLeft = RightToLeft.No;
            mainStatusReporter.Size = new Size(692, 22);
            mainStatusReporter.TabIndex = 0;
            mainStatusReporter.Text = "statusStrip1";
            // 
            // taskLabel
            // 
            taskLabel.Name = "taskLabel";
            taskLabel.Size = new Size(143, 17);
            taskLabel.Text = "Updating mod definitions";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(13, 17);
            toolStripStatusLabel1.Text = "  ";
            // 
            // taskProgress
            // 
            taskProgress.Name = "taskProgress";
            taskProgress.Size = new Size(200, 16);
            // 
            // modsList
            // 
            modsList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            modsList.CheckBoxes = true;
            modsList.Columns.AddRange(new ColumnHeader[] { modListName, modListDeveloper, modListVersion });
            modsList.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listViewItem1.StateImageIndex = 0;
            modsList.Items.AddRange(new ListViewItem[] { listViewItem1 });
            modsList.Location = new Point(10, 24);
            modsList.Name = "modsList";
            modsList.Size = new Size(672, 398);
            modsList.TabIndex = 1;
            modsList.UseCompatibleStateImageBehavior = false;
            modsList.View = View.Details;
            // 
            // modListName
            // 
            modListName.Text = "Mod";
            modListName.Width = 300;
            // 
            // modListDeveloper
            // 
            modListDeveloper.Text = "Developer";
            modListDeveloper.Width = 200;
            // 
            // installButton
            // 
            installButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            installButton.Location = new Point(588, 429);
            installButton.Name = "installButton";
            installButton.Size = new Size(94, 24);
            installButton.TabIndex = 0;
            installButton.Text = "Install";
            installButton.UseVisualStyleBackColor = true;
            // 
            // mainStrip
            // 
            mainStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            mainStrip.Location = new Point(0, 0);
            mainStrip.Name = "mainStrip";
            mainStrip.Size = new Size(692, 24);
            mainStrip.TabIndex = 2;
            mainStrip.Text = "Main Strip";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { installToolStripMenuItem, refreshListToolStripMenuItem, toolStripSeparator1, quitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(49, 20);
            fileToolStripMenuItem.Text = "Mods";
            // 
            // installToolStripMenuItem
            // 
            installToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fromRepositoryToolStripMenuItem, fromComputerToolStripMenuItem });
            installToolStripMenuItem.Name = "installToolStripMenuItem";
            installToolStripMenuItem.Size = new Size(180, 22);
            installToolStripMenuItem.Text = "Install";
            // 
            // fromRepositoryToolStripMenuItem
            // 
            fromRepositoryToolStripMenuItem.Name = "fromRepositoryToolStripMenuItem";
            fromRepositoryToolStripMenuItem.Size = new Size(161, 22);
            fromRepositoryToolStripMenuItem.Text = "From Repository";
            // 
            // fromComputerToolStripMenuItem
            // 
            fromComputerToolStripMenuItem.Name = "fromComputerToolStripMenuItem";
            fromComputerToolStripMenuItem.Size = new Size(161, 22);
            fromComputerToolStripMenuItem.Text = "From Computer";
            // 
            // refreshListToolStripMenuItem
            // 
            refreshListToolStripMenuItem.Name = "refreshListToolStripMenuItem";
            refreshListToolStripMenuItem.Size = new Size(180, 22);
            refreshListToolStripMenuItem.Text = "Refresh List";
            refreshListToolStripMenuItem.Click += refreshListToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(177, 6);
            // 
            // quitToolStripMenuItem
            // 
            quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            quitToolStripMenuItem.Size = new Size(180, 22);
            quitToolStripMenuItem.Text = "Quit";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { capuchinModdingCommunityToolStripMenuItem, toolStripSeparator2, aboutCapuchinModManagerToolStripMenuItem, gitRepositoryToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // capuchinModdingCommunityToolStripMenuItem
            // 
            capuchinModdingCommunityToolStripMenuItem.Name = "capuchinModdingCommunityToolStripMenuItem";
            capuchinModdingCommunityToolStripMenuItem.Size = new Size(255, 22);
            capuchinModdingCommunityToolStripMenuItem.Text = "Capuchin Modding Community";
            capuchinModdingCommunityToolStripMenuItem.Click += capuchinModdingCommunityToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(252, 6);
            // 
            // aboutCapuchinModManagerToolStripMenuItem
            // 
            aboutCapuchinModManagerToolStripMenuItem.Name = "aboutCapuchinModManagerToolStripMenuItem";
            aboutCapuchinModManagerToolStripMenuItem.Size = new Size(255, 22);
            aboutCapuchinModManagerToolStripMenuItem.Text = "About CapuchinModManager";
            aboutCapuchinModManagerToolStripMenuItem.Click += aboutCapuchinModManagerToolStripMenuItem_Click;
            // 
            // gitRepositoryToolStripMenuItem
            // 
            gitRepositoryToolStripMenuItem.Name = "gitRepositoryToolStripMenuItem";
            gitRepositoryToolStripMenuItem.Size = new Size(255, 22);
            gitRepositoryToolStripMenuItem.Text = "CapuchinModManager on GitHub";
            gitRepositoryToolStripMenuItem.Click += gitRepositoryToolStripMenuItem_Click;
            // 
            // modListVersion
            // 
            modListVersion.Text = "Version";
            modListVersion.Width = 150;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(692, 480);
            Controls.Add(modsList);
            Controls.Add(installButton);
            Controls.Add(mainStatusReporter);
            Controls.Add(mainStrip);
            Name = "Main";
            Text = "CapuchinModManager";
            Load += Main_Load;
            mainStatusReporter.ResumeLayout(false);
            mainStatusReporter.PerformLayout();
            mainStrip.ResumeLayout(false);
            mainStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip mainStatusReporter;
        public ToolStripStatusLabel taskLabel;
        public ToolStripProgressBar taskProgress;
        private Button installButton;
        private ListView modsList;
        private ColumnHeader modListName;
        private ColumnHeader modListDeveloper;
        private MenuStrip mainStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem installToolStripMenuItem;
        private ToolStripMenuItem fromRepositoryToolStripMenuItem;
        private ToolStripMenuItem fromComputerToolStripMenuItem;
        private ToolStripMenuItem refreshListToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem quitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem capuchinModdingCommunityToolStripMenuItem;
        private ToolStripMenuItem aboutCapuchinModManagerToolStripMenuItem;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem gitRepositoryToolStripMenuItem;
        private ColumnHeader modListVersion;
    }
}