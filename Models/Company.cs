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
        public string CompanyName { get; set; }
        public string Cnpj { get; set; }
        public string Manager { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }


    }
}
