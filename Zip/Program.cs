using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;

namespace Zip
{
    class Program
    {
        public static void UnzipFile(string fileName,string extractFolder)
        {
            using (ZipArchive archive = ZipFile.Open(fileName, ZipArchiveMode.Read))
            {
                foreach (ZipArchiveEntry entry in archive.Entries)
                {
                    // ... Display properties.
                    //     Extract to directory.
                    Console.WriteLine("Size: " + entry.CompressedLength);
                    Console.WriteLine("Name: " + entry.Name);
                    entry.ExtractToFile(extractFolder + "\\"+entry.Name);
                }
            }
        }
        public static void CreateZipFile(string fileName, IEnumerable<string> files)
        {
            // Create and open a new ZIP file
            var zip = ZipFile.Open(fileName, ZipArchiveMode.Create);
            foreach (var file in files)
            {
                // Add the entry for each file
                zip.CreateEntryFromFile(file, file, CompressionLevel.Optimal);
            }
            // Dispose of the object when we are done
            zip.Dispose();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string path = @"c:\hogent\gevorderd\data\zipdata";
           // string extractPath= @"c:\tmp";
            string extractPath = @"c:\hogent\gevorderd\data\zipdata\extract";
            string zipPath= @"c:\hogent\gevorderd\data\zipdata\ZipData.zip";

            //CreateZipFile(zipPath, Directory.EnumerateFiles(path, "*.csv"));
            //File.Copy(zipPath, Path.Combine(path, "copyOfZip.zip"));
            //ZipFile.ExtractToDirectory(zipPath, extractPath);
            UnzipFile(zipPath, extractPath);
        }
    }
}
