using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Osoba
{
    internal class Pacient:Osoba
    {
        double obvodpasu;
        double Obvodpasu { 
            get => obvodpasu;
            set { this.obvodpasu = value; }
        }
        public Pacient(double obvodpasu,string jmeno, string prijmeni, double hmotnost, double vyska) :base(jmeno,prijmeni,hmotnost,vyska)
        {
            Obvodpasu=obvodpasu;
        }
        public double BMSI()
        {
            obvodpasu/= 100;

            return Math.Round((Obvodpasu / (Math.Pow(BMI(),0.6666666) * Math.Pow(Vyska, 0.5))),3);
        }
    }
}
