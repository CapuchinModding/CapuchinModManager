using CapuchinModManager.Utilities;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapuchinModManager
{
    public static class Program
    {
        public static Version Version => new("1.0.0");
        public static string DiscordInviteUrl => "https://discord.gg/awVb24kMxw";

        [STAThread]
        static void Main()
        {
            Task.Run(async () => await NetworkUtilities.BoopOctocat()).GetAwaiter().GetResult();

            ApplicationConfiguration.Initialize();
            Application.Run(new Main());
        }
    }
}