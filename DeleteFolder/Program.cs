using System;
using System.IO;

namespace DeleteFolder
{
    class Program
    {
        static void Main(string[] args)
        {
            string path;

            Console.Write("Directory to delete recursively? ");
            path = Console.ReadLine();

            DirectoryHandler handler = new DirectoryHandler();
            handler.DeleteDirectoryRecursively(new DirectoryInfo(path));

            Console.Write("Directory to delete? ");
            path = Console.ReadLine();

            handler.DeleteDirectory(new DirectoryInfo(path));
        }


    }
}
