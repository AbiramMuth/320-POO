using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciceParachute
{
    internal class Para
    {
        public int y;


        private string[] withoutParachute =
        {
            @"     ",
            @"     ",
            @"     ",
            @"     ",
            @"  o  ",
            @" /░\ ",
            @" / \ ",
        };

        private string[] withParachute =
        {
            @"",
            @" ___ ",
            @"/|||\",
            @"\   /",
            @" \o/ ",
            @"  ░  ",
            @" / \ ",
        };


        /// <summary>
        /// De haut en bas
        /// </summary>
        internal void update()
        {
            y++;
        }

        /// <summary>
        /// Déplacement du parachutiste
        /// </summary>
        internal void draw() // mettre internal pour que le x fonctionne
        {

            for (int i = 0; i < withParachute.Length; i++)
            {
                Console.SetCursorPosition(i, y);
                if (y >= Config.SCREEN_HEIGHT / 2)
                {
                    foreach (var item in withParachute)
                    {
                        Console.WriteLine(item);
                    }
                    Thread.Sleep(60);
                }
                else
                {
                    foreach (var element in withoutParachute)
                    {
                        Console.WriteLine(element);
                    }
                    Thread.Sleep(60);
                }
            }
        }

    }
}
