using M3P_BackEnd_Squad1.Interfaces.Models;
using M3P_BackEnd_Squad1.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace M3P_BackEnd_Squad1.Models
{
    public class User : IUser
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo nome é de preenchimento obrigatório")]
        [MaxLength(200, ErrorMessage ="O campo não deve exceder 200 caracteres")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O campo email é de preenchimento obrigatório")]
        [MaxLength(200, ErrorMessage ="O campo não deve exceder 200 caracteres")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo papel é de preenchimento obrigatório")]
        public EnumRole Role { get; set; }
    }
}
