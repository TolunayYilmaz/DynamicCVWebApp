using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class TblTalent
    {
        public TblTalent()
        {
            this.TblTalentUsers = new HashSet<TblTalentUser>();
        }
        public int Id { get; set; }
        public string Talent { get; set; }
        public int Grade { get; set; }

        public virtual ICollection<TblTalentUser> TblTalentUsers { get; set; }
    }
}
