using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.SQL
{
    public class DataContext : DbContext
    {
        public DbSet<Users> User { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = WpfApp1.db");
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
