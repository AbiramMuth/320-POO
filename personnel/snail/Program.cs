namespace snail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vie = 50;

            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < 50; i++) 
            {
                Thread.Sleep(125); // quantité de temps en milisecondes qu'il va prendre pour exécuter le code en-dessous
                Console.Clear();
                Console.SetCursorPosition(i, 15); // déplace la position à droite de 1
                Console.WriteLine("_@@@@@@@@_ö");
                vie--;
                if (vie == 1)
                {
                    Console.Clear();
                    Console.SetCursorPosition(i, 15);
                    Console.WriteLine("_____");
                }
                if (vie == 0)
                {
                    Console.Clear();
                    Console.SetCursorPosition(i+1, 15);
                    Console.WriteLine("_____");
                }
            }
        }
    }
}
