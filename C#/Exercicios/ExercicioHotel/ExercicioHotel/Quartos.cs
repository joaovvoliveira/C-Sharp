using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoVetores
{
    public class Quartos
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Quarto { get; set; }
        public int Id { get; set; }

        public Quartos(string nome, string email, string quarto, int id)
        {
            Nome = nome;
            Email = email;
            Quarto = quarto;
            Id = id;
        }

        public override string ToString()
        {
            return "ID: "+ Id + " Quarto " + Quarto + " está o " + Nome +
                ", e o email dele é: " + Email + "";
        }
    }
}
