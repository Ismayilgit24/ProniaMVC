using Microsoft.EntityFrameworkCore;
using ProniaApplication.Models;

namespace ProniaApplication.DAL
{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options):base(options) { }

        public DbSet<Slide> Slides { get; set; }
    }
}
