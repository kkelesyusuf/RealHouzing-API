using Microsoft.EntityFrameworkCore;
using RealHouzing.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHouzing.DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-MM84V2T\\SQLEXPRESS;initial catalog=DBRealHouzingApi;integrated security=true");
        }
        DbSet<Category> Categories { get; set; }
        DbSet<Product> Products { get; set; }
    }
}
