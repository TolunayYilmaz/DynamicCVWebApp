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
       
        //Tüm Bilgileri Listeler
        public List<TblAbout> AboutGetList()
        {
            return dataBase.GetAll();
        }
        //Id ye ait bir kişinin adını ve soyadını getirir.
        public string GetInfo(int id)
        {
            string name =dataBase.GetByObj(id).Information;
  
            return name;
        } 
    }
}
