using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InclusionMetods;

namespace DuplicatesFinderPlus
{
    public class EachFinedListDublicates
    {
        public string CommonName { get; set; }
        public ObservableCollection<FileClass> CommonDuplicates { get; set; } = new ObservableCollection<FileClass>();
    }
}
