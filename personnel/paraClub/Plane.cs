using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Security.Cryptography.X509Certificates;

namespace exerciceParachute
{
    // class pour l'avion 
    public class Plane
    {
        public int x = 0;                       // position
        public int height;
        public int y = 0;

        public Plane()
        {
            x = 0;
            height = Config.SCREEN_HEIGHT;
        }

        private string[] view =
      {
            @" _                         ",
            @"| \                        ",
            @"|  \       ______          ",
            @"--- \_____/  |_|_\____  |  ",
            @"  \_______ --------- __>-} ",
            @"        \_____|_____/   |  "
        };

        /// <summary>
        /// Move the plane left on right
        /// </summary>
        internal void update()
        {
            if (x > Config.SCREEN_WIDTH)
            {
                x = 0;
            }
            else
            {
                x++;
            }
        }

        /// <summary>
        /// Déplacement de l'avion
        /// </summary>
        internal void draw() // mettre internal pour que le x fonctionne
        {
            for (int j = 0; j < view.Length; j++)
            {
                Console.SetCursorPosition(x, j);
                Console.Write(view[j]);
            }
        }
    }
}
