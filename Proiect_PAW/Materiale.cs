using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW
{
    public class Materiale
    {
        readonly int cod;
        string obiect;
        string culoare;
        string brand;
        float pret;

        public Materiale(int cod, string obiect, string culoare, string brand, float pret)
        {
            this.cod = cod;
            this.obiect = obiect;
            this.culoare = culoare;
            this.brand = brand;
            this.pret = pret;
        }
        public Materiale(string obiect, string culoare, string brand, float pret)
        {
            
            this.obiect = obiect;
            this.culoare = culoare;
            this.brand = brand;
            this.pret = pret;
        }
        public string Obiect
        {
            get
            {
                return obiect;
            }
            set
            {
                obiect = value;
            }
        }
        public int Cod
        {
            get
            {
                return cod;
            }
           
        }

        public string Culoare
        {
            get
            {
                return culoare;
            }
            set
            {
                culoare = value;
            }
        }
        public string Brand
        {
            get
            {
                return brand;
            }
            set
            {
                brand = value;
            }
        }
        public float Pret
        {
            get
            {
                return pret;
            }
            set
            {
                pret = value;
            }
        }

        public override string ToString()
        {
            return "\n"+cod +","+ obiect + "," + culoare + "," + brand + "," + pret;

        }
    }

}

