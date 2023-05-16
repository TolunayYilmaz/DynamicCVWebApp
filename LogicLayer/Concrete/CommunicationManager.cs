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
        List<string> message;
        public List<TblCommunication> CommunucationGetList(int userId)
        {
            if (userId >= 1)
            {
                List<TblCommunication> communucations = new List<TblCommunication>();
                var communication = from x in dataBase.GetAll()
                            where x.UserId == userId
                            select x;
                communucations.AddRange(communication);
                return communucations;

            }
            else
            {
                return null;
            }
          
        }
        //Yeni bağlantıyı veri tabanına ekler.
        public string AddCommunucation(TblCommunication communication)
        {
            if (communication.NameSurname.Length<7||communication.Mail.Length<5||communication.Subject.Length<10||communication.Message.Length<5)
            {
                return "Mesajınız Gönderilemedi";
            }
            else
            {
                dataBase.Insert(communication);
                return "Mesajınız Gönderildi";
            }
        }
        //İstenilen bağlantıyı veritabanından çeker.
        public TblCommunication GetCommunication(int Id)
        {
            return dataBase.GetByObj(Id);
        }
        public int MessageCount(int userId)
        {
            message = new List<string>();
            var data=   from x in dataBase.GetAll()
            where x.UserId == userId
            select x.Message;
            message.AddRange(data);
            return message.Count;
        }
    }
}
