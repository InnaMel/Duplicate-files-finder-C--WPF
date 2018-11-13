using InclusionMetods;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicatesFinderPlus
{
    public class DuplicatesViewModel
    {
        public ObservableCollection<EachFinedListDublicates> HaveFoundDublicatesDivide { get; set; }

        public DuplicatesViewModel()
        {
            HaveFoundDublicatesDivide = new ObservableCollection<EachFinedListDublicates>();
        }

        public void Divide(ObservableCollection<ObservableCollection<FileClass>> haveFoundDublicates)
        {
            HaveFoundDublicatesDivide.Clear();
            foreach (var d in haveFoundDublicates)
            {
                EachFinedListDublicates entry = new EachFinedListDublicates();
                entry.CommonName = d[0].NameFile;
                entry.CommonDuplicates = d;
                HaveFoundDublicatesDivide.Add(entry);
            }
        }
    }
}
