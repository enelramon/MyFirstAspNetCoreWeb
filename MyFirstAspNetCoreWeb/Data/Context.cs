using Microsoft.EntityFrameworkCore;
using MyFirstAspNetCoreWeb.Models;
using Microsoft.Extensions.Configuration;
namespace MyFirstAspNetCoreWeb.Data
{
    public class Context : DbContext
    {
        public DbSet<Customers> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = (Local); Database = TestDb; Trusted_Connection = True;");
        }
        //public Context(DbContextOptions<Context> options) : base(options)
        //{
        //} 

    }
}
