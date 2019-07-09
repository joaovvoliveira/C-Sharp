using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = "Good Morning Students";
            Console.WriteLine(frase.Cut(12));
            
            DateTime dt = new DateTime(2019, 07, 04, 21, 02, 00);
            Console.WriteLine(dt.ElapsedTime());
        }
    }
}
