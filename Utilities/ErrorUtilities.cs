using System;
using System.Collections.Generic;
using System.Text;

namespace CapuchinModManager.Utilities
{
    public static class ErrorUtilities
    {
        public static byte[] Oops => [79, 79, 50, 53];
        public static byte[] Ok => [79, 75];

        public static byte[] OopsCode(byte error) =>
            Oops.Concat([error]).ToArray();

        /// <summary>
        /// for debug error messages
        /// </summary>
        /// <param name="source"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public static byte[] ReportError(string source, string message)
        {
            MessageBox.Show(
                $"An error occured in {source}:\n\t\"{message}\"",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );

            return OopsCode(0);
        }

        /// <summary>
        /// for user-friendly error messages
        /// </summary>
        /// <param name="message"></param>
        public static void ReportError(string message)
        {

        }
    }
}
