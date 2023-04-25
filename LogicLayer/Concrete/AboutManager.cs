using DataAccessLayer.Concrete;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.Concrete
{
    public class AboutManager
    {
        Repository<TblAbout> dataBase = new Repository<TblAbout>();
        public List<TblAbout> AboutGetList()
        {
            return dataBase.GetAll();
        }
    }
}
