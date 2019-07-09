using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lambda_Delegates.Entities;

namespace Lambda_Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("tv", 900.00));
            list.Add(new Product("mouse", 50.00));
            list.Add(new Product("tablet", 350.50));
            list.Add(new Product("HD case", 80.90));

            //Func<Product, string> func = NameUpper;

            //Func<Product, string> func = p => p.Name.ToUpper();

            List<string> result = list.Select(p => p.Name.ToUpper()).ToList();
            
            foreach (string obj in result)
            {
                Console.WriteLine(obj);
            }
        }
        /*
        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }
        */


    }
}
