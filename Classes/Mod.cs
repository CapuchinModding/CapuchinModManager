using CapuchinModManager.Utilities;
using Newtonsoft.Json;

namespace CapuchinModManager.Classes
{
    public class Mod(string name, string author, string repo)
    {
        public string Name => name;
        public string Author => author;
        public string Repo => repo;

        private ModNetworkHelper _helper;

        public ModNetworkHelper NetworkData
        {
            get
            {
                _helper ??= new ModNetworkHelper(this);
                return _helper;
            }
        }
    }

    public class ModNetworkHelper(Mod mod)
    {
        public string Version;
        public string DownloadUrl;
        public OutputType OutputType;

        // updates downloads, versions, outputtype, etc
        public byte[] UpdateData()
        {
            var url = $"https://api.github.com/repos/{mod.Repo}/releases/latest";
            var (data, result) = NetworkUtilities.GetStringFromUrl(url).Result;

            if (result != ErrorUtilities.Ok)
            {
                // error handling
            }

            var apiData = JsonConvert.DeserializeObject<Release>(data);

            if (apiData == null)
                return ErrorUtilities.ReportError(typeof(ModNetworkHelper).FullName, $"UpdateData() -> GitHub API null for {url}.\nOOPS");

            Version = apiData.tag_name;

#region This is where the error comes from
            DownloadUrl = apiData.assets.First().browser_download_url;
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
