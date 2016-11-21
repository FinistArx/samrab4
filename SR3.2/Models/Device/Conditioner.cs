
namespace SR3._2.Models.Device
{
    public class Conditioner : Temperature
    {
        public Conditioner() { }
        public Conditioner(bool state, int max, int min, int temp)
            : base(max, min, temp)
        {        }

        public override string ToString()
        {
            return "Кондиционер : состояние: ";
        }
    }
}