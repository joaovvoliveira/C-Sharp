using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using ExercicioExcecao.Entities;

namespace ExercicioExcecao
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter Account data: ");
                Console.WriteLine("Number: ");
                var number = int.Parse(Console.ReadLine());
                Console.WriteLine("Holder: ");
                var holder = Console.ReadLine();
                Console.WriteLine("Initial Balance: ");
                var inicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Limit: ");
                var limit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account account = new Account(number, holder, inicial, limit);

                Console.WriteLine("Saque desejado: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account.WithDraw(amount);
                Console.WriteLine(account);
            }
            catch(Domain e)
            {
                Console.WriteLine("ERROR! "+ e.Message);
            }

        }
    }
}
