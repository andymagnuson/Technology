using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    public class Computer : IdAbstract
    {
        public int HardDriveSize { get; }
        public int HardDriveSpace { get; set; }
        public Boolean IsTurnedOn { get; set; } = false;
        public double ClockSpeed;
        readonly string WhereMade = "China";

        public Computer(int hardDriveSize, double clockspeed)
        {
            HardDriveSize = hardDriveSize;
            HardDriveSpace = hardDriveSize;
            ClockSpeed = clockspeed;
        }

        public virtual string GetIinfo()
        {
           return $"Hard-Drive size: {HardDriveSize} and is made in {WhereMade}";
        }
        public void PushPowerButton()
        {
            if (IsTurnedOn)
            {
                IsTurnedOn = false;
            } else
            {
                IsTurnedOn = true;
            }
        }

        public string DownloadFile(int sizeOfFile)
        {
            if (sizeOfFile> HardDriveSpace)
            {
                return "Error, not enough Hard-Drive space remaining";
            } else
            {
                HardDriveSpace -= sizeOfFile;
                return "File successfully downloaded. " + HardDriveSpace + "Gigs remaining";
            }
        }
    }
}
