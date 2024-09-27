using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Drones;


namespace DroneTests
{
    [TestClass]
    public class DroneTests
    {
        //[TestMethod]
        //public void New_drone_charge_1000()
        //{     
        //    Drone drone = new Drone();


        //    Assert.AreEqual(1000, drone.Charge, "La charge n'as pas la valeur 1000");
        //}
        //[TestMethod]
        //public void Update_batterie_down()
        //{
        //    Drone drone = new Drone();
        //    int charge = drone.Charge;

        //    Assert.AreNotEqual(1000, drone.Charge, "La Charge ne baisse pas");
        //}
        //[TestMethod]
        //public void LowBattery()
        //{

        //}
        //[TestMethod]
        //public void Drone_NoBattery() 
        //{ 
        //    Drone drone = new Drone();
        //}
        [TestMethod]
        public void Test_that_drone_is_taking_orders()
        {
            // Arrange
            Drone drone = new Drone(500, 500);

            // Act
            EvacuationState state = drone.GetEvacuationState();

            // Assert
            Assert.AreEqual(EvacuationState.Free, state);

            // Arrange a no-fly zone around the drone
            bool response = drone.Evacuate(new System.Drawing.Rectangle(400, 400, 200, 200));

            // Assert
            Assert.IsFalse(response); // because the zone is around the drone
            Assert.AreEqual(EvacuationState.Evacuating, drone.GetEvacuationState());

            // Arrange: remove no-fly zone
            drone.FreeFlight();

            // Assert
            Assert.AreEqual(EvacuationState.Free, drone.GetEvacuationState());
        }
    }
}