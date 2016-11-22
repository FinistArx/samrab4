namespace SR3._2.Models.Device
{
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