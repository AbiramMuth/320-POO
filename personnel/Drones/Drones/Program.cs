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
            for (int i = 0; i < 3; i++)
            {
                Drone drone = new Drone(1,2);
                drone.X = Helper.alea.Next(Config.WIDTH);
                drone.Y = Helper.alea.Next(Config.HEIGHT);
                drone.Name = "Joe";
                fleet.Add(drone);
            }

            // partie vérification des exceptions
            try
            {
                if (fleet.Count <= 10)
                {
                    int RES = fleet.Count;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error {e.Message}");
            }




            List<Building> numberBuilding = new List<Building>();
            List<Factory> nbrFactory = new List<Factory>();
            List<Store> nbmagasin = new List<Store>();
            for (int i = 0; i < 5; i++)
            {
                // Building jaune
                Building building = new Building();
                building.X = Helper.alea.Next(3, Config.WIDTH - 10);
                building.Y = Helper.alea.Next(3, Config.HEIGHT - 10);
                numberBuilding.Add(building);

                // Factory en rouge
                Factory usines = new Factory();
                usines.X = Helper.alea.Next(3, Config.WIDTH - 10);
                usines.Y = Helper.alea.Next(3, Config.HEIGHT - 10);
                nbrFactory.Add(usines);

                // Store rond
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