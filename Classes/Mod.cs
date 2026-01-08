using CapuchinModManager.Utilities;
using Newtonsoft.Json;

namespace CapuchinModManager.Classes
{
    public class Mod(string name, string repo)
    {
        public string Name => name;
        public string Repo => repo;
    }

    public class ModNetworkHelper(Mod mod)
    {
        public Version Version;
        public string DownloadUrl;
        public OutputType OutputType;

        // updates downloads, versions, outputtype, etc
        public async Task<byte[]> UpdateData()
        {
            var url = $"https://api.github.com//repos/{mod.Repo}/releases/latest";
            var (data, result) = await NetworkUtilities.GetStringFromUrl(url);

            if (result != ErrorUtilities.Ok)
            {
                // error handling
            }

            var apiData = JsonConvert.DeserializeObject<Dictionary<string, object>>(data);

            if (apiData == null)
                return ErrorUtilities.ReportError(typeof(ModNetworkHelper).FullName, "UpdateData() -> GitHub API data returned null. Cannot update.");

            Version = new Version((string)apiData["tag_name"]);

#region This is where the error comes from
            DownloadUrl = (string)((List<Dictionary<string, object>>)apiData["assets"])[0]["browser_download_url"];
#endregion

            OutputType = OutputType.Plugins;

            return ErrorUtilities.Ok;
        }
    }

    public enum OutputType
    {
        Plugins,
        Root
    }
}
