using SR3._2.Models.Device;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SR3._2.Models.Contex
{
    public class BoilerContex : DbContext
    {
        public BoilerContex() : base("DefaultConnection") { }

        public DbSet<Boiler> Boilers { get; set; }
        static BoilerContex()
        {
            Database.SetInitializer(new BoilerContexInitializer());
        }
    }
}