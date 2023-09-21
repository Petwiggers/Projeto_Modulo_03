using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using M3P_BackEnd_Squad1.Models.Enums;

namespace M3P_BackEnd_Squad1.Models
{
    public class Modelos
    {
        public int ResponsavelID { get; set; }
        public int ColecaoID { get; set; }
        public double CustoReal { get; set; }
        public ModelType Tipo { get; set; }
        public bool Bordado { get; set; }
        public bool Estampa { get; set; }
    }
}