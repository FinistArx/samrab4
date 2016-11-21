using SR3._2.Models.Device;
using System.Data.Entity;

namespace SR3._2.Models.Contex
{
    public class FridgeContex : DbContext
    {
        public FridgeContex() : base("DefaultConnection") { }
        public DbSet<Fridge> Fredges { get; set; }
    }
}