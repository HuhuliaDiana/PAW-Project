using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW
{

    class DocumentGrafic : PrintDocument
    {
        Histo grafic;
        
        public DocumentGrafic(Histo grafic)
        {
            this.grafic = grafic;
        }
        
        protected override void OnPrintPage(PrintPageEventArgs e)
        {
            for (int i = 0; i < grafic.Valori.Length; i++)
            {
                e.Graphics.DrawString(grafic.Valori[i].ToString(), new Font("Arial", 24, FontStyle.Regular),
                    Brushes.Black,new Point(e.MarginBounds.X, e.MarginBounds.Y + i * 25));
            }

        }
    }



}
           

        
    


