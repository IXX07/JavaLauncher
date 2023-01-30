using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace JavaLauncher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Java Launcher";
            Console.ForegroundColor = ConsoleColor.Yellow;

            if (args.Length > 0 && File.Exists(args[0]) && Path.GetExtension(args[0]) == ".jar")
                Process.Start("CMD.exe", "/C java -jar " + Path.GetFileName(args[0]));
            else
            {
                Console.WriteLine("An unexpected error has occured.");
                Thread.Sleep(3000);
            }
        }
    }
}
