using System;

namespace M3P_BackEnd_Squad1.Interfaces.Models
{
    public interface ICompany
    {
        int Id { get; set; }
        string CompanyName { get; set; }
        string Cnpj { get; set; }
        string Manager { get; set; }
        string Email { get; set; }
        string Password { get; set; }
    }
}
