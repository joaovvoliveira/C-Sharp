using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExercicioLista
{
    public class Funcionario
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }
        public int Idade { get; set; }

        public Funcionario(int iD, string nome, double salario, int idade)
        {
            ID = iD;
            Nome = nome;
            Salario = salario;
            Idade = idade;
        }

        public void Aumentar(double porcentagem)
        {
            Salario += ((porcentagem * Salario) / 100);
        }

        public override string ToString()
        {
            return ID + " " + Nome + " " + Salario.ToString("F2",CultureInfo.InvariantCulture) + " " + Idade;
        }
    }
}
