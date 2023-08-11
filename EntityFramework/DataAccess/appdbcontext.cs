using EntityFramework.Entities;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework.DataAccess;
public class appdbcontext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=TITAN06\\SQLEXPRESS;Initial Catalog=TestDb;Trusted_Connection=true");
    }
    public DbSet<Employee> Employees { get; set; }
}