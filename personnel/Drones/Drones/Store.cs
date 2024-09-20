using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    public class Store : Building
    {
        private Pen Colormagasin = new Pen(new SolidBrush(Color.Black), 8);
        public new void Render(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.DrawEllipse(Colormagasin, new Rectangle(X - 4, Y - 2, 20, 20));
          
        }
    }
}
