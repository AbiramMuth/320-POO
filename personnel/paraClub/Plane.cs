using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace exerciceParachute
{
    // class pour l'avion 
    public class Plane
    {
        public int x = 0;                       // position
        public int height;
        public int y = 5;

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
            x++;

        }

        /// <summary>
        /// 
        /// </summary>
        internal void draw() // mettre internal pour que le x fonctionne
        {
            for (int i = 0; i < 150; i++)
            {
                Console.Clear();

                for (int j = 0; j < view.Length; j++)
                {
                    Console.SetCursorPosition(i, j);
                    Console.Write(view[j]);

                }

                Thread.Sleep(70);


            }
            //
        }
    }
}
