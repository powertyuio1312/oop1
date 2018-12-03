using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LAB13
{
    // методами для вывода информации о
    // конкретном файле
    // a.Полный путь
    // b.Размер, расширение, имя
    // c.Время создания
    class KPOFileInfo
    {
        string FileName;
        FileInfo file;

        public KPOFileInfo(string FileName)
        {
            this.FileName = FileName;
            file = new FileInfo(FileName);
        }

        
        public void FileInformation()
        {
            Console.WriteLine("File information:");
            Console.WriteLine("DirectoryName: {0}", file.DirectoryName);
            Console.WriteLine("FileName: {0}", file.Name);
            Console.WriteLine("File Extention: {0}", file.Extension);
            Console.WriteLine("File size: {0}", file.Length);
            Console.WriteLine("Creation Date: {0}", file.CreationTime);
        }
    }
}
