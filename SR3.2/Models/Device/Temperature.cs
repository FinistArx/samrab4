using SR3._2.Models.Interfaces;

namespace SR3._2.Models.Device
{
    public abstract class Temperature : AbstractDevice, IRegulatorTemp
    {
        public int max;
        public int min;
        public int temp;
        public Temperature() { }
        public Temperature( int Temp )
        {         }
        public int Temp
        { get; set; }
        public void DecreaseTemp()
        {
            Temp--;
        }

        public void IncreaseTemp()
        {
            Temp++;
        }
 
    }
}