using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    // héritages de buiding
    public class Factory : Building
    {
        public static int nbrFactory = 0;

        private Pen ColorUsine = new Pen(new SolidBrush(Color.Red), 10);

        public Factory()
        {
            nbrFactory++;
        }
        public new void Render(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.DrawRectangle(ColorUsine, new Rectangle(X - 4, Y - 2, 10, 10));
            
        }
    }
}
