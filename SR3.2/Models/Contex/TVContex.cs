using SR3._2.Models.Device;
using System.Data.Entity;

namespace SR3._2.Models.Contex
{
    public class TVContex : DbContext

    {
        public TVContex() : base("DefaultConnection") { }
        public DbSet<TV> TVs { get; set; }
    }
}