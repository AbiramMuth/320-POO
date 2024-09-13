using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public class Building
    {
        private int _x;                                // Position en X depuis la gauche de l'espace aérien
        private int _y;                                 // Position en Y depuis le haut de l'espace aérien

        private Pen ColorBuilding = new Pen(new SolidBrush(Color.Gold), 7);        

        public int X { get => _x; set => _x = value; }
        public int Y { get => _y; set => _y = value; }


        public void Render(BufferedGraphics drawingSpace) 
        {
            drawingSpace.Graphics.DrawRectangle(ColorBuilding, new Rectangle(X - 4, Y - 2, 20, 20));
            if ()

        }


    }
}
