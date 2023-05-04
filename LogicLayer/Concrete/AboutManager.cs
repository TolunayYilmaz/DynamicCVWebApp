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
        // Id si verilen kulanıcının bilgisini getirir.

        public List<TblAbout> AboutGet(int id)
        {
            List<TblAbout> abouts = new List<TblAbout>();
            abouts.Add(dataBase.GetByObj(id));
            return abouts;
        }

        //Id ye ait bir kişinin adını ve soyadını getirir.
        public string GetInfo(int id)
        {
            string name =dataBase.GetByObj(id).Information;
  
            return name;
        }
        public string GetExperience(int id)
        {
            string experience = dataBase.GetByObj(id).Experience;

            return experience;
        }
        public int UpdateExperience(int Id, TblAbout tblAbout)
        {
            TblAbout about = dataBase.GetByObj(Id);
            about.Experience = tblAbout.Experience;
            return dataBase.Update();
        }
        public void AboutExprienceDelete(int aboutID)
        {
           //dataBase.Delete(dataBase.GetByObj(aboutID));
            var entityToUpdate = dataBase.GetByObj(aboutID);
            if (entityToUpdate != null)
            {
                entityToUpdate.Experience = null; // Burada "YourColumn" silmek istediğiniz verinin bulunduğu sütunun adıdır.
                dataBase.Update();
            }
        }

        // Yeni deneyim ekler en az 50 karakterli olması index 0 dan başlar.5 index 6. karaktere denktir.
        public bool AddAboutExperience(TblAbout about)
        {
            if (about.Experience.Length < 50)
            {
                return false;
            }
            else
            {
                dataBase.Insert(about);
                return true;
            }
        }
    }
}
