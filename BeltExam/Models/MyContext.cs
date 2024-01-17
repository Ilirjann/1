#pragma warning disable CS8618
using BeltExam.Models;
using Microsoft.EntityFrameworkCore;
namespace BeltExam.Models;

public class MyContext : DbContext 
{   
    public MyContext(DbContextOptions options) : base(options) { }      
    public DbSet<User> Users { get; set; }
}