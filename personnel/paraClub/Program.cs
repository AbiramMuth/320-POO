using exerciceParachute;

namespace paraClub
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            // Liste, Création du groupe de parachute
            List<Para> parachutistes = new List<Para>(); 
            
            // Créer l'avion
            Plane plane = new Plane();
            Para parachutiste = new Para();

            while (true)
            {
                
                plane.update();
                parachutiste.update();

                Console.Clear();
                plane.draw();
                parachutiste.draw();
               
                Thread.Sleep(70);
            }



        }
      
    }
}