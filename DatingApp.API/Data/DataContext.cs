using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options) {}

        public DbSet<Value> Values {get;set;}
        public DbSet<User> Users {get;set;}
        public DbSet<Photo> Photos {get;set;}

        // protected override void OnModelCreating(ModelBuilder builder)
        // {
        //     builder.Entity<User>()
        //         .HasMany(p => p.Photos)
        //         .WithOne(u => u.User)
        //         .OnDelete(DeleteBehavior.Cascade);
        // }
    }
}