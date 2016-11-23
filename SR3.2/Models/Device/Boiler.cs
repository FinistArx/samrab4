using System.ComponentModel.DataAnnotations.Schema;

namespace SR3._2.Models.Device
{
    [Table("Fire")]
    public class Boiler : Temperature
    {
        public Boiler() { }
        public Boiler(bool state,  int Temp)
            : base(Temp)
        {        }

        public override string ToString()
        {

            return "Котел - состояние: ";
        }
    }
}