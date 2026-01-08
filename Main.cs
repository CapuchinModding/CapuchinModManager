using CapuchinModManager.Classes;
using CapuchinModManager.Utilities;
using Newtonsoft.Json.Linq;
using System.ComponentModel;
using System.Diagnostics;
using static System.Net.WebRequestMethods;

namespace CapuchinModManager
{
    public partial class Main : Form
    {
        public static Main Instance;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string TaskLabelText
        {
            get => taskLabel.Text ?? "f";
            set
            {
                if (InvokeRequired)
                    Invoke((Action)(() => taskLabel.Text = value));
                else
                    taskLabel.Text = value;
            }
        }

        public void TaskProgressBar(int where, int start, int finish)
        {
            if (InvokeRequired)
            {
                Invoke(() => TaskProgressBar(where, start, finish));
                return;
            }

            taskProgress.Minimum = start;
            taskProgress.Maximum = finish;
            taskProgress.Value = where;
        }

        public void RefreshModList(List<Mod> mods)
        {
            modsList.Items.Clear();
            if (InvokeRequired)
            {
                Invoke(() => RefreshModList(mods));
                return;
            }

            TaskUtilities.ReportCurrentTask("Loading mod list", 0, 1);

            foreach (var mod in mods)
            {
                modsList.Items.Add(new ListViewItem
                {
                    Text = mod.Name,
                    SubItems = { mod.Author, mod.NetworkData.Version }
                });
            }

            TaskUtilities.ReportCurrentTask("No tasks running", 1, 1);
        }

        public void RefreshMods()
        {
            modsList.Items.Clear();
            Task.Run(() =>
            {
                var mods = ModUtilities.FetchMods();
                RefreshModList(mods);
            });
        }

        public Main()
        {
            InitializeComponent();
            Instance = this;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            RefreshMods();
        }

        private void aboutCapuchinModManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                $"CapuchinModManager v{Program.Version}\n(C) Copyright 2024 - 2026 github.com/CapuchinModding\nMIT License\n\nMade with <3 by the Capuchin Modding Community",
                "About CapuchinModManager",
                MessageBoxButtons.OK,
                MessageBoxIcon.Asterisk
            );
        }

        private void capuchinModdingCommunityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = Program.DiscordInviteUrl,
                UseShellExecute = true
            });
        }

        private void gitRepositoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/CapuchinModding/CapuchinModManager",
                UseShellExecute = true
            });
        }

        private void refreshListToolStripMenuItem_Click(object sender, EventArgs e) =>
            RefreshMods();
    }
}
