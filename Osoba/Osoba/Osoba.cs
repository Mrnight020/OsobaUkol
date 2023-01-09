using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Osoba
{
    class Osoba
    {
        string jmeno;
        string prijmeni;
        float hmotnost;
        float vyska;

        string Jmeno
        {
            get => jmeno; // == return ridicvek
            set{ this.jmeno = value; }
        }
        string Prijmeni
        {
            get => prijmeni; // == return ridicvek
            set { this.prijmeni = value; }
        }
        float Hmotnost
        {
            get => hmotnost; // == return ridicvek
            set { 
                if(hmotnost <= 300)
                {
                    this.hmotnost = value;
                }
                else
                {
                    MessageBox.Show("Hmotnost je mimo rozsah a hodnota se neuložila");
                }
                
            }
        }
        float Vyska
        {
            get => vyska; // == return ridicvek
            set { this.vyska = value; }
        }

        public Osoba(string jmeno, string prijmeni, float hmotnost, float vyska)
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.hmotnost = hmotnost;
            this.vyska = vyska;
        }

        public double BMI()
        {
            return ( Hmotnost / Vyska * Vyska );
        }
    }
}
