using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExercicioLista
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BOM DIA");
            List<Funcionario> funcionario = new List<Funcionario>();

            Console.WriteLine("Digite o numero: ");
            int quantidade = int.Parse(Console.ReadLine());

            for (int n = 1; n <= quantidade; n++)
            {
                Console.WriteLine("Funcionario# " + n);
                Console.WriteLine("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Salario: ",CultureInfo.InvariantCulture);
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Idade: ");
                int idade = int.Parse(Console.ReadLine());
                funcionario.Add(new Funcionario(id, nome, salario, idade));
            }

            Console.WriteLine("Digite o ID que aumentara: ");
            int identificador = int.Parse(Console.ReadLine());

            Funcionario func = funcionario.Find(x => x.ID == identificador);
            if(func != null)
            {
                Console.WriteLine("Porcentagem de aumento: ");
                int porcentagem = int.Parse(Console.ReadLine());
                func.Aumentar(porcentagem);
            }
            else
            {
                Console.WriteLine("Esse id não existe");
            }

            foreach(Funcionario obj in funcionario)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
