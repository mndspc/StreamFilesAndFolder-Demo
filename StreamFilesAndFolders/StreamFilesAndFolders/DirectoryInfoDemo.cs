using System;
using System.IO;

namespace StreamFilesAndFolders
{
    //  This program demo. how to use DirctoryInfo class
    class DirectoryInfoDemo
    {
        static void Main()
        {
            try
            {
                DirectoryInfo directoryInfo = new DirectoryInfo("MyFolder");
                if (directoryInfo.Exists)
                {
                    Console.WriteLine($"Full Name:{directoryInfo.FullName}");
                    Console.WriteLine($"Name:{directoryInfo.Name}");
                    Console.WriteLine($"Created at:{directoryInfo.CreationTime}");
                    Console.WriteLine($"Last Access at:{directoryInfo.LastAccessTime}");
                    //directoryInfo.Delete();
                    Console.WriteLine("List of Files");
                    var files = directoryInfo.GetFiles();
                    foreach(var file in files)
                    {
                        Console.WriteLine(file.Name);
                        file.Delete();
                    }
                    Console.WriteLine("List of Folders");
                    var folders = directoryInfo.GetDirectories();
                    foreach(var folder in folders)
                    {
                        Console.WriteLine(folder.Name);
                        folder.Delete();
                    }
                }
                else
                {
                    directoryInfo.Create();
                    Console.WriteLine("Folder is created");
                    Console.WriteLine($"Full Name:{directoryInfo.FullName}");
                    Console.WriteLine($"Name:{directoryInfo.Name}");
                    Console.WriteLine($"Created at:{directoryInfo.CreationTime}");
                    Console.WriteLine($"Last Access at:{directoryInfo.LastAccessTime}");
                }

                Console.ReadLine();
            }catch(IOException ex)
            {

            }
        }
    }
}
