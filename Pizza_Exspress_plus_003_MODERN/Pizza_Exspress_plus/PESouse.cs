using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Exspress_plus
{
    public partial class PESouse : UserControl
    {
        List<Sous> menuS = new List<Sous>();
        public PESouse()
        {
            InitializeComponent();
            //menu souse
            menuS.Add(new Sous("Czosnkowy 80ml", 1.99, "80ml"));
            menuS.Add(new Sous("Czosnkowy 120ml", 2.99, "120ml"));
            menuS.Add(new Sous("Gyros 80m", 1.99, "80ml"));
            menuS.Add(new Sous("Gyros 120ml", 2.99, "120ml"));
            menuS.Add(new Sous("Jalapeno 80ml", 1.99, "80ml"));
            menuS.Add(new Sous("Jalapeno 120ml", 2.99, "120ml"));
            menuS.Add(new Sous("Pomidorowy 80ml", 1.99, "80ml"));
            menuS.Add(new Sous("Pomidorowy 120ml", 2.99, "120ml"));
            menuS.Add(new Sous("Pikantny 80ml", 1.99, "80ml"));
            menuS.Add(new Sous("Pikantny 120ml", 2.99, "120ml"));
            menuS.Add(new Sous("Kabul 80ml", 1.99, "80ml"));
            menuS.Add(new Sous("Kabul 120ml", 2.99, "120ml"));
        }                    


        private void dodaj(object sender, EventArgs e)
        {
            Button dodajT = sender as Button;

            switch (dodajT.Name.ToString())
            {
                case "czosnkowy80":   { DaneOb.dodaj((Product)menuS[0]);  break; }
                case "czosnkowy120":  { DaneOb.dodaj((Product)menuS[1]);  break; }
                case "gyros80":       { DaneOb.dodaj((Product)menuS[2]);  break; }
                case "gyros120":      { DaneOb.dodaj((Product)menuS[3]);  break; }
                case "jalapeno80":    { DaneOb.dodaj((Product)menuS[4]);  break; }
                case "jalapeno120":   { DaneOb.dodaj((Product)menuS[5]);  break; }
                case "pomidorowy80":  { DaneOb.dodaj((Product)menuS[6]);  break; }
                case "pomidorowy120": { DaneOb.dodaj((Product)menuS[7]);  break; }
                case "pikantny80":    { DaneOb.dodaj((Product)menuS[8]);  break; }
                case "pikantny120":   { DaneOb.dodaj((Product)menuS[9]);  break; }
                case "kabul80":       { DaneOb.dodaj((Product)menuS[10]); break; }
                case "kabul120":      { DaneOb.dodaj((Product)menuS[11]); break; }

            }

        }

    }
}
