using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using M3P_BackEnd_Squad1.Models;

namespace M3P_BackEnd_Squad1.Interfaces.Repositories
{
    public interface ILoginRepository : IBaseRepository<User, int>
    {
        public User GetUserEmail(string email);
    }
}