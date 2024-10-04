namespace Drones
{
    // Cette partie de la classe Drone définit ce qu'est un drone par un modèle numérique
    public partial class Drone : IExpellable
    {
        

        private int _charge = 1000;                     // La charge actuelle de la batterie
        private string _name;                           // Un nom
        private int _x;                                // Position en X depuis la gauche de l'espace aérien
        private int _y;                                 // Position en Y depuis le haut de l'espace aérien

        
        // attribut
        public int Charge { get => _charge; set => _charge = value; }
        public string Name { get => _name; set => _name = value; }
        public int X { get => _x; set => _x = value; }
        public int Y { get => _y; set => _y = value; }
        public EvacuationState etat;


        // Constructeur
        public Drone(int x, int y)
        { 
            _x = x;
            _y = y;
            etat = EvacuationState.Free;
        }

        // Implémentation de l'interface
        public bool Evacuate(Rectangle zone)
        {
            // évacue si il est dans le rectangle
            if (zone.IntersectsWith(new Rectangle(X - 4, Y - 2, 8, 8)))
            {
                etat = EvacuationState.Evacuating;
                return false;
            }
            else
            {
                // est déja évacué
                etat = EvacuationState.Evacuated;
                return true;
            }
        }
        // Vole librement
        public void FreeFlight()
        {
            etat = EvacuationState.Free;
        }
        // retourne l'état du drone
        public EvacuationState GetEvacuationState()
        {
            return etat;
        }

        // Cette méthode calcule le nouvel état dans lequel le drone se trouve après
        // que 'interval' millisecondes se sont écoulées
        public void Update(int interval)
        {
            X += 2;                                    // Il s'est déplacé de 2 pixels vers la droite
            Y += Helper.alea.Next(-2, 3);                     // Il s'est déplacé d'une valeur aléatoire vers le haut ou le bas
            Charge--;                                  // Il a dépensé de l'énergie
        }

    }
}