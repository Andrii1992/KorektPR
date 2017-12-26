using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Exspress_plus
{
    class Sous : Product
    {
        private string ml;
        public Sous(string nazwa, double cena, string ml) : base(nazwa, cena)
        {
            this.ml = ml;
        }
    }
}
