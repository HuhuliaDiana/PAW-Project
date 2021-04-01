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
    public partial class FormGrafic : Form
    {
        public FormGrafic()
        {
            InitializeComponent();
        }


        private void FormGrafic_Load(object sender, EventArgs e)
        {
            string text = File.ReadAllText("Buget.txt");
            textBox1.Text = text.Substring(0, text.Length - 1);
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            textBox1.DoDragDrop(textBox1.Text, DragDropEffects.Copy);
        }

        
    }
}
