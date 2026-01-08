using System.Diagnostics;

namespace CapuchinModManager
{
    public partial class Main : Form
    {
        public static Main Instance;

        public Main()
        {
            InitializeComponent();
            Instance = this;

            modsList.Items.Clear();
        }

        private void aboutCMMButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                $"CapuchinModManager v{Program.Version}\n(C) Copyright 2024 - 2026 github.com/CapuchinModding\nMIT License\n\nMade with <3 by the Capuchin Modding Community",
                "About CapuchinModManager",
                MessageBoxButtons.OK,
                MessageBoxIcon.Asterisk
            );
        }

        private void discordButton_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = Program.DiscordInviteUrl,
                UseShellExecute = true
            });
        }
    }
}
