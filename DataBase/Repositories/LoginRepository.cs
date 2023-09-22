using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using M3P_BackEnd_Squad1.Interfaces.Repositories;
using M3P_BackEnd_Squad1.Models;

namespace M3P_BackEnd_Squad1.DataBase.Repositories
{
    public class LoginRepository : BaseRepository<User, int>, ILoginRepository
    {
        public LabClothingCollectionDbContext _contexto;
        public LoginRepository(LabClothingCollectionDbContext contexto) : base(contexto)
        {
            _contexto = contexto;
        }
        public User GetUserEmail(string email)
        {
            return _context.Set<User>().FirstOrDefault(x => x.Email == email);
        }
    }
}