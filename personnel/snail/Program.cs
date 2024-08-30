using Exercicesnail;
using System;

// snail, Course d'escargot
namespace snail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //orientée objet

            List<Snail> snails = new List<Snail>();             // création d'une liste nommée snails, permets d'éviter de répéter le code

            for (int i = 0; i < 10; i++)
            {
                snails.Add(new Snail(i));
            }

            Console.CursorVisible = false;


            Console.ForegroundColor = ConsoleColor.Blue;
            while (snails[0].plife > 0)
            {
                Console.Clear();
                foreach (Snail snail in snails)
                {
                    Console.SetCursorPosition(snail.x, snail.y);
                    Console.Write(snail.alive);
                    snail.moove();
                }
                Thread.Sleep(40);
            }

            foreach (Snail snail in snails)
            {
                Console.SetCursorPosition(snail.x, snail.y);
                Console.Write(snail.dead);
            }






            // essaie du snail

            //Snail escargot = new Snail(2);                     //(escargot est une classe), et on va le créer
            //Snail titi = new Snail();                          // deuxieme escargot


            //for (int i = 0; i < 10; i++) 
            //{ 
            //    snails.Add(new Snail(i));
            //}

            //Console.CursorVisible = false;                      // pour pas voir le cursor
            //while (snails[0].plife > 0)                          // Quand le premier escargot meurt ca s'arrete
            //{
            //    Console.Clear();
            //    foreach (Snail snail in snails) 
            //    {
            //        Console.SetCursorPosition(escargot.x, escargot.y);
            //        Console.Write(snail.alive);                  // affiche l'escargot en vie
            //        escargot.moove();                                   // augmente la position
            //    }


            //    Thread.Sleep(10);
            //}
            // foreach (Snail snail in snails) 
            //    {
            //        Console.SetCursorPosition(escargot.x, escargot.y);
            //        Console.Write(snail.alive);                  // affiche l'escargot en vie
            //        escargot.moove();                                   // augmente la position
            //    }

            //Console.SetCursorPosition(escargot.x, escargot.y);
            //Console.Write(escargot.dead);
            //Console.SetCursorPosition(titi.x, titi.y);
            //Console.Write(titi.dead);

            //Console.ReadLine();                                 //attents qu'on appuie sur le clavier


            //int vie = 50;
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.CursorVisible = false; // pour pas voir le cursor
            //for (int i = 0; i < 50; i++)
            //{
            //    Thread.Sleep(125); // quantité de temps en milisecondes qu'il va prendre pour exécuter le code en-dessous
            //    Console.Clear();
            //    Console.SetCursorPosition(i, 15); // déplace la position à droite de 1
            //    Console.Write("_@@@@@@@@_ö");
            //    vie--;
            //    if (vie == 1)
            //    {
            //        Console.Clear();
            //        Console.SetCursorPosition(i, 15);
            //        Console.Write("_____");
            //    }
            //    if (vie == 0)
            //    {
            //        Console.Clear();
            //        Console.SetCursorPosition(i + 1, 15);
            //        Console.Write("_____");
            //    }





            // snails.Add(escargot);                              // Ajouter du premier escargot dans la liste
            // snails.Add(titi);                                   // Ajouter du deuxième escargot dans la liste
            //}
        }
    }
}
