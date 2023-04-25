using DataAccessLayer.Concrete;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.Concrete
{
    public class AddressManager
    {
        Repository<TblAddress> dataBase = new Repository<TblAddress>();

        public List<TblAddress> AddressGetList()
        {
            return dataBase.GetAll();
        }

        public int DeleteAddress(TblAddress address)
        {
            return dataBase.Delete(address);

        }
        public TblAddress GetAddress(int id)
        { 
                if (id > 0)
                {
                    return dataBase.GetByObj(id);
                }
                else
                {
                    return null;
                }
        }

        public int UpdateAddress(int Id,TblAddress address)
        {
            TblAddress tblAddress= GetAddress(Id);
            tblAddress.Address = address.Address;
            tblAddress.Phone = address.Phone;
            tblAddress.Location= address.Location;
            tblAddress.Mail = address.Mail;
            return dataBase.Update();

        }
        public int AddAddress(TblAddress address)
        {
            if (address.Address == "" || address.Mail == "")
            {
                return 0;


            }
            else
            {
                return dataBase.Insert(address);
            }

        }
    }
}
