using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    static class StringExtension
    {
        public static string Cut(this string cut, int num)
        {
            if(cut.Length <= num)
            {
                return cut;
            }
            else
            {
                return cut.Substring(0, num) + "...";
            }
        }
    }
}
