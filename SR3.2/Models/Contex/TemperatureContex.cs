using SR3._2.Models.Device;
using System.Data.Entity;

namespace SR3._2.Models.Contex
{
    public class TemperatureContex : DbContext
    {
        public TemperatureContex() : base("DefaultConnection") { }

        public DbSet<Temperature> Tempes { get; set; }

    }
}