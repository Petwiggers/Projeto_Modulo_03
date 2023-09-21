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
        public int Id { get; set; }
        public String Name { get; set; }
        public String Email { get; set; }
        public EnumRole Role { get; set; }
    }
}
