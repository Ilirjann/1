#pragma warning disable CS8618
using loginR.Models;
using Microsoft.EntityFrameworkCore;
namespace loginR.Models;
public class MyContext : DbContext 
{   
    public MyContext(DbContextOptions options) : base(options) { }    
    public DbSet<user> Users { get; set;} 
}