using InclusionMetods;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DuplicatesFinderPlus
{
    public class Duplicates : ObservableCollection<ObservableCollection<FileClass>>
    { }
    public class Model
    {
        public string PathFromUser;

        // *** Convert list To Observable 
        ObservableCollection<FileClass> ConvertToObservable (List<FileClass> ListAllFilesAsClass)
        {
            ObservableCollection<FileClass> result = new ObservableCollection<FileClass>();
            foreach (FileClass i in ListAllFilesAsClass)
            {
                result.Add(i);
            }

            return result;
        }

        public Duplicates FindDuplicatesMetod()
        {
            Duplicates globalDuplicates = new Duplicates();
            if (MetodsClass.DirExists(PathFromUser))
            {
                string[] AllFiles = MetodsClass.GetAllFiles(PathFromUser);

                List<FileClass> ListAllFilesAsClass = MetodsClass.ParseStringToClass(AllFiles.ToList());

                List < List < FileClass >> ListGlobalDuplicates = MetodsClass.FindDuplicates(ListAllFilesAsClass);


                foreach (List<FileClass> y in ListGlobalDuplicates)
                {
                    globalDuplicates.Add(ConvertToObservable(y));
                }

            }
            else
                MessageBox.Show("Can't find such path");

            return globalDuplicates;
        }
    }
}
