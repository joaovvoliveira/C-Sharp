using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq;
using Linq.Entities;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace Linq
{
    class Program
    {
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach(T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Category c1 = new Category(1, "Tools", 2);
            Category c2 = new Category(2, "Computer", 1);
            Category c3 = new Category(3, "Eletronics", 1);

            List<Product> products = new List<Product>() {
                new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
                new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
                new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
                new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
                new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
                new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
                new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
                new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
                new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
                new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
                new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1 }
            };

            //var r1 = products.Where(x => x.Category.Tier == 1 && x.Price < 900.00);
            var r1 =
                from p in products
                where p.Category.Tier == 1 && p.Price < 900.0
                select p;
            Print("Tier 1 and price < 900: ", r1);

            //var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            var r2 =
                from p in products
                where p.Category.Name == "Tools"
                select p.Name;
            Print("Names from Tools: ", r2);

            //var r3 = products.Where(y => y.Name[0] == 'C').Select(y => new { y.Name, y.Price, CategoryName = y.Category.Name });
            var r3 =
                from p in products
                where p.Name[0] == 'C'
                select new
                {
                    p.Name,
                    p.Price,
                    CategoryName = p.Category.Name
                }; 
            Print("First letter as 'C': ", r3);

            //var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            var r4 =
                from p in products
                where p.Category.Tier == 1
                orderby p.Price, p.Name
                select p;
            Print("Tier 1 for price and name: ", r4);

            //var r5 = r4.Skip(2).Take(4);
            var r5 =
                (from p in r4
                 select p).Skip(2).Take(4);

            Print("Tier 1 for price and name, skip 2, take 4: ", r5);

            var r6 = products.FirstOrDefault();
            Console.WriteLine("FIRST OR DEFAULT: " + r6);

            //var r7 = products.Where(p => p.Price > 3000.00).FirstOrDefault();
            var r7 =
                (from p in products
                 where p.Price > 3000.0
                 select p).FirstOrDefault();
            Console.WriteLine("FIRST OR DEFAULT: " + r7);
            Console.WriteLine();

            //var r8 = products.Where(p => p.Id == 2).SingleOrDefault();
            var r8 =
                (from p in products
                 where p.Id == 2
                 select p).SingleOrDefault();
            Console.WriteLine(r8);
            Console.WriteLine();

            var r9 = products.Max(p => p.Price);
            Console.WriteLine(r9);
            var r10 = products.Min(p => p.Price);
            Console.WriteLine(r10);
            Console.WriteLine();

            //var r11 = products.Where(x => x.Category.Id == 1).Sum(x => x.Price);
            var r11 =
                (from p in products
                 where p.Category.Id == 1
                 select p).Sum(p => p.Price);
            Console.WriteLine("Total price category 1: " + r11);
            Console.WriteLine();

            //var r12 = products.Where(x => x.Category.Id == 3).Average(x => x.Price);
            var r12 =
                (from p in products
                 where p.Category.Id == 3
                 select p).Average(x => x.Price);
            Console.WriteLine("Media price category 3: " + r12);
            Console.WriteLine();

            //var r13 = products.Where(x => x.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            var r13 =
                (from p in products
                 where p.Category.Id == 5
                 select p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Media price category 5(Em caso de inexistente, valor 0): " + r13);

            var r14 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).Aggregate(0.0,(x, y) => x + y);
            Console.WriteLine("Category + Sum: " + r14);
            Console.WriteLine();

            //var r15 = products.GroupBy(p => p.Category);
            var r15 =
                from p in products
                group p by p.Category;
            foreach (IGrouping<Category,Product> group in r15)
            {
                Console.WriteLine("Category: " + group.Key.Name + ":");
                foreach(Product obj in group)
                {
                    Console.WriteLine(obj);
                }
                Console.WriteLine();
            }


            /*Specify the Data Source

            int[] vetor = new int[] { 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Define the Query expression
            var result = vetor.Where(x => x % 2 == 0).Select(x => x * 10);

            //Execute the Query
            foreach(int obj in result)
            {
                Console.WriteLine(obj);
            }
            */


        }
    }
}
