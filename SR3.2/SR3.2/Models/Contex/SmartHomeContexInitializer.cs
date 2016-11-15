using SR3._2.Models.Device;
using System.Data.Entity;

namespace SamRab3_2.Models.Contex
{
    public class SmartHomeContexInitializer : DropCreateDatabaseAlways<SmartHomeContex>
    {
        protected override void Seed(SmartHomeContex context)
        {
            context.Devices.Add(new Boiler { state = true, Temp = 10 });
            context.Devices.Add(new Conditioner { state = true, Temp = 20 });
            context.Devices.Add(new Fridge { state = true, Temp = 20, OpenClose = false });
            context.Devices.Add(new MC { state = true, Chennel = 111, Volume = 50 });
            context.Devices.Add(new TV { state = true, Chennel = 100, Volume = 50 });
            context.SaveChanges();
        }
    }
}
