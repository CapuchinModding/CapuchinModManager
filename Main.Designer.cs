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
            taskProgress = new ToolStripProgressBar();
            managerTabControl = new TabControl();
            modsPage = new TabPage();
            modsList = new ListView();
            modListName = new ColumnHeader();
            modListDeveloper = new ColumnHeader();
            installButton = new Button();
            capuchinPage = new TabPage();
            melonLoaderControlPanel = new GroupBox();
            getModsListButton = new Button();
            uninstallModsButton = new Button();
            melonLoaderDocsButton = new Button();
            supportControlPanel = new GroupBox();
            getLogsButton = new Button();
            aboutCMMButton = new Button();
            discordButton = new Button();
            getPlayerIdButton = new Button();
            gameControlPanel = new GroupBox();
            button1 = new Button();
            runCapuchinButton = new Button();
            mainStatusReporter.SuspendLayout();
            managerTabControl.SuspendLayout();
            modsPage.SuspendLayout();
            capuchinPage.SuspendLayout();
            melonLoaderControlPanel.SuspendLayout();
            supportControlPanel.SuspendLayout();
            gameControlPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainStatusReporter
            // 
            mainStatusReporter.Items.AddRange(new ToolStripItem[] { taskLabel, taskProgress });
            mainStatusReporter.Location = new Point(0, 458);
            mainStatusReporter.Name = "mainStatusReporter";
            mainStatusReporter.Size = new Size(624, 22);
            mainStatusReporter.TabIndex = 0;
            mainStatusReporter.Text = "statusStrip1";
            // 
            // taskLabel
            // 
            taskLabel.Name = "taskLabel";
            taskLabel.Size = new Size(143, 17);
            taskLabel.Text = "Updating mod definitions";
            // 
            // taskProgress
            // 
            taskProgress.Name = "taskProgress";
            taskProgress.Size = new Size(200, 16);
            // 
            // managerTabControl
            // 
            managerTabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            managerTabControl.Controls.Add(modsPage);
            managerTabControl.Controls.Add(capuchinPage);
            managerTabControl.Location = new Point(0, 2);
            managerTabControl.Name = "managerTabControl";
            managerTabControl.SelectedIndex = 0;
            managerTabControl.Size = new Size(624, 453);
            managerTabControl.TabIndex = 1;
            // 
            // modsPage
            // 
            modsPage.Controls.Add(modsList);
            modsPage.Controls.Add(installButton);
            modsPage.Location = new Point(4, 24);
            modsPage.Name = "modsPage";
            modsPage.Padding = new Padding(3);
            modsPage.Size = new Size(616, 425);
            modsPage.TabIndex = 0;
            modsPage.Text = "Mods";
            modsPage.UseVisualStyleBackColor = true;
            // 
            // modsList
            // 
            modsList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            modsList.CheckBoxes = true;
            modsList.Columns.AddRange(new ColumnHeader[] { modListName, modListDeveloper });
            modsList.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listViewItem1.StateImageIndex = 0;
            modsList.Items.AddRange(new ListViewItem[] { listViewItem1 });
            modsList.Location = new Point(6, 6);
            modsList.Name = "modsList";
            modsList.Size = new Size(604, 383);
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
            installButton.Location = new Point(516, 395);
            installButton.Name = "installButton";
            installButton.Size = new Size(94, 24);
            installButton.TabIndex = 0;
            installButton.Text = "Install";
            installButton.UseVisualStyleBackColor = true;
            // 
            // capuchinPage
            // 
            capuchinPage.Controls.Add(melonLoaderControlPanel);
            capuchinPage.Controls.Add(supportControlPanel);
            capuchinPage.Controls.Add(gameControlPanel);
            capuchinPage.Location = new Point(4, 24);
            capuchinPage.Name = "capuchinPage";
            capuchinPage.Padding = new Padding(3);
            capuchinPage.Size = new Size(616, 425);
            capuchinPage.TabIndex = 1;
            capuchinPage.Text = "Capuchin";
            capuchinPage.UseVisualStyleBackColor = true;
            // 
            // melonLoaderControlPanel
            // 
            melonLoaderControlPanel.Controls.Add(getModsListButton);
            melonLoaderControlPanel.Controls.Add(uninstallModsButton);
            melonLoaderControlPanel.Controls.Add(melonLoaderDocsButton);
            melonLoaderControlPanel.Location = new Point(8, 281);
            melonLoaderControlPanel.Name = "melonLoaderControlPanel";
            melonLoaderControlPanel.Size = new Size(289, 138);
            melonLoaderControlPanel.TabIndex = 2;
            melonLoaderControlPanel.TabStop = false;
            melonLoaderControlPanel.Text = "MelonLoader";
            // 
            // getModsListButton
            // 
            getModsListButton.Location = new Point(6, 107);
            getModsListButton.Name = "getModsListButton";
            getModsListButton.Size = new Size(273, 23);
            getModsListButton.TabIndex = 2;
            getModsListButton.Text = "Get Mods List";
            getModsListButton.UseVisualStyleBackColor = true;
            // 
            // uninstallModsButton
            // 
            uninstallModsButton.Location = new Point(6, 78);
            uninstallModsButton.Name = "uninstallModsButton";
            uninstallModsButton.Size = new Size(273, 23);
            uninstallModsButton.TabIndex = 1;
            uninstallModsButton.Text = "Uninstall All Mods";
            uninstallModsButton.UseVisualStyleBackColor = true;
            // 
            // melonLoaderDocsButton
            // 
            melonLoaderDocsButton.Location = new Point(6, 22);
            melonLoaderDocsButton.Name = "melonLoaderDocsButton";
            melonLoaderDocsButton.Size = new Size(273, 23);
            melonLoaderDocsButton.TabIndex = 0;
            melonLoaderDocsButton.Text = "MelonLoader Documentation";
            melonLoaderDocsButton.UseVisualStyleBackColor = true;
            // 
            // supportControlPanel
            // 
            supportControlPanel.Controls.Add(getLogsButton);
            supportControlPanel.Controls.Add(aboutCMMButton);
            supportControlPanel.Controls.Add(discordButton);
            supportControlPanel.Controls.Add(getPlayerIdButton);
            supportControlPanel.Location = new Point(8, 106);
            supportControlPanel.Name = "supportControlPanel";
            supportControlPanel.Size = new Size(289, 159);
            supportControlPanel.TabIndex = 1;
            supportControlPanel.TabStop = false;
            supportControlPanel.Text = "Support";
            // 
            // getLogsButton
            // 
            getLogsButton.Location = new Point(6, 51);
            getLogsButton.Name = "getLogsButton";
            getLogsButton.Size = new Size(277, 23);
            getLogsButton.TabIndex = 3;
            getLogsButton.Text = "Collect Game Logs";
            getLogsButton.UseVisualStyleBackColor = true;
            // 
            // aboutCMMButton
            // 
            aboutCMMButton.Location = new Point(6, 130);
            aboutCMMButton.Name = "aboutCMMButton";
            aboutCMMButton.Size = new Size(277, 23);
            aboutCMMButton.TabIndex = 2;
            aboutCMMButton.Text = "About CapuchinModManager";
            aboutCMMButton.UseVisualStyleBackColor = true;
            aboutCMMButton.Click += aboutCMMButton_Click;
            // 
            // discordButton
            // 
            discordButton.Location = new Point(6, 101);
            discordButton.Name = "discordButton";
            discordButton.Size = new Size(277, 23);
            discordButton.TabIndex = 1;
            discordButton.Text = "Capuchin Modding Community Discord";
            discordButton.UseVisualStyleBackColor = true;
            discordButton.Click += discordButton_Click;
            // 
            // getPlayerIdButton
            // 
            getPlayerIdButton.Location = new Point(6, 22);
            getPlayerIdButton.Name = "getPlayerIdButton";
            getPlayerIdButton.Size = new Size(277, 23);
            getPlayerIdButton.TabIndex = 0;
            getPlayerIdButton.Text = "Get Player ID";
            getPlayerIdButton.UseVisualStyleBackColor = true;
            // 
            // gameControlPanel
            // 
            gameControlPanel.Controls.Add(button1);
            gameControlPanel.Controls.Add(runCapuchinButton);
            gameControlPanel.Location = new Point(8, 6);
            gameControlPanel.Name = "gameControlPanel";
            gameControlPanel.Size = new Size(289, 85);
            gameControlPanel.TabIndex = 0;
            gameControlPanel.TabStop = false;
            gameControlPanel.Text = "Game";
            // 
            // button1
            // 
            button1.Location = new Point(6, 51);
            button1.Name = "button1";
            button1.Size = new Size(277, 23);
            button1.TabIndex = 1;
            button1.Text = "Kill Capuchin Process";
            button1.UseVisualStyleBackColor = true;
            // 
            // runCapuchinButton
            // 
            runCapuchinButton.Location = new Point(6, 22);
            runCapuchinButton.Name = "runCapuchinButton";
            runCapuchinButton.Size = new Size(277, 23);
            runCapuchinButton.TabIndex = 0;
            runCapuchinButton.Text = "Start Capuchin";
            runCapuchinButton.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 480);
            Controls.Add(managerTabControl);
            Controls.Add(mainStatusReporter);
            Name = "Main";
            Text = "CapuchinModManager";
            mainStatusReporter.ResumeLayout(false);
            mainStatusReporter.PerformLayout();
            managerTabControl.ResumeLayout(false);
            modsPage.ResumeLayout(false);
            capuchinPage.ResumeLayout(false);
            melonLoaderControlPanel.ResumeLayout(false);
            supportControlPanel.ResumeLayout(false);
            gameControlPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip mainStatusReporter;
        public ToolStripStatusLabel taskLabel;
        public ToolStripProgressBar taskProgress;
        private TabControl managerTabControl;
        private TabPage modsPage;
        private Button installButton;
        private TabPage capuchinPage;
        private ListView modsList;
        private ColumnHeader modListName;
        private ColumnHeader modListDeveloper;
        private GroupBox gameControlPanel;
        private Button runCapuchinButton;
        private GroupBox supportControlPanel;
        private Button getPlayerIdButton;
        private Button button1;
        private Button getLogsButton;
        private Button aboutCMMButton;
        private Button discordButton;
        private GroupBox melonLoaderControlPanel;
        private Button getModsListButton;
        private Button uninstallModsButton;
        private Button melonLoaderDocsButton;
    }
}