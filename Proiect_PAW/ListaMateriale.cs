using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using System.Data.OleDb;


namespace Proiect_PAW
{
    public partial class ListaMateriale : Form
    {

        public const string con = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\BD.mdb";

        List<Materiale> materiale; 
        public ListaMateriale()
        {
            InitializeComponent();

        }

        public void AfisareProduse()
        {
            listView1.Items.Clear();
            materiale = new List<Materiale>();
            using (var conexiune = new OleDbConnection(con))
            {
                conexiune.Open();
                string comandaSQL = "SELECT* FROM MATERIALE";

                using (var comanda = new OleDbCommand(comandaSQL, conexiune))
                {
                    using (var citeste = comanda.ExecuteReader())
                    {
                        while (citeste.Read())
                        {
                            var material = new Materiale(
                                citeste.GetInt32(0),
                                (string)citeste["Obiect"],
                                (string)citeste["Culoare"],
                                (string)citeste["Brand"],
                                 citeste.GetFloat(4));

                            materiale.Add(material);

                            var item = new ListViewItem(new string[] {
                                material.Cod.ToString(),
                             material.Obiect,
                              material.Culoare,
                             material.Brand,
                               material.Pret.ToString()});

                            listView1.Items.Add(item);
                            item.Tag = material;
                        }
                    }
                }
            }


        }

        private void incarcareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AfisareProduse();
        }


