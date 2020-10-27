using System;
using System.Net;

namespace CrossDownloadManager.Download
{
    public class DownloadUrl
    {
        public static void DownloadFromUrl()
        {
            // Initialize the WebClient
            var webClient = new WebClient();
            Console.Write("Download Link: ");
            // Receive the Url
            string fileUrl = Console.ReadLine();
            // Separating the file name
            string fileName = DownloadUrl.getFileName(fileUrl);
            webClient.DownloadFile(fileUrl, fileName);
            Console.WriteLine("Download Completed");
        }

        // Separating the file name
        private static string getFileName(string fileUrl)
        {
            string[] urlArray = fileUrl.Split("/");
            string fileName = urlArray[urlArray.Length - 1];
            return fileName;
        }
    }
}