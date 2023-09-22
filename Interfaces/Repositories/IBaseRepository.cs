using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M3P_BackEnd_Squad1.Interfaces.Repositories
{
    public interface IBaseRepository<TModel, TChave>
    {
        public TModel Insert(TModel model);
        public TModel GetByID(TChave id);
        public TModel Update(TModel model);
        public List<TModel> GetAll();
        public void Delete(TModel model);


    }
}