using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InclusionMetods
{
    public class FileClass
    {
        public string NameFile { get; set; }
        public string PathFile { get; set; }

        public bool markIsDuplicate = false;

        public FileClass()
        {

        }

        public FileClass(string pathAsOnePiece)
        {
                this.NameFile = System.IO.Path.GetFileName(pathAsOnePiece);
                this.PathFile = System.IO.Path.GetDirectoryName(pathAsOnePiece);
        }

        public string getFullPath()
        {
            return PathFile + @"\\" + NameFile;
        }
    }
}
