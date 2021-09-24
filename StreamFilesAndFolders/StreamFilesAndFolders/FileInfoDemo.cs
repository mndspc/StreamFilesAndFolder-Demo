using System;
using System.IO;
namespace StreamFilesAndFolders
{
    //  This program demo. how to use FileInfo class.
    class FileInfoDemo
    {
        static void Main()
        {
            try
            {
                FileInfo fileInfo = new FileInfo("try.txt");
               if(fileInfo.Exists)
                {
                    Console.WriteLine($"Full Name:{fileInfo.FullName}");
                    Console.WriteLine($"Name:{fileInfo.Name}");
                    Console.WriteLine($"Extension:{fileInfo.Extension}");
                    Console.WriteLine($"Length:{fileInfo.Length} bytes");
                    Console.WriteLine($"Created at:{fileInfo.CreationTime}");
                    Console.WriteLine($"Accesses at:{fileInfo.LastAccessTime}");
                    fileInfo.CopyTo(@"E:\MyTestFile.txt", true);
                    Console.WriteLine("File is Copied");
                    //fileInfo.MoveTo(@"E:\MyTestFile.txt");

                    FileInfo fileInfo1 = new FileInfo(@"E:\MyTestFile.txt");
                    fileInfo1.Delete();
                    Console.WriteLine("File is Deleted");
                }
                else
                {
                    Console.WriteLine("File does not exist");
                }
                Console.ReadLine();

            }catch(Exception ex)
            {

            }
        }
    }
}
