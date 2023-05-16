using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class TblUsers
    {
        public TblUsers()
        {
            this.TblTalentUsers = new HashSet<TblTalentUser>();
        }
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Nullable<int> AboutId { get; set; }
        public Nullable<byte> AddressesId { get; set; }
        public virtual TblAbout About { get; set; }
        public virtual TblAddress Address { get; set; }

        public virtual ICollection<TblTalentUser> TblTalentUsers { get; set; }
    }
}
