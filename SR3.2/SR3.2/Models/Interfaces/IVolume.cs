using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR3._2.Models.Interfaces
{
    public interface IVolume
    {
        int Volume
        { get; set; }

        void DecreaseVolume();
        void IncreaseVolume();
    }
}