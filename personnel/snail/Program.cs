using Exercicesnail;
using System;
namespace snail
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
            //}


            //Resolution du prof orientée objet
            Snail escargot = new Snail();               //(escargot est une classe), et on va le créer
            Snail titi = new Snail();                   // deuxieme escargot
            titi.dead = "*****";

            Console.CursorVisible = false;              // pour pas voir le cursor
            while (escargot.plife > 0)                  // tant que toto est en vie
            {
                Console.Clear();
                Console.SetCursorPosition(escargot.x, 15);
                Console.Write(escargot.alive);          // affiche l'escargot en vie
                Console.SetCursorPosition(titi.x, 10);
                Console.Write(titi.alive);              // affiche l'escargot en vie
                escargot.x++;                           // augmente la position
                titi.moove();                           // utilisation de la méthode pour bouger
                
                escargot.plife--;
                titi.plife++;
                Thread.Sleep(10);
            }
            Console.SetCursorPosition(escargot.x, 15);
            Console.Write(escargot.dead);
            Console.SetCursorPosition(titi.x, 10);
            Console.Write(titi.dead);

            Console.ReadLine();                         //attents qu'on appuie sur le clavier
        }
    }
}
