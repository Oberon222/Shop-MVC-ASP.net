using Microsoft.EntityFrameworkCore;
using Shop_MVC2.Models;
using System.Data;

namespace Shop_MVC2.Data
{
  public class ApplicationDBContext : DbContext
  {
    public ApplicationDBContext(DbContextOptions options) : base(options) 
    {

    }

    public DbSet<Category> Categories { get; set; }
  }
}
