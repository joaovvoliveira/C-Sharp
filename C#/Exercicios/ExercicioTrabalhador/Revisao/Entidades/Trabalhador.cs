using Revisao.Entidades.Enums;
using System.Collections.Generic;

namespace Revisao.Entidades
{
    class Trabalhador
    {
        public string Nome { get; set; }
        public NivelTrabalhador Nivel { get; set; }
        public double BaseSalario { get; set; }
        public Departamento Departamento { get; set; }
        public List<HorasContrato> Contratos { get; set; } = new List<HorasContrato>();

        public Trabalhador()
        {
        }

        public Trabalhador(string nome, NivelTrabalhador nivel, double baseSalario, Departamento departamento)
        {
            Nome = nome;
            Nivel = nivel;
            BaseSalario = baseSalario;
            Departamento = departamento;
        }

        public void AdicionarContrato(HorasContrato contrato)
        {
            Contratos.Add(contrato);
        }

        public void RemoverContrato(HorasContrato contrato)
        {
            Contratos.Remove(contrato);
        }

        public double GanhoTotal(int ano, int mes)
        {
            double soma = BaseSalario;
            foreach(HorasContrato contrato in Contratos)
            {
                if(contrato.Data.Year == ano && contrato.Data.Month == mes)
                {
                    soma += contrato.TotalHoras();
                }
            }
            return soma;
        }

    }
}
