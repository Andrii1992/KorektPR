using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Exspress_plus
{
    class Napoje : Product
    {
        private string litr;
        private char rodzaj;
        public Napoje(string nazwa, double cena, string litr, char rodzaj) : base(nazwa, cena)
        {
            this.litr = litr;
            this.rodzaj = rodzaj;
        }
    }
}
