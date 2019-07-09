using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> lista = new List<Product>();

            Console.WriteLine("How Many Products : ");
            int n = int.Parse(Console.ReadLine());
            char tipo = 'a';
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.WriteLine("Common, used or imported (c/u/i): ");
                tipo = char.Parse(Console.ReadLine());

                Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(tipo == 'c')
                {
                    lista.Add(new Product(name, price));
                }
                else if (tipo == 'u')
                {
                    Console.WriteLine("Manufactured Date(DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    lista.Add(new UsedProduct(name, price, date));
                }
                else
                {
                    Console.WriteLine("Customfee: ");
                    double custom = double.Parse(Console.ReadLine());
                    lista.Add(new ImportedProduct(name, price, custom));
                }

                Console.WriteLine("PRICE TAGS: ");
                foreach(Product obj in lista)
                {
                    Console.WriteLine(obj.PriceTag());
                }

        }

    }
}
}
