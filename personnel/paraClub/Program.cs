using exerciceParachute;

namespace paraClub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Liste, Création du groupe de parachute
            List<Para> parachutiste = new List<Para>(); 
            
            // Créer l'avion
            Plane plane = new Plane();

            
            while (true)
            {
                plane.update();

                Console.Clear();
                plane.draw();

                //Temps de déplacement
                Thread.Sleep(100);
            }
            


        }
      
    }
}