using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace CapuchinModManager.Utilities
{
    public static class NetworkUtilities
    {
        // For error reporting in bytes:
        // 79, 79, 50, 53 == OOPS
        // Number that follows represents what kind of error you have. 1 for unknown.

        public static async Task<byte[]> GetBytesFromUrl(string url)
        {
            using var client = new HttpClient();
            try
            {
                var bytes = await client.GetByteArrayAsync(url);
                return bytes;
            }
            catch (HttpRequestException httpEx)
            {
                if (httpEx.StatusCode == HttpStatusCode.OK)
                    return ErrorUtilities.OopsCode(1);

                return httpEx.HttpRequestError switch
                {
                    HttpRequestError.ConnectionError => ErrorUtilities.OopsCode(2),
                    HttpRequestError.InvalidResponse => ErrorUtilities.OopsCode(3),
                    HttpRequestError.ResponseEnded => ErrorUtilities.OopsCode(4),

                    _ => ErrorUtilities.OopsCode(1)
                };
            }

            return ErrorUtilities.OopsCode(1);
        }

        public static async Task<(string content, byte[] result)> GetStringFromUrl(string url)
        {
            using var client = new HttpClient();
            try
            {
                var str = await client.GetStringAsync(url);
                return (str, ErrorUtilities.Ok);
            }
            catch (HttpRequestException httpEx)
            {
                if (httpEx.StatusCode == HttpStatusCode.OK)
                    return (string.Empty, ErrorUtilities.OopsCode(1));

                return httpEx.HttpRequestError switch
                {
                    HttpRequestError.ConnectionError => (string.Empty, ErrorUtilities.OopsCode(2)),
                    HttpRequestError.InvalidResponse => (string.Empty, ErrorUtilities.OopsCode(3)),
                    HttpRequestError.ResponseEnded => (string.Empty, ErrorUtilities.OopsCode(4)),

                    _ => (string.Empty, ErrorUtilities.OopsCode(1))
                };
            }

            return (string.Empty, ErrorUtilities.OopsCode(1));
        }

        // sends ping to GitHub api to test connections
        public static async Task<byte[]> BoopOctocat()
        {
            var (octocat, result) = await GetStringFromUrl("https://api.github.com/octocat");

            if (result == ErrorUtilities.Ok)
            {
                Console.WriteLine(octocat);
                Console.WriteLine("boop");
            }
            else
            {
                ErrorUtilities.ReportError("Unable to connect to the internet. Please check your connection or https://www.githubstatus.com.");
                Application.Exit();
            }

            return result;
        }
    }
}
