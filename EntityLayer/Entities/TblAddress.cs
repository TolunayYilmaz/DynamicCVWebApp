using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class TblAddress
    {
        public TblAddress()
        {
            this.TblUsers = new HashSet<TblUsers>();
        }
        public byte Id { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string Address { get; set; }
        public string Location { get; set; }
        public virtual ICollection<TblUsers> TblUsers { get; set; }
    }
}
