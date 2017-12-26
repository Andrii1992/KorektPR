using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Exspress_plus
{
    class Pizze : Product
    {
        private string skladniki;
        private string rozmiar;

        public Pizze(string nazwa, double cena, string skladniki, string rozmiar) : base(nazwa, cena)
        {
            this.skladniki = skladniki;
            this.rozmiar = rozmiar;
        }

    }
}
