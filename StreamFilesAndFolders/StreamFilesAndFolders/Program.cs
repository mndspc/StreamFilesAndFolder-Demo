using System;
using System.IO;

namespace StreamFilesAndFolders
{
    //  This program demo. how to read text file using FileStream and StreamReader class.
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // FileInfo class hold reference of file from physical path
                FileInfo fileInfo = new FileInfo("try.txt");
                //  FileInfo fileInfo = new FileInfo(@"D:\try.txt");

                //  Open a file for reading/writing
                using (FileStream fileStream = fileInfo.Open(FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader streamReader = new StreamReader(fileStream))
                    {
                        string content = streamReader.ReadToEnd();
                        Console.WriteLine(content);

                        //  Closing streamreader after reading.
                        streamReader.Close();
                    }
                    //  Closing filestream after reading.
                    fileStream.Close();
                }
            
            }
            catch(IOException ex)
            {

            }
            Console.ReadLine();
        }
    }
}
