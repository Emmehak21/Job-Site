using jobHunt.Models;
using Microsoft.EntityFrameworkCore;

namespace jobHunt.Data
{
    public class DbContextClass:DbContext
    {
        public DbContextClass(DbContextOptions<DbContextClass> options):base(options) { }
        public DbSet<Registeruser> reg
        { get; set; }
    }
}
