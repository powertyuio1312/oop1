using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LAB13
{
    // работу с текстовым файлом
    // xxxlogfile.txt.в который записываются все действия пользователя и
    // соответственно методами записи в текстовый файл, чтения, поиска нужной
    // информации

    // Используя данный класс выполните запись всех
    // последующих действиях пользователя с указанием действия,
    // детальной информации(имя файла, путь) и времени
    // (дата/время)

    class KPOLog
    {
        public void Call()
        {
            FileSystemWatcher watcher = new FileSystemWatcher("C:\\Users\\Полина\\Desktop\\ун\\ООП\\oop1\\LAB13");
            using (FileStream file = new FileStream("KPOlogfile.txt", FileMode.OpenOrCreate))
            {
                watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName;
                watcher.Filter = "*.txt";

                watcher.Changed += new FileSystemEventHandler(OnChanges);
                watcher.Created += new FileSystemEventHandler(OnChanges);
                watcher.Deleted += new FileSystemEventHandler(OnChanges);
                watcher.Renamed += new RenamedEventHandler(OnRenamed);

                watcher.EnableRaisingEvents = true;
            }
        }
        private static void OnChanges(object obj, FileSystemEventArgs e)
        {
            Console.WriteLine("File: " + e.FullPath + " " + e.ChangeType);
        }

        private static void OnRenamed(object source, RenamedEventArgs e)
        {
            Console.WriteLine("File: {0} renamed to {1}", e.OldFullPath, e.FullPath);
        }
    }
}
