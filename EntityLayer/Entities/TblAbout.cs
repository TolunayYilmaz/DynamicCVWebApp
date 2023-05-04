using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class TblAbout
    {
        public TblAbout()
        {
            this.TblUsers = new HashSet<TblUsers>();
        }
        public int Id { get; set; }
        public string Information { get; set; }
        public string Education { get; set; }
        public string Experience { get; set; }

        public virtual ICollection<TblUsers> TblUsers { get; set; }
    }
}
