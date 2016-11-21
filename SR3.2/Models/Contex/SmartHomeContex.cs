using SR3._2.Models.Device;
using System.Data.Entity;

namespace SamRab3_2.Models.Contex
{
    public class SmartHomeContex : DbContext
    {
        public SmartHomeContex() : base("SmartConnection") { }

        public DbSet<AbstractDevice> Devices { get; set; }

       
        static SmartHomeContex()
        {
            Database.SetInitializer(new SmartHomeContexInitializer());
        }
        //public DbSet<Boiler> Boilers { get; set; }
        //public DbSet<Conditioner> Conds { get; set; }
        //public DbSet<Fridge> Fredges { get; set; }
        //public DbSet<MC> MCs { get; set; }
        //public DbSet<TV> TVs { get; set; }
    }
}