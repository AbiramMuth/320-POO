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

        public int IdFactory { get => _id; set => _id = value; }

        //public int Id { get => _id; set => _id = value; }
        private int _id;

        private Pen ColorUsine = new Pen(new SolidBrush(Color.Red), 10);
        
        bool createCarton = false;
        int TimingCreate = Helper.alea.Next(5000, 10000);


        public Factory()
        {
            nbrFactory++;
        }

        // carton créer ou non
        public void Update()
        {
            if (createCarton = true) 
            {
                
                Console.WriteLine("Le carton est créer");
            }
        }


        public new void Render(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.DrawRectangle(ColorUsine, new Rectangle(X - 4, Y - 2, 10, 10));
            
        }
    }
}
