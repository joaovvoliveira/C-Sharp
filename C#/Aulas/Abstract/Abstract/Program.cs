using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract.Entities;
using Abstract.Entities.Enum;
using System.Globalization;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> lista = new List<Shape>();

            Console.WriteLine("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());
            var form = 'c';
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data: ");
                Console.WriteLine("Rectable ou Circle (R/C): ");
                form = char.Parse(Console.ReadLine());
                Console.WriteLine("Color: ");
                Color color = new Color();
                Enum.TryParse(Console.ReadLine(), out color);
                if(form == 'r' || form == 'R')
                {
                    Console.WriteLine("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lista.Add(new Rectangle(width, height, color));
                }
                else
                {
                    Console.WriteLine("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lista.Add(new Circle(radius, color));
                }
            }
            Console.WriteLine("SHAPE AREAS");
            foreach (Shape shape in lista)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
