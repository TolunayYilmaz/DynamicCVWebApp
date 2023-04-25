using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        int Update();
        int Delete(T parameter);
        int Insert(T parameter);
        T GetByObj(int id);
    }
}
