using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_Exspress_plus
{
   abstract class Product
    {

        private string nazwa;
        private double cena;

        public Product(string nazwa, double cena)
        {
            this.nazwa = nazwa;
            this.cena = cena;
        }

        public string Nazwa { get => nazwa; }
        public double Cena { get => cena; }
    }
}
