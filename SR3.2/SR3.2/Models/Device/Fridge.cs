using SR3._2.Models.Interfaces;

namespace SR3._2.Models.Device
{
    public class Fridge : Temperature, IOpenClose
    {
        private int max;
        private int min;
        private int temp;
        private bool openclose;
    
        public Fridge() { }
        public Fridge(bool state, int max, int min, int temp, bool openclose)
            : base(max, min, temp)
        {
            this.temp = temp;
            this.max = max;
            this.min = min;
            this.openclose = openclose;
        }

        public bool OpenClose
        {
            get { return openclose; }
            set { openclose = value; }

        }
        public void OpCl()
        {
            openclose = !openclose;
        }

        public override string ToString()
        {
            return "Холодильник - состояние: ";
        }
    }
}