using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace EstudoVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantidade a alugar: ");
            int qtd = int.Parse(Console.ReadLine());

            List<Quartos> Quarto = new List<Quartos>();

            for (int i = 0; i < qtd; i++)
            {
                Console.WriteLine("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Email: ");
                string email = Console.ReadLine();
                Console.WriteLine("Quarto: ");
                string quarto = Console.ReadLine();
                Quarto.Add(new Quartos(nome, email, quarto, id));
            }

            Console.WriteLine("Digite o ID que ganhou uma diária: ");
            var iddiaria = int.Parse(Console.ReadLine());

            Quartos quar = Quarto.Find(x => x.Id == iddiaria);
            string gratis = "";
            if (quar != null)
            { 
                gratis = "O cliente de ID: " + iddiaria.ToString() + ", ganhou uma diaria";
            }
            else
            {
                gratis = "Numero inválido, ninguem ganhou";
            }
            Console.WriteLine(gratis);
            Console.WriteLine("-----");

            Console.WriteLine("Quartos ocupados: ");
            for (int q = 0; q < qtd; q++)
            {
                Console.WriteLine(Quarto[q]);
            }
        }
    }
}
