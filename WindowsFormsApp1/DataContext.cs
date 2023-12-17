using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Contexts;

namespace WindowsFormsApp1
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = DataBase.db");
        }

        public DbSet<Trait> Traits { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Gold_Augment> GoldAugments { get; set; }
        public DbSet<Silver_Augment> SilverAugments { get; set; }
        public DbSet<Prismatic_Augment> PrismaticAugments { get; set; }
    }
}
