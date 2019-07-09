using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using ExercicioResolvido08_07.Entities;
using System.IO;
using System.Globalization;
namespace ExercicioResolvido08_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o caminho do arquivo: ");
            string path = Console.ReadLine();

            List<Product> list = new List<Product>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string Name = fields[0];
                    double Price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                    list.Add(new Product(Name, Price));
                }
            }

            var r1 =
                (from p in list
                 select p.Price).Average();
            Console.Write("Average Price: " + r1.ToString("F2", CultureInfo.InvariantCulture));

            var r2 = list.Where(p => p.Price < r1).OrderByDescending(p => p.Name).Select(p => p.Name);

            foreach (string obj in r2)
            {
                Console.WriteLine(obj);
            }
            
        }
    }
}

