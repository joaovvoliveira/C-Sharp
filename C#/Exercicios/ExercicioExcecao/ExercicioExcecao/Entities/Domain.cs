using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioExcecao.Entities
{
    class Domain : ApplicationException
    {
        public Domain(string message) : base(message)
        {

        }
    }
}
