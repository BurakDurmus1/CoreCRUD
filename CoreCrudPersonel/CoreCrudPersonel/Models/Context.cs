using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCrudPersonel.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-NGNK808;database=corePersonelBirim;integrated security = true;");
        }
        public DbSet<Birim> Birims { get; set; }
        public DbSet<Personel> Personels { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}
