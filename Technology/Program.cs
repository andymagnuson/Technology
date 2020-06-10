using System;

namespace Technology
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer c = new Computer(256, 4.5);
            //Console.WriteLine(c.DownloadFile(20));
            //Console.WriteLine(c.HardDriveSpace);
            //Console.WriteLine(c.IsTurnedOn);
            //c.PushPowerButton();
            //Console.WriteLine(c.IsTurnedOn);

            c.GetIinfo();
            Laptop l = new Laptop(15, 100, 3.5);
            Console.WriteLine(l.IsTurnedOn);
           l.GetIinfo();
            SmartPhone sp = new SmartPhone("good", 25, 1.5);
            sp.DownloadFile(30);
            sp.MakeCall();
            sp.GetIinfo();
            Console.WriteLine(c.ID);
            Console.WriteLine(sp.ID);
            Console.WriteLine(l.ID);
            Console.WriteLine(l.ID);

        }
    }
}
