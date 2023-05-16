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
        List<TblAbout> abouts;
        private int aboutId;
        public int AboutId { get { return aboutId; } }

        private int userId;
        public int UserId { get { return userId; } }

        private byte addressId;
        public byte AddressId { get { return addressId; } }
        //Veritabanından isim ve şifre çeker eşleşirse true döner.
        public bool LoginUser(string userName,string password)
        {
            var user= from x in dataBase.GetAll() where x.UserName == userName && x.Password== password select  x;
            if (user.Any())
            {
                aboutId = (int)user.ElementAt(0).AboutId;
                addressId = (byte)user.ElementAt(0).AddressesId;
                userId = (int)user.ElementAt(0).Id;
                return true;
            }
            else
            {
                return false; 
            }
       

        }
        public List<TblAbout> GetAbout(int id)
        {
            abouts = new List<TblAbout>();
            abouts.Add(dataBase.GetByObj(id).About);
            return abouts ;
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
        public int GetAboutCount(int userId)
        {
            abouts = new List<TblAbout>();
            abouts.Add(dataBase.GetByObj(userId).About);
            return abouts.Count;
        }
    }
}
