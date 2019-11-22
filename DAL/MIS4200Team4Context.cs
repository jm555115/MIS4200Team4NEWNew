using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using MIS4200Team4New.Models;

namespace MIS4200Team4New.DAL
{
    public class MIS4200Team4Context : DbContext
    {
        public MIS4200Team4Context() : base("name=DefaultConnection")
        {

         //   Database.SetInitializer(new MigrateDatabaseToLatestVersion<MIS4200Team4Context, MIS4200Team4New.Migrations.MISContext.Configuration>("DefaultConnection"));

        }
        public DbSet<Nomination> Nomination { get; set; }
        public DbSet<UserProfile> UserProfile { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            base.OnModelCreating(modelBuilder);
        }

    }
}