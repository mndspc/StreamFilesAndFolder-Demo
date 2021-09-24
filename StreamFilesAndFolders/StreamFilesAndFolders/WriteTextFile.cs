using System;
using System.IO;
namespace StreamFilesAndFolders
{
    //  This program demo. how to write text file using FileStream and StreamWriter
    class WriteTextFile
    {
        static void Main()
        {
            try
            {
                FileInfo fileInfo = new FileInfo("TestFile.txt");

                using (FileStream fileStream = fileInfo.Open(FileMode.Create, FileAccess.Write))
                {

                    //Create StreamWriter to write content from filestream to file
                    using (StreamWriter streamWriter = new StreamWriter(fileStream))
                    {
                        streamWriter.WriteLine("This is test message");
                        streamWriter.Close();
                    }
                    fileStream.Close();    
                }
                Console.WriteLine("File is created");

            }catch(IOException ex)
            {

            }
            Console.ReadLine();
        }
    }
}
