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
        double hmotnost;
        double vyska;

        protected string Jmeno
        {
            get => jmeno; // == return jmeno
            set{ this.jmeno = value; }
        }
        protected string Prijmeni
        {
            get => prijmeni; 
            set { this.prijmeni = value; }
        }
        protected double Hmotnost
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
        protected double Vyska
        {
            get => vyska / 100;
            set { this.vyska = value; }
        }

        public Osoba(string jmeno, string prijmeni, double hmotnost, double vyska)
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.hmotnost = hmotnost;
            this.vyska = vyska;
        }

        public double BMI()
        {
            return Math.Round((Hmotnost / (Vyska * Vyska)),2);
        }

        public override string ToString()
        {
            return string.Format("Jmeno : {0} \nPrijmeni : {1} \nBMI: {2}",Jmeno, Prijmeni ,BMI());
        }
    }
}
