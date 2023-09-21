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

        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo é de preenchimento obrigatório")]
        [MaxLength(200, ErrorMessage = "O campo não deve exceder 200 caracteres")]
        public string CompanyName { get; set; }

        [Required(ErrorMessage = "O campo é de preenchimento obrigatório")]
        [RegularExpression(@"^\d{14}$", ErrorMessage = "O CNPJ deve conter 14 dígitos")]
        public string Cnpj { get; set; }

        [Required(ErrorMessage = "O campo é de preenchimento obrigatório")]
        [MaxLength(200, ErrorMessage = "O campo não deve exceder 200 caracteres")]
        public string Manager { get; set; }

        [Required(ErrorMessage = "O campo email é de preenchimento obrigatório")]
        [MaxLength(150, ErrorMessage = "O campo email não pode exceder 150 caracteres")]
        [EmailAddress(ErrorMessage = "O e-mail digitado não é válido")]
        public String Email { get; set; }

        [Required(ErrorMessage = "O campo email é de preenchimento obrigatório")]
        [MinLength(6, ErrorMessage = "A senha deve conter no minimo 6 caracteres")]
        public String Password { get; set; }


    }
}
