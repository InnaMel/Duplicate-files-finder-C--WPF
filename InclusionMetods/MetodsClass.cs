using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InclusionMetods

{
    public class MetodsClass
    {
        //  *** find out if adjasted directory existed
        public static bool DirExists(string somePath)
        {
            if (Directory.Exists(somePath))
                return true;
            else
                return false;
        }

        //  *** find all folders in adjasted directory and save to massive  *   smth wrong with double inner
        public static string[] GetAllDirectory(string somePath)
        {
            string[] allFindedDirectory = null;

            allFindedDirectory = Directory.GetDirectories(somePath);

            for (int i = 0; i < allFindedDirectory.Length; i++)
            {
                somePath = allFindedDirectory[i];
                allFindedDirectory = allFindedDirectory.Concat(GetAllDirectory(somePath)).ToArray();
            }
            return allFindedDirectory;
        }

        //  *** find all files in adjasted directory and save to massive
        public static string[] GetAllFiles(string somePath)
        {
            string[] allDirectory = GetAllDirectory(somePath);
            Console.WriteLine("************\n");
            string[] allFindedFiles = null;
            string[] filesFromMainFolder = Directory.GetFiles(somePath);
            string[] filesFromOtherDirectory = null;

            if (allDirectory.Length >= 1)
            {
                for (int i = 0; i < allDirectory.Length; i++)
                {
                    filesFromOtherDirectory = filesFromMainFolder.Concat(Directory.GetFiles(allDirectory[i])).ToArray();
                    filesFromMainFolder = filesFromOtherDirectory;
                }
                allFindedFiles = filesFromOtherDirectory;
            }
            else
                allFindedFiles = filesFromMainFolder;

            return allFindedFiles;
        }


        public static List<FileClass> ParseStringToClass(List<string> allFiles)
        {
            List<FileClass> listClasses = new List<FileClass>();

            foreach (string path in allFiles)
            {
                FileClass newFile = new FileClass(path);
                listClasses.Add(newFile);
            }
            return listClasses;
        }


        //  *** find files duplicates
        public static List<List<FileClass>> FindDuplicates(List<FileClass> allFilesList)
        {
            List<List<FileClass>> ListDuplicates = new List<List<FileClass>>();
            List<FileClass> newListDuplicate = null;

            // variable for checking that do we find similar in current iteration

            for (int i = 0; i < allFilesList.Count() - 1; i++)
            {
                if (allFilesList[i].markIsDuplicate == false)
                {
                    for (int j = i + 1; j < allFilesList.Count(); j++)
                    {
                        if (allFilesList[j].markIsDuplicate != true)
                        {
                            if (allFilesList[i].NameFile == allFilesList[j].NameFile)
                            {
                                allFilesList[j].markIsDuplicate = true;
                                // for very first finding duplicates
                                if (allFilesList[i].markIsDuplicate == false)
                                {
                                    newListDuplicate = new List<FileClass>();
                                    newListDuplicate.Add(allFilesList[i]);
                                    allFilesList[i].markIsDuplicate = true;
                                    ListDuplicates.Add(newListDuplicate);
                                }
                                newListDuplicate.Add(allFilesList[j]);
                            }
                        }
                    }
                }
                else
                    continue;
            }
            return ListDuplicates;
        }

    }
}
