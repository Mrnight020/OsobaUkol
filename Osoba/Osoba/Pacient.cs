using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osoba
{
    internal class Pacient:Osoba
    {
        float obvodpasu;
        float Obvodpasu { 
            get => obvodpasu/100;
            set { this.obvodpasu = value; }
        }
        public Pacient(float obvodpasu,string jmeno, string prijmeni, float hmotnost, float vyska) :base(jmeno,prijmeni,hmotnost,vyska)
        {
            Obvodpasu=obvodpasu;
        }
        public float BMSI()
        {
            return Obvodpasu/100;
        }
    }
}
