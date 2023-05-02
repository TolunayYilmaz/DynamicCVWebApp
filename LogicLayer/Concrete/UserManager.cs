using DataAccessLayer.Concrete;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.Concrete
{
    public class UserManager
    {
        Repository<TblUsers> dataBase = new Repository<TblUsers>();

        //Veritabanından isim ve şifre çeker eşleşirse true döner.
        public bool LoginUser(string userName,string password)
        {
            var user= from x in dataBase.GetAll() where x.UserName == userName && x.Password== password select x;
            if (user.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
       
        }
    }
}
