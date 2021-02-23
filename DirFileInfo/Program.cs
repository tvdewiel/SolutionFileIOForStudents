using System;
using System.Collections.Generic;
using System.IO;

namespace DirFileInfo
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string path = @"C:\HoGent\Gevorderd";
            Info info = new Info(path);
            info.ShowDirectoryInfo();
            info.Show10BiggestFiles();
            info.DirCreate(@"C:\HoGent\Gevorderd", "test");
                       

        }
    }
}
