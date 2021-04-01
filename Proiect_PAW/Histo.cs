using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAW
{
    class Histo : Control
    {
        float[] vobs = new float[0];

        public Histo()
        {

            MouseMove += (s, e) => Invalidate();
            KeyDown += Grafic_KeyDown;
            MouseDown += Grafic_MouseDown;

            AllowDrop = true;
            DragEnter += Grafic_DragEnter;
            DragDrop += Grafic_DragDrop;

            GotFocus += (s, e) => Invalidate();
            LostFocus += (s, e) => Invalidate();
        }
        public float[] Valori
        {
            get { return vobs; }
            set
            {
                vobs = value;
                Invalidate();
            }
        }
        //public Bitmap image()
        //{
        //    Graphics g = CreateGraphics();
        //    Bitmap bm = new Bitmap(Size.Width, Size.Height, g);
        //    return bm; 
        //}
       
     
        Rectangle[] get_rects(Rectangle rectangle)
        {

            Rectangle[] vr = new Rectangle[vobs.Length];
            float mxo = vobs.Max();
            float db;
            float lb;
            int i;
            float stg;
            float hobs;
            float Height = Convert.ToSingle(rectangle.Height);
            float Width = Convert.ToSingle(rectangle.Width);
            float X = Convert.ToSingle(rectangle.X);
            float Y = Convert.ToSingle(rectangle.Y);
            db = Width / (4 * vobs.Length + 1);
            lb = 3 * db;
            stg = X + db;


            for (i = 0; i < vobs.Length; i++)
            {
                hobs = Height * vobs[i] / mxo;
                vr[i].X = Convert.ToInt32(stg);
                vr[i].Y = Convert.ToInt32(Y + (Height - hobs));
                vr[i].Width = Convert.ToInt32(lb);
                vr[i].Height = Convert.ToInt32(hobs);
                stg += lb + db;
            }

            return vr;

        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            this.ResizeRedraw = true;
            Rectangle r = this.ClientRectangle;
            Graphics g = e.Graphics;
            Pen pb = new Pen(Brushes.Blue, 1);
            Rectangle re = new Rectangle
            {
                X = r.X + 10,
                Y = r.Y + 10,
                Width = r.Width - 20,
                Height = r.Height - 20
            };
            g.DrawRectangle(pb, re);
            if (vobs.Length > 1)
                g.FillRectangles(Brushes.Red, get_rects(re));
            
        }

        IDataObject ConstruireDataObject()
        {
            DataObject data = new DataObject();
            data.SetData(typeof(string), string.Join(",", vobs));
            return data;
        }

        void PreluareDataObject(IDataObject data)
        {
            if (!data.GetDataPresent(typeof(string)))
            {
                return;
            }

            try
            {
                var text = data.GetData(typeof(string)) as string;

                Valori = text.Split(',').Select(elem => Single.Parse(elem)).ToArray();
            }
            catch { }

        }
        private void Grafic_MouseDown(object sender, MouseEventArgs e)
        {
            Focus();
            DoDragDrop(ConstruireDataObject(), DragDropEffects.Copy);
        }

        private void Grafic_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                Clipboard.SetDataObject(ConstruireDataObject());
            }

            if (e.Control && e.KeyCode == Keys.V)
            {
                PreluareDataObject(Clipboard.GetDataObject());
            }
        }
        private void Grafic_DragDrop(object sender, DragEventArgs e)
        {
            PreluareDataObject(e.Data);
        }

        private void Grafic_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(String)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
    }
}
