using KiranAssesment.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
namespace KiranAssesment.DataContext
{
    public class CollectionContex : DbContext
    {
        public CollectionContex(DbContextOptions options):base(options)
        {

        }
        public DbSet<Student> students { get; set; }

        public void InsertStudent( string email, string name, DateOnly date,string gender,string language)
        {
            Database.ExecuteSqlRaw("CALL addStudent({0},{1},{2},{3},{4})", email, name, date, gender, language);
        }
    
    }
}
