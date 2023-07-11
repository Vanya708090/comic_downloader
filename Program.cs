using System;
using System.Net;
using System.IO.Compression;

namespace ComicDownloader
{
    class Program
    {
        public static void Metod(int n, string url, string path, WebClient Client1)
        {
            path = Downloader.CreateDirectory(path);
            Downloader.DownloadAllPage(Client1, url + $"{n}/", path);
        }
        static void Main(string[] args)
        {
            int n = 1;
            int count = Convert.ToInt32(Console.ReadLine());
            string url1 = "http://img1.unicomics.com/comics/ultimate-spider-man/ultimate-spider-man-00";
            string url2 = "http://img1.unicomics.com/comics/ultimate-spider-man/ultimate-spider-man-0";
            string url3 = "http://img1.unicomics.com/comics/ultimate-spider-man/ultimate-spider-man-";
            WebClient Client1 = new WebClient();
            while (n<=count)
            {
                string path1 = "C:/Users/Computer/Desktop/комикс/";
                if (n < 10)
                 {
                    Metod(n, url1, path1, Client1);
                 }
                else if (n < 100 && n > 9)
                {
                    Metod(n, url2, path1, Client1);
                }
                else
                {
                    Metod(n, url3, path1, Client1);
                }
                n++;
            }
            Console.WriteLine("Загрузка всех комиксов закончена. ");
        }

    }
    }
