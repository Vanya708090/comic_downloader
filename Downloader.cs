using System;
using System.Net;
using System.IO;
using System.IO.Compression;


namespace ComicDownloader
{
    class Downloader
    {
        public static int num = 1;
        public static void DownloadAllPage(WebClient Client, string url, string path)
        {
            int n = 1;
            while (true)
            {
                try {
                    while (n < 10)
                    {
                        Client.DownloadFile(url + $"0{ n }.jpg", path + $"/{ n }.jpg");
                        n = n + 1;
                    }
                    Client.DownloadFile(url + $"{ n }.jpg", path + $"/{ n }.jpg");
                    n = n + 1;

                }
                catch
                {                  
                    Console.WriteLine($"Комикс {num-1} загружено {n-1} страниц: ");
                    ZipFile.CreateFromDirectory(path, path+".cbz");
                    Directory.Delete(path, true);
                    break;
                }

                
            }
            
        }
        public static string CreateDirectory(string path)
        {
            path = path + $"{ num }";
            Directory.CreateDirectory(path);
            num++;
            return path;
        }


    }
}
