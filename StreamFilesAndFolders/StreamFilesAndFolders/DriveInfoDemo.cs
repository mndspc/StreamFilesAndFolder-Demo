using System;
using System.IO;
namespace StreamFilesAndFolders
{
    //  This program demo. how to use DriveInfo class.
    class DriveInfoDemo
    {
        static void Main()
        {
            DriveInfo driveInfo = new DriveInfo("D:");
            if (driveInfo.IsReady)
            {
                Console.WriteLine($"Drive Name is:{driveInfo.Name}");
                Console.WriteLine($"Drive volume is:{driveInfo.VolumeLabel}");
                Console.WriteLine($"Drive Type is:{driveInfo.DriveType}");
                Console.WriteLine($"Drive Fromat is:{driveInfo.DriveFormat}");
                Console.WriteLine($"Total Free Space:{driveInfo.TotalFreeSpace} bytes");
                Console.WriteLine($"Total Space: {driveInfo.TotalSize} bytes");
            }
            Console.WriteLine("**********List of Drives******************");
            var drives = DriveInfo.GetDrives();
            foreach(var drive in drives)
            {
                if (drive.IsReady)
                {
                    Console.WriteLine($"Drive Name is:{drive.Name}");
                    Console.WriteLine($"Drive volume is:{drive.VolumeLabel}");
                    Console.WriteLine($"Drive Type is:{drive.DriveType}");
                    Console.WriteLine($"Drive Fromat is:{drive.DriveFormat}");
                    Console.WriteLine($"Total Free Space:{drive.TotalFreeSpace} bytes");
                    Console.WriteLine($"Total Space: {drive.TotalSize} bytes");
                }
            }
            Console.ReadLine();
        }
    }
}
