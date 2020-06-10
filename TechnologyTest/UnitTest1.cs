using Microsoft.VisualStudio.TestTools.UnitTesting;
using Technology;

namespace TechnologyTest
{
    [TestClass]
    public class UnitTest1
    {
        Computer c;
        Laptop l;
        SmartPhone sp;
        [TestInitialize]
        public void CreateObjects()
        {
            c = new Computer(100, 4.0);
            l = new Laptop(15, 256, 1.8);
            sp = new SmartPhone("terrible", 64, 2.4);
        }

        [TestMethod]
        public void TestComputerConstructor()
        {
            Assert.IsTrue(c.HardDriveSize==100 && c.ClockSpeed ==4.0 && c.HardDriveSpace ==100 &&c.IsTurnedOn==false);
        }

        [TestMethod]
        public void TestLaptopConstructor()
        {
            Assert.IsTrue(l.HardDriveSize == 256 && l.ClockSpeed == 1.8 && l.HardDriveSpace == 256 && l.IsTurnedOn == false && l.ScreenSize == 15);
        }

        [TestMethod]
        public void TestSmarthPhoneConstructor()
        {
            Assert.IsTrue(sp.HardDriveSize == 64 && sp.ClockSpeed == 2.4 && sp.HardDriveSpace == 64 && sp.IsTurnedOn == false && sp.CallQuality=="terrible");
        }
        

        /*************************************************************************************************************************************************************/

        [TestMethod]
        public void TestPowerButtonForComputer()
        {
            c.PushPowerButton();
            Assert.AreEqual(c.IsTurnedOn, true);
        }

        [TestMethod]
        public void TestPowerButtonForLaptop()
        {
            l.PushPowerButton();
            Assert.AreEqual(l.IsTurnedOn, true);
        }
        /*****************************************************************************************************************************************************************/


        [TestMethod]
        public void TestDownloadTooBigComputer()
        {
            c.DownloadFile(120);
            c.DownloadFile(20);
            Assert.AreEqual(c.HardDriveSpace, 80);
        }

        [TestMethod]
        public void TestDownloadTooBigSmartPhone()
        {
            sp.DownloadFile(120);
            sp.DownloadFile(20);
            Assert.AreEqual(sp.HardDriveSpace, 44);
        }

        [TestMethod]
        public void TestDownloadLaptop()
        {
            l.DownloadFile(120);
            l.DownloadFile(36);
            Assert.AreEqual(l.HardDriveSpace, 100);
        }

        /******************************************************************************************************************************************************************/

        [TestMethod]
        public void TestOutputCall()
        {
            Assert.AreEqual(sp.MakeCall(), "Can you hear me now?");
        }
    }
}
