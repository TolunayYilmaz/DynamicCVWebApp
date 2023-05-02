using DataAccessLayer.Concrete;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.Concrete
{
    public class CommunicationManager
    {
        Repository<TblCommunication> dataBase = new Repository<TblCommunication>();
        public List<TblCommunication> CommunucationGetList()
        {
            return dataBase.GetAll();
        }
        //Yeni bağlantıyı veri tabanına ekler.
        public void AddCommunucation(TblCommunication communication)
        {
            if (communication.NameSurname.Length<7||communication.Mail.Length<5||communication.Subject.Length<10||communication.Message.Length<5)
            {
                //hata
            }
            else
            {
                dataBase.Insert(communication);
            }
        }
        //İstenilen bağlantıyı veritabanından çeker.
        public TblCommunication GetCommunication(int Id)
        {
            return dataBase.GetByObj(Id);
        }
    }
}
