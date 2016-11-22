using SR3._2.Models.Device;
using System.Data.Entity;

namespace SamRab3_2.Models.Contex
{
    public class SmartHomeContexInitializer : DropCreateDatabaseAlways<SmartHomeContex>
    {
        protected override void Seed(SmartHomeContex context)
        {
            context.Devices.Add(new Boiler { Id = 1, state = true, Temp = 23});
            context.Devices.Add(new Conditioner { Id = 2, state = true, Temp = 20 });
            context.Devices.Add(new Fridge { Id = 3, state = true, OpenClose = false, Temp = -5 });
            context.Devices.Add(new MC { Id = 4, state = true, chennel = 20, volume = 65 });
            context.Devices.Add(new TV { Id = 5, state = true, chennel = 70, volume = 55 });
            context.SaveChanges();
        }
    }
}
