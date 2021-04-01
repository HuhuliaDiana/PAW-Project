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
    public partial class Vanzari : Form
    {
        List<Materiale> materialeV = new List<Materiale>();

        public Vanzari()
        {
            InitializeComponent();
        }
        public List<Materiale> materialeVandute()
        {
            return materialeV;
        }

        public void AfisareProduse()
        {
            lvVanzari.Items.Clear();
            float buget = 0F;

            foreach (var material in materialeV)
            {
                var item = new ListViewItem(new string[] {
                    material.Cod.ToString(),
                    material.Obiect,
                    material.Culoare,
                    material.Brand,
                    material.Pret.ToString()
                });

                lvVanzari.Items.Add(item);
                buget += material.Pret;
                

            }

        }

       
        private void IncarcareDinFisier(string caleFisier)
        {
            try
            {
                materialeV.Clear();
                var items = File.ReadAllLines(caleFisier);

                for (int i = 0; i < items.Length; i += 1)
                {
                    string[] cuvinte = items[i].Split(',');

                    materialeV.Add(new Materiale(
                        cod: int.Parse(cuvinte[0]),
                        obiect: cuvinte[1],
                        culoare: cuvinte[2],
                        brand: cuvinte[3],
                        pret: Single.Parse(cuvinte[4])));

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

       
      
        private void button1_Click(object sender, EventArgs e)
        {
            float ultimBuget = 0f;
            using (var dialog = new OpenFileDialog())
            {
                dialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                //deschid fisierul cu valorile retinute ale bugetelor
                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    string[] items = null;
                    if (File.ReadAllLines(dialog.FileName).Length == 0)
                    {
                        MessageBox.Show("Nu avem vreun buget retinut!");
                    }
                    else
                    {
                        items = File.ReadAllText(dialog.FileName).Split(',');
                        ultimBuget = Single.Parse(items[items.Length - 2]);
                        //extrag ultimul buget inregistrat in fisierul cu bugete
                        //pentru a-l scadea din noua suma realizata(mai jos) dupa inchiderea si deschiderea aplicatiei din nou
                        //astfel voi putea vedea ce buget am strans de la ultima 
                        //deschidere a aplicatiei si pana la urmatoare inchidere.
                        //Presupunem ca in descursul unei zilei aplicatia ramane deschisa constant, iar
                        //la finalul zilei cand se inchide aplicatia se calculeaza pretul total al 
                        //materialelor vandute in acea zi.
                        //scopul este de a vedea apoi pe grafic evolutia bugetelor stranse in decursul mai multor zile
                    }
                }
            }
            
                float suma = 0;
                foreach (var material in materialeV)
                {
                    suma += material.Pret;
                }
                suma -= ultimBuget;

                MessageBox.Show("Bugetul de azi este de " + suma.ToString() + " lei");
                label1.Text = suma.ToString();
            
            
        }

        
        private void bugetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    File.AppendAllText( dialog.FileName,label1.Text+',');

                }
            }
        }

        private void listăVânzăriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    IncarcareDinFisier(dialog.FileName);
                    AfisareProduse();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var form = new FormHistograma())
            {
                form.button1.Text = "Lista cu bugete";
                form.ShowDialog();

            }

        }
       
        private void button3_Click(object sender, EventArgs e)
        {
           
            using (var form = new FormHistograma())
            {
               
                form.button1.Text="Lista materiale vandute";
                form.ShowDialog();

            }
        }

       
    }
}
           


