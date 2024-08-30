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
        public string alive = "_@_ö";           // escargot vivant
        public string dead = "____";            // escargot mort

        /// <summary>
        /// Méthode (action qu'on va pouvoir faire avec un objet)
        /// </summary>
        public void moove() // void ne retourne rien
        {
            x++;
        }

    }
}
