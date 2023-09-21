using M3P_BackEnd_Squad1.Interfaces.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace M3P_BackEnd_Squad1.Models
{
    public class Company : ICompany
    {


        public int Id { get; set; }
        public String CompanyName { get; set; }
        public String Cnpj { get; set; }
        public String Manager { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }


    }
}
