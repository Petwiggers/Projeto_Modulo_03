using System;

namespace M3P_BackEnd_Squad1.Interfaces.Models
{
    public interface ICompany
    {
        int Id { get; set; }
        String Name { get; set; }
        String Cnpj { get; set; }
        String Manager { get; set; }
        String Email { get; set; }
        String Password { get; set; }
    }
}
