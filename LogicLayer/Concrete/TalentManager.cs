using DataAccessLayer.Concrete;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.Concrete
{
    public class TalentManager
    {
        Repository<TblTalent> dataBase = new Repository<TblTalent>();
        
        //Tüm yetenekleri getirir.
        public List<TblTalent> TalentGetList()
        {
            return dataBase.GetAll();
        }

        // Yeni yetenek ekler en az 6 karakterli olması index 0 dan başlar.5 index 6. karaktere denktir.
        public void AddTalent(TblTalent talent)
        {
            if (talent.Talent.Length < 4)
            {
                //hata
            }
            else
            {
                dataBase.Insert(talent);
            }
        }
        public void DeleteTalent(int talentID)
        {
            dataBase.Delete(dataBase.GetByObj(talentID));
        }

        //Verilen Id göre gönderilen Talent birlikte değişim gerçekleşir.
        public int UpdateTalent(int talentID,TblTalent talentUpdate)
        {
            TblTalent talent = dataBase.GetByObj(talentID);
            talent.Talent = talentUpdate.Talent;
            talent.Grade = talentUpdate.Grade;
            return dataBase.Update();
        }
        public TblTalent GetTalent(int talentID)
        {
          return  dataBase.GetByObj(talentID);
        }
        public TblTalent LastGetTalent()
        {
            return dataBase.GetAll().Last();
        }

        //Ortalama puan getirir.
        public string AvarageGrade()
        {
            var data= dataBase.GetAll();
            return data.Average(x => x.Grade).ToString();
        }
        //En yüksek puana denk gelen yeteneği getirir.
        public string MaxTalent()
        {
            var data = dataBase.GetAll();
            var talent = (from z in data
                          where z.Grade == data.Max(y => y.Grade)
                          select z.Talent).FirstOrDefault();
            return talent  != null ? "En iyi Yetenek: " + talent : "Yetenek bulunamadı";
        }
        // En yüksek puanı getirir.
        public string MaxGrade()
        {
            var data = dataBase.GetAll();
            string talent = data.Max(y => y.Grade).ToString();
            return talent;
        }
    }
}
