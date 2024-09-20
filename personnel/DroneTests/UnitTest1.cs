using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Drones;


namespace DroneTests
{
    [TestClass]
    public class DroneTests
    {
        [TestMethod]
        public void New_drone_charge_1000()
        {     
            Drone drone = new Drone();


            Assert.AreEqual(1000, drone.Charge, "La charge n'as pas la valeur 1000");
        }
        [TestMethod]
        public void Update_batterie_down()
        {
            Drone drone = new Drone();
            int charge = drone.Charge;

            Assert.AreNotEqual(1000, drone.Charge, "La Charge ne baisse pas");
        }
        [TestMethod]
        public void LowBattery()
        {

        }
        [TestMethod]
        public void Drone_NoBattery() 
        { 
            Drone drone = new Drone();


        }
    }
}
        

    
    
