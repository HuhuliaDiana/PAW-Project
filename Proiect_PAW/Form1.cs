using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Proiect_PAW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void stocDisponibilToolStripMenuItem_Click(object sender, EventArgs e)
        {

                using (ListaMateriale lista = new ListaMateriale())
                {
                    lista.ShowDialog();
                }
            
        }

   
        private void vanzariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var vanzari = new Vanzari())
            {
                vanzari.ShowDialog();
            }
        }

       
    }
}
