namespace Drones
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Cr�ation de la flotte de drones
            List<Drone> fleet= new List<Drone>();
            Drone drone = new Drone();
            drone.X = 100;
            drone.Y = 100;
            drone.Name = "Joe";
            fleet.Add(drone);

            List<Building> numberBuilding = new List<Building>();
            for (int i = 0; i < 50; i++)
            {
                Building building = new Building();
                building.X = Helper.alea.Next(3, Config.WIDTH - 10);
                building.Y = Helper.alea.Next(3, Config.HEIGHT - 10);
                numberBuilding.Add(building);

            }


            // D�marrage
            Application.Run(new AirSpace(fleet, numberBuilding));
        }
    }
}