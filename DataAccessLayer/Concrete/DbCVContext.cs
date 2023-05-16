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
        public DbSet<TblTalentUser> TblTalentUsers { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TblUsers>()
            .HasOptional(s => s.Address)
            .WithMany(d => d.TblUsers)
            .HasForeignKey(s => s.AddressesId);

            modelBuilder.Entity<TblUsers>()
            .HasOptional(s => s.About)
            .WithMany(d => d.TblUsers)
            .HasForeignKey(s => s.AboutId);

            //modelBuilder.Entity<TblTalentUser>()
            //    .HasOptional(s => s.Talent)
            //    .WithMany(d => d.TblTalentUsers)
            //    .HasForeignKey(s => s.TalentId);

            //modelBuilder.Entity<TblTalentUser>()
            // .HasOptional(s => s.User)
            // .WithMany(d => d.TblTalentUsers)
            // .HasForeignKey(s => s.UserId);

            modelBuilder.Entity<TblTalentUser>()
       .HasRequired(s => s.Talent)
       .WithMany(d => d.TblTalentUsers)
       .HasForeignKey(s => s.TalentId);

          modelBuilder.Entity<TblTalentUser>()
                .HasRequired(s => s.User)
                .WithMany(d => d.TblTalentUsers)
                .HasForeignKey(s => s.UserId);
        }
    }
}
