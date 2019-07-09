using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interface.Entities;
using System.Globalization;
using Interface.Services;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a rental data: ");
            Console.WriteLine("Car model: ");
            string model = Console.ReadLine();
            Console.WriteLine("Pickup(dd/MM/yyyy hh:ss): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:ss", CultureInfo.InvariantCulture);
            Console.WriteLine("Return(dd/MM/yyyy hh:ss): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:ss", CultureInfo.InvariantCulture);

            CarRental car = new CarRental(start, finish, new Vehicle(model));

            Console.WriteLine("Price per hour: ");
            double phour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Price per day: ");
            double pday = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            RentalService rental = new RentalService(phour, pday, new BrazilTaxService());

            rental.ProcessInvoice(car);

            Console.WriteLine(car.Invoice);
        }
    }
}
