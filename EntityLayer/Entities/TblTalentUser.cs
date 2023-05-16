using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class TblTalentUser
    {
        public int Id { get; set; }
        public int TalentId { get; set; }

        public int UserId { get; set; }

        public virtual TblTalent Talent { get; set; }
        public virtual TblUsers User { get; set; }
    }
}
