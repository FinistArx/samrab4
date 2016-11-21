using SR3._2.Models.Interfaces;

namespace SR3._2.Models.Device
{
    public abstract class Temperature : AbstractDevice, IRegulatorTemp
    {
        public int max;
        public int min;
        public int temp;
        public Temperature() { }
        public Temperature(int max, int min, int temp)
        {
            this.temp = temp;
            this.max = max;
            this.min = min;
        }

        public int Temp
        {
            get
            { return temp; }
            set
            {
                if (value <= max && value >= min)
                { temp = value; }
            }
        }
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