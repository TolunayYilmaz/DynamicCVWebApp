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

        //Tüm Adresleri getirir.
        public List<TblAddress> AddressGetList()
        {
            return dataBase.GetAll();
        }

        //Gönderilen adresi siler.
        public int DeleteAddress(TblAddress address)
        {
            return dataBase.Delete(address);

        }

        // Idsi verilen kulanıcının adreslerini getirir.
        public List<TblAddress> AddressGet(int id)
        {
            List<TblAddress> addresses = new List<TblAddress>();
            addresses.Add(dataBase.GetByObj(id));
            return addresses;
        }
        //1 den büyük olma şartı vardır tek adres getirir.
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

        //Gönderilen adres ve ıd bilgilerne göre güncelleme yapar.
        public int UpdateAddress(int Id,TblAddress address)
        {
            TblAddress tblAddress= GetAddress(Id);
            tblAddress.Address = address.Address;
            tblAddress.Phone = address.Phone;
            tblAddress.Location= address.Location;
            tblAddress.Mail = address.Mail;
            return dataBase.Update();

        }

        // Yeni adres ekler.
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
