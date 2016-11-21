namespace SR3._2.Models.Device
{
    public class Boiler : Temperature
    {
        public Boiler() { }
        public Boiler(bool state, int max, int min, int temp)
            : base(max, min, temp)
        {        }

        public override string ToString()
        {

            return "Котел - состояние: ";
        }
    }
}