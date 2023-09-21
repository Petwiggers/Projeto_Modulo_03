using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using M3P_BackEnd_Squad1.Models.Enums;

namespace M3P_BackEnd_Squad1.Models
{
    public class Colecoes
    {
        public string Nome { get; set; }
        public string Marca { get; set; }
        public double Orcamento { get; set; }
        public string Cor { get; set; }
        public DateTime AnoLancamento { get; set; }
        public SeasonsEnum Estacao { get; set; }
        public StatusEnum Status { get; set; }
    }
}