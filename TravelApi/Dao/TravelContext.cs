using Microsoft.EntityFrameworkCore;
using TravelApi.Models;

namespace TravelApi.Dao
{
    public class TravelContext : DbContext{
        public TravelContext(DbContextOptions<TravelContext> options) : base(options){
            this.Database.EnsureCreated();
        }

        public DbSet<User> Users{get; set;}
        public DbSet<Site> Sites{get; set;}
        public DbSet<Route> Routes{get; set;}
        public DbSet<Diary> Diaries{get; set;}
        public DbSet<Task> Tasks{get; set;}
        public DbSet<Travel> Travels{get; set;}
        
    }
}