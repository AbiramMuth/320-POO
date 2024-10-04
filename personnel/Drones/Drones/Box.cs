using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Drones
{
    public partial class Box : Factory
    {

        private int _nbrKilo = Helper.alea.Next(5, 10);



        // couleur des smarites
        private Pen ColorUsine = new Pen(new SolidBrush(Color.Brown), 10);

        public Box()
        {
        }

        // forme du carton
        //public new void Render(BufferedGraphics drawingSpace)
        //{
        //    drawingSpace.Graphics.DrawRectangle(ColorUsine, new Rectangle(X - 4, Y - 2, 15, 15));
        //}

    }
}
