using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;


namespace LAB13
{
    class KPOFileManager
    {
        public void FileManager(string path)
        {
            Console.WriteLine("\n FileManager: ");
            string filepath = path + "\\LAB13\\LAB13" + "\\" +"KPOInspect";
            Directory.CreateDirectory(filepath);

            string filename = filepath + "\\" + "kpodirinfo.txt";
            FileInfo file = new FileInfo(filename);
            
            using (FileStream fstream = new FileStream(filename, FileMode.Create)) //FileMode перечисление, указывает на режим доступа к файл
            {
                
                if (Directory.Exists(path))
                {
                    Console.WriteLine("Files:");
                    string[] files = Directory.GetFiles(path);
                    foreach  (string f in files)
                    {
                        byte[] arr = Encoding.Default.GetBytes(f);
                        fstream.Write(arr, 0, arr.Length);
                    }

                    Console.WriteLine("SubDir:");
                    string[] dirs = Directory.GetDirectories(path);
                    foreach (string dirr in dirs)
                    {
                        byte[] arr = Encoding.Default.GetBytes(dirr);
                        fstream.Write(arr, 0, arr.Length);
                    }
                }
                else
                {
                    Console.WriteLine("This directory doesn't exists");
                }
            }

            Console.WriteLine("Text written to file");

            file.CopyTo(filepath + "\\" + "newKPODirInfo.txt", true);
            file.Delete();

            ///// b

        
            
            DirectoryInfo directory = new DirectoryInfo("KPOFiles");
            directory.Create();

            
            string[] files2 = Directory.GetFiles("KPOFiles");
            foreach(string file2 in files2)
            {
                File.Copy(file2, "KPOFiles" + new FileInfo(file2).Name);
            }

            foreach(FileInfo fi in directory.GetFiles())
            {
                fi.CopyTo(path + "\\" + fi.Name, true);
            }

            
            Console.WriteLine("KPOFiles moved to KPOInspect");

            //ZipFile.CreateFromDirectory("C:\\Users\\Полина\\Desktop\\ун\\ООП\\oop1\\LAB13\\KPOInspect\\KPOFiles", "C:\\Users\\Полина\\Desktop\\ун\\ООП\\oop1\\LAB13\\arch.zip");
            //ZipFile.ExtractToDirectory("C:\\Users\\Полина\\Desktop\\ун\\ООП\\oop1\\LAB13\\arch.zip", "C:\\Users\\Полина\\Desktop\\ун\\ООП\\oop1\\LAB13\\Archive\\");

        }


        ///// <summary>
        ///// /////////////////////////////////////////////////////////////
        ///// 
        ///// </summary>
        //FileStream fs;
        //FileInfo file1;

        //String path = "C:\\Users\\Полина\\Desktop\\ун\\ООП\\oop1\\LAB13";
        //String nameOfDir = "KPOdironfo";
        //string nameOfFile = "test.txt";
        //string nameOfDisk;

        //public KPOFileManager(string nameOfDisk)
        //{
        //    this.nameOfDisk = nameOfDisk;
        //}

        //DriveInfo[] dir;
        //DriveInfo dir1;

        //static public void CreateDir(string path, string nameOfSubDir)
        //{
        //    DirectoryInfo tryToCreateDir = Directory.CreateDirectory(path);
        //    if (!tryToCreateDir.Exists)
        //    {
        //        tryToCreateDir.Create();
        //    }
        //    tryToCreateDir.CreateSubdirectory(nameOfSubDir);
        //    Console.WriteLine("The directory is created at {0}", Directory.GetCreationTime(path));
        //}

        //static bool CheckFile(string fileName)
        //{
        //    FileInfo file = new FileInfo(fileName);
        //    if (file.Exists)
        //    {
        //        return true;
        //    }
        //    return false;
        //}

        //public void CreateFile(string path, string file)
        //{
        //    string fullname = path + "\\" + file;
        //    Console.WriteLine(fullname);
        //    if (CheckFile(fullname))
        //    {
        //        file1 = new FileInfo(fullname);
        //        file1.Create();
        //    }
        //}

        //public void Input(string[] dirs)
        //{
        //    foreach (string dir in dirs)
        //    {
        //        byte[] input = Encoding.Default.GetBytes(dir);
        //        fs.Write(input, 0, input.Length);
        //    }
        //}

        //public void entryInFile(string[] dirs)
        //{
        //    fs = file1.Create();
        //    Input(dirs);
        //    fs.Close();
        //}

        //public void CopyFile(string fileName, string path)
        //{
        //    if (CheckFile(fileName))
        //    {
        //        FileInfo file = new FileInfo(fileName);
        //        file.CopyTo(path, true); //аргумент, разрешающий перезапись уже существующего файла
        //        Console.WriteLine("File is copied.");
        //    }
        //}

        //static public void DelFile(string path)
        //{
        //    if(CheckFile(path))
        //    {
        //        FileInfo file = new FileInfo(path);
        //        file.Delete();
        //        Console.WriteLine("File is deleted");
        //    }
        //}

        //FileInfo[] getFiles(DirectoryInfo dir, string expansion)
        //{
        //    FileInfo[] info = dir.GetFiles(expansion, SearchOption.TopDirectoryOnly);
        //    return info;
        //}

        //void copyFiles(string expansion, string dir, string path)
        //{
        //    DirectoryInfo directory = new DirectoryInfo(dir);
        //    FileInfo[] fileInfo = getFiles(directory, expansion);
        //    foreach (FileInfo file in fileInfo)
        //    {
        //        file.CopyTo(path + "\\" + file.Name, true);
        //    }
        //}

        //void AddToZip(string name, string zip)
        //{
        //    ZipFile.CreateFromDirectory(name, zip);
        //    ZipFile.ExtractToDirectory(zip, name + "\\KPO");
        //}

        //public void DirectoryList()
        //{
        //    CreateDir(path, nameOfDir);
        //    this.CreateFile(path + "\\" + nameOfDir, nameOfFile);

        //    string[] dirs = Directory.GetDirectories(nameOfDisk);
        //    file1 = new FileInfo(path + "\\" + nameOfDir + "\\" + nameOfFile);

        //    entryInFile(dirs);
        //    nameOfFile = "test.txt";

        //    CopyFile(path + "\\" + nameOfDir + "\\test.txt", path + "\\" + nameOfDir + "\\" + nameOfFile);

        //    DelFile(path + "\\" + nameOfDir + "\\test.txt");

        //    CreateDir(path, "KPOInspect");

        //    copyFiles("*.txt", path + "\\" + nameOfDir, path + "\\KPOInspect");

        //    AddToZip(path + "\\BAVInspect", path + "\\file.zip");
        //}

    }
}
