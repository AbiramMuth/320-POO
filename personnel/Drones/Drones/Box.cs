using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Drones
{
    /// <summary>
    /// Enumération des couleurs
    /// </summary>
    public enum SmartiesColor
    {
        Red,
        Yellow,
        Blue,
        Brown,
        Orange
    }
    public partial class Box
    {

        int _nbrKilo = Helper.alea.Next(5000, 10000);
        

        // couleur par défaut brun
        public SmartiesColor couleur {  get; set; } = SmartiesColor.Brown;



        // forme du carton
        //public new void Render(BufferedGraphics drawingSpace)
        //{
        //    drawingSpace.Graphics.DrawRectangle(ColorUsine, new Rectangle(X - 4, Y - 2, 15, 15));
        //}

    }
}
