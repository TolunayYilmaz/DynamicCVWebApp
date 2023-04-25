using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Repository<T> : IRepository<T> where T : class
    {
        DbCVContext context = new DbCVContext();
        DbSet<T> objectDal;

      public  Repository()
        {
            objectDal = context.Set<T>(); 
        }

        public int Delete(T parameter)
        {
            objectDal.Remove(parameter);
            return context.SaveChanges();
               
        }

        public List<T> GetAll()
        {

            return objectDal.ToList();
        }

        public T GetByObj(int id)
        {
            return objectDal.Find(id);
        }

        public int Insert(T parameter)
        {
            objectDal.Add(parameter);
            return context.SaveChanges();

        }

        public int Update()
        {
           return context.SaveChanges();
        }
    }
}
