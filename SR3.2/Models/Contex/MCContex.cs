using SR3._2.Models.Device;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SR3._2.Models.Contex
{
    public class MCContex : DbContext
    {
        public MCContex() : base("DefaultConnection") { }
        public DbSet<MC> MCs { get; set; }
    }
}