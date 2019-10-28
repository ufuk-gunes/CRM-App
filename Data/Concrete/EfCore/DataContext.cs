using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MixCRM.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Firma> Firmas { get; set; }
        public DbSet<Departman> Departmen { get; set; }
        public DbSet<Kategori> Kategoris { get; set; }
        public DbSet<Personel> Personels { get; set; }
        public DbSet<Musteri> Musteris { get; set; }
        public DbSet<Satis> Satis { get; set; }
        public DbSet<Stok> Stoks { get; set; }
        public DbSet<Teklif> Teklifs { get; set; }
        public DbSet<Urun> Uruns { get; set; }

    
}
}
