using DataAccessLayer.Concrete;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.Concrete
{
    public class WorkManager
    {
        Repository<TblWork> dataBase = new Repository<TblWork>();

        //Çalışılan yerlerin listesini getirir.
        public List<TblWork> WorkGetList()
        {
            return dataBase.GetAll();
        }
    }
}
