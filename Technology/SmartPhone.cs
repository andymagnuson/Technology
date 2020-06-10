using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    public class SmartPhone : Computer
    {
        public string CallQuality { get; }
        

        public SmartPhone(string callQuality, int hardDriveSize, double clockspeed) : base(hardDriveSize, clockspeed)
        {
            CallQuality = callQuality;
        }

        public string MakeCall()
        {
            return ("Can you hear me now?");
        }
        public override string GetIinfo()
        {
            return $"Call Quality is: {CallQuality}";
        }
    }
}
