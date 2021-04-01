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
    public partial class FormularMaterial : Form
    {
        Materiale material;
        public FormularMaterial(Materiale material = null)
        {
            InitializeComponent();
            this.material = material;

            if (material == null)
            {
                Text = "";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";

            }
            else
            {
                
                textBox1.Text = material.Obiect;
                textBox2.Text = material.Culoare;
                textBox3.Text = material.Brand;
                textBox4.Text = material.Pret.ToString();
            }
        }

        public Materiale materialAdaugat { get { return material; } }


        public bool EsteValidPret()
        {
            if (Single.Parse(textBox4.Text) > 0)
            {
                return true;
            }
            else return false;

        }
        public bool EsteValid()
        {
            return EsteValidPret();
        }

        private void textBox4_Validated(object sender, EventArgs e)
        {
            EsteValidPret();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!EsteValid())
            {
                return;
            }

            if (material == null)
            {
                material = new Materiale(
                    
                    textBox1.Text,
                    textBox2.Text,
                    textBox3.Text,
                    Single.Parse(textBox4.Text));
            }
            else
            {
                material.Obiect = textBox1.Text;
                material.Culoare = textBox2.Text;
                material.Brand = textBox3.Text;
                material.Pret= Single.Parse(textBox4.Text);
            }

            DialogResult = DialogResult.OK;
          
        }
        
       
    }
}
                        


    