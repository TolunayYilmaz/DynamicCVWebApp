using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class DbCVContext : DbContext
    {
        public DbSet<TblAbout> TblAbouts { get; set; }
        public DbSet<TblAddress> TblAddresses { get; set; }
        public DbSet<TblTalent> TblTalents { get; set; }
        public DbSet<TblCommunication> TblCommunications { get; set; }
        public DbSet<TblWork> TblWorks { get; set; }
        public DbSet<TblUsers> TblUsers { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
