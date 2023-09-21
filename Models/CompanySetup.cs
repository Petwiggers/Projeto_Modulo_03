using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using M3P_BackEnd_Squad1.Models.Enums;

namespace M3P_BackEnd_Squad1.Models
{
    public class CompanySetup
    {
        public int Id { get; set; }
        public ThemeEnum Tema { get; set; }
        public string Logo { get; set; }
        public int CompanyID { get; set; }
    }
}