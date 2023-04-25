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
        public List<TblTalent> TalentGetList()
        {
            return dataBase.GetAll();
        }
    }
}
