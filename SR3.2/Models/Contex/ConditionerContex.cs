using SR3._2.Models.Device;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SR3._2.Models.Contex
{
    public class ConditionerContex : DbContext
    {
        public ConditionerContex() : base("DefaultConnection") { }
        public DbSet<Conditioner> Conds { get; set; }
        static ConditionerContex()
        {
            Database.SetInitializer(new ConditionerContexInitializer());
        }
    }
}