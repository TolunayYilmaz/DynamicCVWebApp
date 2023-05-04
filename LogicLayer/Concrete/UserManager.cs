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
        
        private int aboutId;
        public int AboutId { get { return aboutId; } }  
        //Veritabanından isim ve şifre çeker eşleşirse true döner.
        public bool LoginUser(string userName,string password)
        {
            var user= from x in dataBase.GetAll() where x.UserName == userName && x.Password== password select  x;
            if (user.Any())
            {
                aboutId = (int)user.ElementAt(0).AboutId;
                return true;
            }
            else
            {
                return false; 
            }
       

        }

        // Kayıt İşlemi yapmaktadır.
        public string SignInUser(TblUsers user,string password2)
        {
            if (user.UserName == "" || user.Password == ""|| user.Password != password2)
            {
                return "Şifreniz ile kullanıcı adınızı boş bırakmayınız. Tekrar yazılan şifrenide aynı olduğundan emin olunuz.";
            }
            else
            {
                dataBase.Insert(user);
                return "Başarılı bir şekilde kayıt olundu.";
            }


        }
    }
}
