using CapuchinModManager.Classes;
using Newtonsoft.Json;

namespace CapuchinModManager.Utilities
{
    public static class ModUtilities
    {
        public static List<Mod> FetchMods()
        {
            TaskUtilities.ReportCurrentTask("Downloading mod definitions", 1, 3);

            var (content, status) = NetworkUtilities.GetStringFromUrl(Program.ModListUrl).Result;

            if (status != ErrorUtilities.Ok)
            {
                ErrorUtilities.ReportError($"Failed to fetch mod definitions. Are you connected to the internet?\nError Code: {status}");
            }

            TaskUtilities.ReportCurrentTask("Parsing mod definitions", 2, 3);

            var mods = JsonConvert.DeserializeObject<List<Mod>>(content);

            mods.ForEach(mod => mod.NetworkData.UpdateData());
            
            return mods;
        }
    }
}
