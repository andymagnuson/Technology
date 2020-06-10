using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Technology
{
    public abstract class IdAbstract
    {

        public int ID { get; set; }
        private static int lastUsedID = 100001;
       

        public IdAbstract()
        {
            ID = lastUsedID++;        
           
        }
    }
}
