using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Entidades
{
    class Departamento
    {
        public string Setor { get; set; }

        public Departamento()
        {
        }

        public Departamento(string setor)
        {
            Setor = setor;
        }
    }
}
