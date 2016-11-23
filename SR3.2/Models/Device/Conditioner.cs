using System.ComponentModel.DataAnnotations.Schema;

namespace SR3._2.Models.Device
{
    [Table("Cooler")]
    public class Conditioner : Temperature
    {
        public Conditioner() { }
        public Conditioner(bool state,  int Temp)
            : base( Temp)
        {        }

        public override string ToString()
        {
            return "Кондиционер : состояние: ";
        }
    }
}