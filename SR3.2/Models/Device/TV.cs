using SR3._2.Models.Interfaces;

namespace SR3._2.Models.Device
{
    public class TV : AbstractDevice, IVolume, IChangeChennel
    {
        public int chennel;
        public int volume;
        public TV() { }
        public TV(bool state, int chennel, int volume)
        {
            this.volume = volume;
            this.chennel = chennel;
        }

        public int Chennel
        {
            get { return chennel; }
            set { chennel = value; }
        }

        public int Volume
        {
            get { return volume; }
            set { volume = value; }
        }

        public void NextChennel()
        {
            if (Chennel < 200)
            { Chennel++; }
        }

        public void PreviusChennel()
        {
            if (Chennel > 0)
            { Chennel--; }
        }

        public void DecreaseVolume()
        {
            if (Volume > 0)
            { Volume--; }
        }

        public void IncreaseVolume()
        {
            if (Volume < 100) { Volume++; }
        }

        public override string ToString()
        {

            return "Телевизор - состояние: ";
        }
    }
}