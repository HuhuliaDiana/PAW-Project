using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAW
{
    public partial class FormHistograma : Form
    {
        public FormHistograma()
        {
            InitializeComponent();
        }

        public void getValori()
        {
            string text = textBox1.Text;
            string[] valori = text.Split(',');

        }

        public const string con = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\BD.mdb";

        private void IncarcareDinFisier(string caleFisier)
        {
            var text = File.ReadAllText(caleFisier);
            textBox1.Text = text.Substring(0, text.Length - 1);

        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            textBox1.DoDragDrop(textBox1.Text, DragDropEffects.Copy);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (button1.Text == "Lista materiale stoc")
            {
                if (textBox2.Text != "")
                {
                    string text = null;

                    using (var conexiune = new OleDbConnection(con))
                    {
                        conexiune.Open();
                        var sql = "Select pret from materiale where obiect=?";
                        using (var comanda = new OleDbCommand(sql, conexiune))
                        {
                            comanda.Parameters.AddWithValue("?", textBox2.Text);
                            using (var reader = comanda.ExecuteReader())
                            {
                                if (reader.HasRows)
                                {
                                    while (reader.Read())
                                    {
                                        text += reader.GetFloat(0).ToString() + ',';
                                    }

                                    textBox1.Text = text.Substring(0, text.Length - 1);
                                }
                                else
                                {
                                    MessageBox.Show("Obiect inexistent!");
                                }

                            }
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Introdu numele obiectului!");
                }

            }
            else
            {
                if (button1.Text == "Lista materiale vandute")
                {
                    if (textBox2.Text != "")
                    {
                        using (var dialog = new OpenFileDialog())
                        {
                            dialog.Filter = "Fișiere text (*.txt)|*.txt|Toate fișierele (*.*)|*.*";
                            if (dialog.ShowDialog(this) == DialogResult.OK)
                            {
                                string[] linii = File.ReadAllLines(dialog.FileName);
                                var obiect = textBox2.Text;
                                string textDate = null;
                                foreach (var linie in linii)
                                {
                                    string[] cuvinte = linie.Split(',');
                                    if (cuvinte[1] == obiect)
                                    {
                                        textDate += cuvinte[4] + ',';
                                    }
                                }
                                if (textDate == null)
                                {
                                    MessageBox.Show("Obiect nevandut!");
                                }
                                else
                                {
                                    textBox1.Text = textDate.Substring(0, textDate.Length - 1);

                                }
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("Introdu numele obiectului!");
                    }


                }

                else
                {
                    
                        if (button1.Text == "Lista cu bugete")
                        {
                            using (var dialog = new OpenFileDialog())
                            {
                                dialog.Filter = "Fișiere text (*.txt)|*.txt|Toate fișierele (*.*)|*.*";
                                if (dialog.ShowDialog(this) == DialogResult.OK)
                                {
                                    string text = File.ReadAllText(dialog.FileName);
                                    textBox1.Text = text.Substring(0, text.Length - 1);
                                }

                            }
                        }
                    
                    else
                    {
                        MessageBox.Show("Introdu numele obiectului!");
                    }
                }
            }
        }



        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (textBox1.Text != "")
                {
                    var text = textBox1.Text;
                    histo1.Valori = text.Split(',').Select(elem => Single.Parse(elem)).ToArray();

                }
                else
                {
                    MessageBox.Show("Introdu date!");
                }
            }

        }
         
        
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                using (var printDialog = new PrintPreviewDialog())
                {
                    printDialog.Document = new DocumentGrafic(histo1);
                    printDialog.Document.DefaultPageSettings.Landscape = true;
                    printDialog.ShowDialog(this);
                }

            }
            else
            {
                MessageBox.Show("Introdu date!");
            }

            //Graphics mg = Graphics.FromImage(histo1.image());
            //mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            //printPreviewDialog1.ShowDialog();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var form = new FormHistograma())
            {
                form.textBox1.Text = "Lista cu materiale stoc";
                form.ShowDialog();
            }
        }



        //private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        //{
        //    e.Graphics.DrawImage(histo1.image(),0,0);
        //}
    }
}




