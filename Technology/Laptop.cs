using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    public class Laptop : Computer
    {
        public int ScreenSize { get; }
        public Boolean IsOpen { get; set; } = true;

        public Laptop(int screenSize, int hardDriveSize, double clockspeed) : base(hardDriveSize, clockspeed)
        {
            ScreenSize = screenSize;
        }

        public void CloseLid()
        {
            if (IsOpen)
            {
                IsOpen = false;
            }
        }
        public void OpenLid()
        {
            if (!IsOpen)
            {
                IsOpen = true;
            }
        }
    }

    
}
