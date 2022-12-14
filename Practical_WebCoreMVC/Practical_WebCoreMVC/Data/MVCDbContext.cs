using Microsoft.EntityFrameworkCore;
using Practical_WebCoreMVC.Models.Domain;

namespace Practical_WebCoreMVC.Data
{

    public class MVCDbContext : DbContext
    {
        public MVCDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Exam> Exams { get; set; }
    }



}
