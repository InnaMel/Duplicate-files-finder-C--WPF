using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using InclusionMetods;

namespace FinalProjectReWritten
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] AllFiles = null;
            string UserPath;

            Console.Write("Path: ");
            UserPath = Console.ReadLine();

            if (MetodsClass.DirExists(UserPath))
            {
                Console.WriteLine("************\n");
                Console.WriteLine("All as string:");
                AllFiles = MetodsClass.GetAllFiles(UserPath);
                DisplayStringArrList.DisplayFORStringArrList(AllFiles);

                Console.WriteLine("\n");
                Console.WriteLine("All as class:");
                Console.WriteLine("************");

                List<FileClass> ListAllFilesAsClass = MetodsClass.ParseStringToClass(AllFiles.ToList());
                DisplayStringArrList.DisplayFORStringArrList(ListAllFilesAsClass);

                Console.WriteLine("\n");
                Console.WriteLine("DUPLICATES:");
                Console.WriteLine("************");

                List<List<FileClass>> GlobalDuplicates = MetodsClass.FindDuplicates(ListAllFilesAsClass);
                foreach (List<FileClass> item in GlobalDuplicates)
                {
                    DisplayStringArrList.DisplayFORStringArrList(item);
                }
            }
            else
                Console.WriteLine("You are wrong");

            Console.ReadKey();
        }
    }
}



//Console.WriteLine("Trying print as list\n");
//AllFiles.ToList().ForEach(Console.WriteLine);

//    *** using instead of [] - list<> for all directory
//List<string> leftDirectory = new List<string>(Directory.EnumerateDirectories(File.PathFile));
//leftDirectory.ForEach(Console.WriteLine);



