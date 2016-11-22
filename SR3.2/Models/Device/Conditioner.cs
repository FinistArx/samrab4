
namespace SR3._2.Models.Device
{
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