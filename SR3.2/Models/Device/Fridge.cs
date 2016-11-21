using SR3._2.Models.Interfaces;

namespace SR3._2.Models.Device
{
    public class Fridge : Temperature, IOpenClose
    {
        private bool openclose;
    
        public Fridge() { }
        public Fridge(bool state, int max, int min, int temp, bool openclose)
            : base(max, min, temp)
        {
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