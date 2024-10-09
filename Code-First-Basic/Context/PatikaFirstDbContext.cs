using Microsoft.EntityFrameworkCore;
using PatikaCodeFirst.Models;


namespace PatikaCodeFirst.Data
{
    public class PatikaFirstDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Game> Games { get; set; }

        // OnConfiguring metodunu doğru şekilde override ettiğinizden emin olun
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=PatikaCodeFirstDb1;Trusted_Connection=True;");
        }
    }
}
