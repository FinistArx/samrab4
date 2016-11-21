using SR3._2.Models.Device;
using System.Data.Entity;

namespace SR3._2.Models.Contex
{
    public class BoilerContexInitializer : DropCreateDatabaseAlways<BoilerContex>
    {
        protected override void Seed(BoilerContex context)
        {
            context.Boilers.Add(new Boiler { Id = 1, state = true, max = 90, min =10 ,temp = 23 });
        }
    }
}