using DataAccessLayer.Concrete;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.Concrete
{
    public class TalentUserManager
    {
        private readonly Repository<TblTalentUser> dataBase = new Repository<TblTalentUser>();
        List<TblTalent> list;
        public List<TblTalent> GetListTalent(int userId)
        {
           list = new List<TblTalent>();
            var query = from x in dataBase.GetAll()
                        where x.UserId == userId
                        select x.Talent;

            list.AddRange(query);
          

            return list;

        }
        public int GetListTalentCount(int userId)
        {
             list = new List<TblTalent>();
            var query = from x in dataBase.GetAll()
                        where x.UserId == userId
                        select x.Talent;

            list.AddRange(query);
            return list.Count;

        }
        public void AddTalentUser(int talentId,int userId)
        {
            TblTalentUser tblTalentUser = new TblTalentUser()
            {
                TalentId = talentId,
                UserId = userId
            };
         
            if (tblTalentUser.TalentId>=1  && tblTalentUser.UserId>=1)
            {
                dataBase.Insert(tblTalentUser);
            }
            else
            {
                return;
            }
            
        }

        public TblTalentUser GetUser(int id)
        {
           return dataBase.GetByObj(id);
        }
        public void DelteTalentUser(int talenId)
        {
            var query = from x in dataBase.GetAll()
                        where x.TalentId == talenId
                        select x;
            int id = (int)query.ElementAt(0).Id;
            if (id>= 1)
           {
               dataBase.Delete(GetUser(id));
           }
           else
           {
               return;
           }

        }
    }
}
