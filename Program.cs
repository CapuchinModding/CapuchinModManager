using CapuchinModManager.Utilities;

namespace CapuchinModManager
{
    public static class Program
    {
        public static Version Version => new("1.0.0");

        public const string DiscordInviteUrl = "https://discord.gg/awVb24kMxw";

        public const string ModListUrl = "https://raw.githubusercontent.com/CapuchinModding/CapuchinModManager/refs/heads/master/mods.json";

        [STAThread]
        static void Main()
        {
            Task.Run(async () => await NetworkUtilities.BoopOctocat()).GetAwaiter().GetResult();

            ApplicationConfiguration.Initialize();
            Application.Run(new Main());
        }
    }
}