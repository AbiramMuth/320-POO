using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicesnail
{
    public class Snail
    {
        // 4 attribut qui caractérise l'escargot
        public int plife = 50;                  // point de vie
        public int x = 0;                       // position
        public int y;
        public string alive = "_@_ö";           // escargot vivant
        public string dead = "____";            // escargot mort
        public string name;


        //2 Constructeur avec des signatures différentes
        public Snail(int y)
        {
            this.y = y;                         // Utilisation de this, pour préciser la variable utilisé
            this.name = "escargot " + y;        // this n'est pas obligatoire
        }

        public Snail()
        {
            y = 12;
            this.name = "escargot";
        }

        /// <summary>
        /// Méthode (action qu'on va pouvoir faire avec un objet)
        /// </summary>
        public void moove() // void ne retourne rien
        {
            x++; // se déplace vers la droite
            plife--; // à chaque fois qu'il se deplace il perd 1 point de vie
        }

    }
}
