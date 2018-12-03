using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LAB13
{
    //методами для вывода информации о
    // a.свободном месте на диске
    // b.Файловой системе
    // c.Для каждого существующего диска - имя, объем, доступный
    // объем, метка тома.
    public class KPODiskInfo
    {
        DriveInfo[] drives = DriveInfo.GetDrives();

        public void DriveFreeSpace()
        {
            foreach (DriveInfo drive in drives)
            {
                if (drive.IsReady)
                {
                    Console.WriteLine("FreeSpace: available - {0}, total - {1} MB", drive.AvailableFreeSpace, drive.TotalFreeSpace);
                    Console.WriteLine("Capacity: {0} GB", drive.TotalSize/1024/1024/1024);
                }
                Console.WriteLine();
            }
        }

        public void FileSystInfo()
        {
            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine("File System of Drive:");
                Console.WriteLine(drive.Name);
                Console.WriteLine(drive.DriveFormat);
            }
        }

        public void DriveInform()
        {
            Console.WriteLine("___Disk info___");
            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine("Name: {0}", drive.Name);
                Console.WriteLine("Type: {0}", drive.DriveType);

                if (drive.IsReady)
                {
                    Console.WriteLine("Format: {0}", drive.DriveFormat);
                    Console.WriteLine("Capacity: {0} GB", drive.TotalSize / 1024 / 1024 / 1024);
                    Console.WriteLine("Volume label: {0}", drive.VolumeLabel);
                }
                Console.WriteLine();
            }
        }
    }
}
