using SR3._2.Models.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace SR3._2.Models.Device
{
    [Table("Temp")]
    public abstract class Temperature : AbstractDevice, IRegulatorTemp
    {
        //public int Max
        //{ get; set; }
        //public int Min
        //{ get; set; }
        //public int temp;
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