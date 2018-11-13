using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InclusionMetods
{
    public class DisplayStringArrList
    {
        public static void DisplayFORStringArrList(string[] someArray)
        {
            foreach (var item in someArray)
            {
                Console.WriteLine(item);
            }
        }
        public static void DisplayFORStringArrList(List<string> someList)
        {
            foreach (var item in someList)
            {
                Console.WriteLine(item);
            }
        }
        public static void DisplayFORStringArrList(List<FileClass> someObject)
        {
            foreach (var item in someObject)
            {
                Console.WriteLine(item.getFullPath());
            }
        }
    }
}
