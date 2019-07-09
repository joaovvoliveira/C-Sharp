using System;

namespace Revisao.Entidades
{
    class HorasContrato
    {
        public DateTime Data { get; set; }
        public double ValorHora { get; set; }
        public int HorasTrabalhadas { get; set; }

        public HorasContrato()
        {
        }

        public HorasContrato(DateTime data, double valorHora, int horasTrabalhadas)
        {
            Data = data;
            ValorHora = valorHora;
            HorasTrabalhadas = horasTrabalhadas;
        }

        public double TotalHoras()
        {
            return ValorHora * HorasTrabalhadas;
        }

    }
}
