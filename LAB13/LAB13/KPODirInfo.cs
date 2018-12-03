using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LAB13
{
    // методами для вывода информации о конкретном директории
    // a.Количестве файлов
    // b. Время создания
    // c.Количестве поддиректориев
    // d.Список родительских директориев

    class KPODirInfo
    {
        string DirName;
        DirectoryInfo dir;

        public KPODirInfo(string DirName)
        {
            this.DirName = DirName;
            dir = new DirectoryInfo(@"C:\Users\Полина\Desktop\ун\ООП");
        }

        public void DirInfo()
        {
            FileInfo[] fi = dir.GetFiles();
            Console.WriteLine("Files Count in directory {0} = {1}", this.DirName, fi.Length);

            DirectoryInfo[] di = dir.GetDirectories();
            Console.WriteLine("Dir count in Dir {0} = {1}", this.DirName, di.Length);

            Console.WriteLine("Parent directory list: ");
            while(Directory.GetParent(this.DirName) != null)
            {
                Console.WriteLine(Directory.GetParent(this.DirName).Name);
                Console.WriteLine(Directory.GetParent(this.DirName));
            }

            Console.WriteLine("Creation Date: {0} ", dir.CreationTime);
        }
    }
}