        private void salvareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var dialog = new SaveFileDialog())
            {
                dialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    SalvareInFisier(dialog.FileName);
                }
            }
        }
        
        private void SalvareInFisier(string caleFisier)
        {
            var continut = new StringBuilder();
            foreach (var material in materiale)
            {
                continut.Append(material.Cod.ToString(CultureInfo.InvariantCulture)+',');
                continut.Append(material.Obiect + ',');
                continut.Append(material.Culoare + ',');
                continut.Append(material.Brand + ',');
                continut.Append(material.Pret.ToString(CultureInfo.InvariantCulture));
                continut.AppendLine();

            }
            File.WriteAllText(caleFisier, continut.ToString());
        }

        private void vanzareToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count == 0)
            {
                return;
            }
            var material = (Materiale)listView1.SelectedItems[0].Tag;

            var rezultat = MessageBox.Show(this,
                $"Doriți vânzarea produsului '{material.Obiect}'?",
                "Vânzare produs!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (rezultat == DialogResult.Yes)
            {
                using (var conexiune = new OleDbConnection(con))
                {
                    conexiune.Open();
                    using (var tranzactie = conexiune.BeginTransaction())
                    {
                        var comandaSQL = "Delete from materiale where cod=?";
                        using (var comanda = new OleDbCommand(comandaSQL, conexiune, tranzactie))
                        {
                            var pCod = comanda.Parameters.Add("?", OleDbType.Integer);
                            pCod.Value = material.Cod;
                            comanda.ExecuteNonQuery();
                            
                        }
                        tranzactie.Commit();
                        AfisareProduse();
                    }


                }

                using (var vanzari = new Vanzari())
                {
                    using (var dialog = new OpenFileDialog())
                    {
                        dialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

                        if (dialog.ShowDialog(this) == DialogResult.OK)
                        {
                            var nr = File.ReadAllLines(dialog.FileName).Length;
                            string continut;
                            if (nr == 0)
                            {
                                continut = material.ToString().
                                    Substring(material.ToString().IndexOf(material.Cod.ToString()));
                            }
                            else
                            {
                                continut = material.ToString();
                            }
                            File.AppendAllText(dialog.FileName, continut);
                        }
                    }
                }


            }
        }


        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var avemProdusSelectat = listView1.SelectedItems.Count > 0;
            vanzareToolStripMenuItem.Enabled = avemProdusSelectat;
        }

        private void modificareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                return;
            }

            var material = (Materiale)listView1.SelectedItems[0].Tag;
            var mob = material.Cod;

            using (var formular = new FormularMaterial(material))
            {
                if (formular.ShowDialog(this) == DialogResult.OK)
                {
                    using (var conexiune = new OleDbConnection(con))
                    {
                        conexiune.Open();

                        var comandaSQL = "Update materiale set Obiect=?, Culoare=?," +
                            "Brand=?, Pret=? where Cod=?";
                        using (var tranzactie = conexiune.BeginTransaction())
                        {
                            using (var comanda = new OleDbCommand(comandaSQL, conexiune, tranzactie))
                            {

                                var pObiect = comanda.Parameters.Add("?", OleDbType.Char);
                                var pCuloare = comanda.Parameters.Add("?", OleDbType.Char);
                                var pBrand = comanda.Parameters.Add("?", OleDbType.Char);
                                var pPret = comanda.Parameters.Add("?", OleDbType.Single);
                                var ob = comanda.Parameters.Add("?", OleDbType.Integer);
                                pObiect.Value = formular.materialAdaugat.Obiect;
                                pCuloare.Value = formular.materialAdaugat.Culoare;
                                pBrand.Value = formular.materialAdaugat.Brand;
                                pPret.Value = formular.materialAdaugat.Pret;
                                ob.Value = mob;

                                comanda.ExecuteNonQuery();

                            }
                            tranzactie.Commit();

                        }
                    }

                }
                AfisareProduse();
            }
        }

        private void adaugăToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormularMaterial formular = new FormularMaterial())
            {
                if (formular.ShowDialog(this) == DialogResult.OK)
                {
                    using (var conexiune = new OleDbConnection(con))
                    {
                        conexiune.Open();

                        var comandaSQL = "insert into materiale(obiect,culoare,brand,pret) values(?,?,?,?)";
                        using (var tranzactie = conexiune.BeginTransaction())
                        {
                            using (var comanda = new OleDbCommand(comandaSQL, conexiune, tranzactie))
                            {
                                var pObiect = comanda.Parameters.Add("?", OleDbType.Char);
                                var pCuloare = comanda.Parameters.Add("?", OleDbType.Char);
                                var pBrand = comanda.Parameters.Add("?", OleDbType.Char);
                                var pPret = comanda.Parameters.Add("?", OleDbType.Single);

                                
                                pObiect.Value = formular.materialAdaugat.Obiect;
                                pCuloare.Value = formular.materialAdaugat.Culoare;
                                pBrand.Value = formular.materialAdaugat.Brand;
                                pPret.Value = formular.materialAdaugat.Pret;

                                comanda.ExecuteNonQuery();

                            }
                            tranzactie.Commit();

                        }
                        
                    }
                    AfisareProduse();
                }
            }
        }
        

        private void aplicăReducereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count < 0)
            {
                return;
            }
            var material = (Materiale)listView1.SelectedItems[0].Tag;


            if (textBox2.Text != "")
            {
                using (var conexiune = new OleDbConnection(con))
                {

                    var comandaSQL = "Update materiale set Pret=Pret-Pret*? where Cod=?";

                    using (var comanda = new OleDbCommand(comandaSQL, conexiune))
                    {
                        conexiune.Open();

                        var reducere = comanda.Parameters.AddWithValue("?", Convert.ToSingle(textBox2.Text));
                        var pObiect = comanda.Parameters.AddWithValue("?", material.Cod);

                        comanda.ExecuteNonQuery();
                    }


                }

                AfisareProduse();
            }
            else
            {
                MessageBox.Show("Introdu valoarea reducerii!");

            }
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text != null)
            {
                string comandaSQL = null;
                string atribut = comboBox1.Text;
                if (atribut == "Obiect")
                {
                    comandaSQL = "SELECT* FROM MATERIALE WHERE OBIECT=?";
                }
                else
                        if (atribut == "Culoare")
                {
                    comandaSQL = "SELECT* FROM MATERIALE WHERE Culoare=?";
                }

                else
                        if (atribut == "Brand")
                {
                    comandaSQL = "SELECT* FROM MATERIALE WHERE Brand=?";

                }
                listView1.Items.Clear();

                using (var conexiune = new OleDbConnection(con))
                {
                    conexiune.Open();

                    using (var comanda = new OleDbCommand(comandaSQL, conexiune))
                    {
                        comanda.Parameters.AddWithValue("?", textBox3.Text);
                        using (var citeste = comanda.ExecuteReader())
                        {
                            while (citeste.Read())
                            {
                                var material = new Materiale(
                                    citeste.GetInt32(0),
                                    (string)citeste["Obiect"],
                                    (string)citeste["Culoare"],
                                      (string)citeste["Brand"],
                                      citeste.GetFloat(4));
                                materiale.Add(material);

                                var item = new ListViewItem(new string[] {
                                    material.Cod.ToString(),
                                        material.Obiect, material.Culoare,
                                        material.Brand,
                                        material.Pret.ToString()});

                                listView1.Items.Add(item);
                                item.Tag = material;

                            }
                        }
                    }
                }

            }
        }

        

        private void prețCrescătorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int nrLinii = materiale.Count;
            for (int i = 0; i < nrLinii - 1; i++)
            {
                for (int j = i + 1; j < nrLinii; j++)
                {
                    if (materiale[i].Pret > materiale[j].Pret)
                    {
                        var aux = materiale[i].Pret;
                        materiale[i].Pret = materiale[j].Pret;
                        materiale[j].Pret = aux;
                    }
                }
            }
            listView1.Items.Clear();
            foreach (var material in materiale)
            {
                var item = new ListViewItem(new string[] {
                                material.Cod.ToString(),
                             material.Obiect,
                              material.Culoare,
                             material.Brand,
                               material.Pret.ToString()});

                listView1.Items.Add(item);
                item.Tag = material;
            }

        }

        private void prețDescrescătorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int nrLinii = materiale.Count;

            for (int i = 0; i < nrLinii - 1; i++)
            {
                for (int j = i + 1; j < nrLinii; j++)
                {
                    if (materiale[i].Pret < materiale[j].Pret)
                    {
                        var aux = materiale[i].Pret;
                        materiale[i].Pret = materiale[j].Pret;
                        materiale[j].Pret = aux;
                    }
                }
            }
            listView1.Items.Clear();

            foreach (var material in materiale)
            {
                var item = new ListViewItem(new string[] {
                                material.Cod.ToString(),
                             material.Obiect,
                              material.Culoare,
                             material.Brand,
                               material.Pret.ToString()});

                listView1.Items.Add(item);
                item.Tag = material;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            using (var form = new FormHistograma())
            {
                form.button1.Text = "Lista materiale stoc";
                form.ShowDialog();
               
            }
        }

       
    }
}


