﻿
namespace SR3._2.Models.Device
{
    public abstract class AbstractDevice
    {
        internal bool state;
        public AbstractDevice() { }
        public void OnOff()
        {
            state = !state;
        }
        public bool State
        {
            get
            {
                return state;
            }
        }
    }

}