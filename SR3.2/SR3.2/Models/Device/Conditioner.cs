
namespace SR3._2.Models.Device
{
    public class Conditioner : Temperature
    {
        private int max;
        private int min;
        private int temp;
        public Conditioner() { }
        public Conditioner(bool state, int max, int min, int temp)
            : base(max, min, temp)
        {
            this.temp = temp;
            this.max = max;
            this.min = min;
        }

        public override string ToString()
        {
            return "Кондиционер : состояние: ";
        }
    }
}