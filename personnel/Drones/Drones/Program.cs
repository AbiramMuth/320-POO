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

            // Création de la flotte de drones
            List<Drone> fleet = new List<Drone>();
            Drone drone = new Drone();
            drone.X = 100;
            drone.Y = 100;
            drone.Name = "Joe";
            fleet.Add(drone);

            List<Building> numberBuilding = new List<Building>();
            List<Factory> nbrFactory = new List<Factory>();
            List<Store> nbmagasin = new List<Store>();
            for (int i = 0; i < 5; i++)
            {
                Building building = new Building();
                building.X = Helper.alea.Next(3, Config.WIDTH - 10);
                building.Y = Helper.alea.Next(3, Config.HEIGHT - 10);
                numberBuilding.Add(building);

                Factory usines = new Factory();
                usines.X = Helper.alea.Next(3, Config.WIDTH - 10);
                usines.Y = Helper.alea.Next(3, Config.HEIGHT - 10);
                nbrFactory.Add(usines);

                Store store = new Store();
                store.X = Helper.alea.Next(3, Config.WIDTH - 10);
                store.Y = Helper.alea.Next(3, Config.HEIGHT - 10);
                nbmagasin.Add(store);


            }


            // Démarrage
            Application.Run(new AirSpace(fleet, numberBuilding, nbrFactory, nbmagasin));
        }
    }
}