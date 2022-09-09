using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoparkProjesi.Class
{
    public class OtoparkDbContext:DbContext
    {

        public DbSet<Marka> Marka { get; set; }
        public DbSet<Tur> Tur { get; set; }
        public DbSet<AracParkYerleri> AracParkYerleri { get; set; }
        public DbSet<Musteri> Musteri { get; set; }
        public DbSet<AracParkBilgileri> AracParkBilgileri { get; set; }
        public DbSet<Ucret> Ucret { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }


    }
}
