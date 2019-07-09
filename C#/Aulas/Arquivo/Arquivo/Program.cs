using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Arquivo
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourchPath = @"c:\users\jvict\music\file1.txt";
            string path = @"c:\users\jvict\music\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourchPath);
                using (StreamWriter sw = File.AppendText(path))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("Ocorreu um erro");
                Console.WriteLine(e.Message);
            }


        }
    }
}
