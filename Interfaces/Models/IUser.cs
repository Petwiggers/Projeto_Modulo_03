using M3P_BackEnd_Squad1.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace M3P_BackEnd_Squad1.Interfaces.Models
{
    public interface IUser
    {
        int Id { get; set; }
        String Name { get; set; }
        String Email { get; set; }
        EnumRole Role { get; set; }
    }
}
