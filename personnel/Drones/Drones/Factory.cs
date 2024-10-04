using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    // héritages de buiding
    public class Factory  : Building
    {
        public static int nbrFactory = 0;

        public int Id { get => _id; set => _id = value; }

        //public int Id { get => _id; set => _id = value; }
        private int _id;

        private Pen ColorUsine = new Pen(new SolidBrush(Color.Red), 10);
        

        public Factory()
        {
            nbrFactory++;
        }

        public void Update()
        {

        }


        public new void Render(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.DrawRectangle(ColorUsine, new Rectangle(X - 4, Y - 2, 10, 10));
            
        }
    }
}
