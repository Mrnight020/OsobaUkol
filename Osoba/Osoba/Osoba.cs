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
            get => jmeno; // == return jmeno
            set{ this.jmeno = value; }
        }
        string Prijmeni
        {
            get => prijmeni; 
            set { this.prijmeni = value; }
        }
        float Hmotnost
        {
            get => hmotnost;
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
            get => vyska / 100;
            set { this.vyska = value; }
        }

        public Osoba(string jmeno, string prijmeni, float hmotnost, float vyska)
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.hmotnost = hmotnost;
            this.vyska = vyska;
        }

        public float BMI()
        {           
            return (Hmotnost / (Vyska * Vyska));
        }

        public override string ToString()
        {
            return string.Format("Jmeno : {0} \nPrijmeni : {1} \n BMI: {3}",Jmeno, Prijmeni ,BMI());
        }
    }
}
