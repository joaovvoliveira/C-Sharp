using System;
using System.Collections.Generic;
using System.Globalization;
using Revisao.Entidades;
using Revisao.Entidades.Enums;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o nome do departamento: ");
            string departamento = Console.ReadLine();
            Console.WriteLine("Data de trabalho: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Nivel: ");
            NivelTrabalhador Nivel = Enum.Parse<NivelTrabalhador>(Console.ReadLine());
            Console.WriteLine("Base salarial: ");
            double basesalario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Departamento dept = new Departamento(departamento);
            Trabalhador trab = new Trabalhador(nome, Nivel, basesalario, dept);

            Console.WriteLine("Quanto cadastro serão realizados: ");
            int qtd = int.Parse(Console.ReadLine());
            for (int i = 1; i <= qtd; i++)
            {
                Console.WriteLine("Entre com os dados do contrato #" + i);
                Console.WriteLine("Data (DD/MM/YYY): ");
                DateTime datacontrato = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Valor por hora: ");
                double hora = double.Parse(Console.ReadLine());
                Console.WriteLine("Quantidade de horas: ");
                int qtdhoras = int.Parse(Console.ReadLine());
                HorasContrato horas = new HorasContrato(datacontrato, hora, qtdhoras);
                trab.AdicionarContrato(horas);
            }

            Console.WriteLine("Entre com o mês/ano para calcular: ");
            string mesano = Console.ReadLine();
            int mes = int.Parse(mesano.Substring(0, 2));
            int ano = int.Parse(mesano.Substring(3));
            Console.WriteLine("Nome: "+ trab.Nome);
            Console.WriteLine("Departamento: " + trab.Departamento.Setor);
            Console.WriteLine("Valor: " + trab.GanhoTotal(ano,mes));

        }
    }
}
