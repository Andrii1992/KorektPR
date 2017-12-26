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
    public partial class PEPizze : UserControl
    {
        List<Pizze> menuP = new List<Pizze>();
       
        public PEPizze()
        {
            
            InitializeComponent(); // Lista menu pizz
            menuP.Add(new Pizze("Pizza FUNGHI MAX", 30.95, "sos, pieczarki, ser", "Max"));
            menuP.Add(new Pizze("Pizza FUNGHI ŚRE", 19.95, "sos, pieczarki, ser", "Średnia"));
            menuP.Add(new Pizze("Pizza FUNGHI MAŁ", 16.98, "sos, pieczarki, ser", "Mała"));
            menuP.Add(new Pizze("Pizza PEPERONI ŚRE", 19.15, "salami, cebula, sos pomidorowy", "Średnia"));
            menuP.Add(new Pizze("Pizza PEPERONI MAŁ", 15.45, "salami, cebula, sos pomidorowy", "Mała"));
            menuP.Add(new Pizze("Pizza MIĘSNA MAX", 36.99, "mięso wołowe, sos pomidorowy", "Max"));
            menuP.Add(new Pizze("Pizza MIĘSNA ŚRE", 21.99, "mięso wołowe, sos pomidorowy", "Średnia"));
            menuP.Add(new Pizze("Pizza MIĘSNA MAŁ", 18.95, "mięso wołowe, sos pomidorowy", "Mała"));
            menuP.Add(new Pizze("Pizza RIMINI ŚRE", 17.85, "salami, pieczarki, sos pomidorowy", "Średnia"));
            menuP.Add(new Pizze("Pizza RIMINI MAŁ", 14.89, "salami, pieczarki, sos pomidorowy", "Mała"));
            menuP.Add(new Pizze("Pizza BARBECUE ŚRE", 18.55, "boczek, kurczak gyros, cebula, sos Barbecue", "Średnia"));
            menuP.Add(new Pizze("Pizza BARBECUE MAŁ", 14.59, "boczek, kurczak gyros, cebula, sos Barbecue", "Mała"));

        }


        private void dodaj(object sender, EventArgs e)
        {
            Button dodajT = sender as Button;

            switch (dodajT.Name.ToString())
            {
                case "pizzaFunghiMax":     { DaneOb.dodaj((Product)menuP[0]);  break; }
                case "pizzaFunghiSrednia": { DaneOb.dodaj((Product)menuP[1]);  break; }
                case "pizzaFungchiMala":   { DaneOb.dodaj((Product)menuP[2]);  break; }
                case "peperoniSre":        { DaneOb.dodaj((Product)menuP[3]);  break; }
                case "peperoniMala":       { DaneOb.dodaj((Product)menuP[4]);  break; }
                case "miensnaMax":         { DaneOb.dodaj((Product)menuP[5]);  break; }
                case "miensnaSre":         { DaneOb.dodaj((Product)menuP[6]);  break; }
                case "miensnaMala":        { DaneOb.dodaj((Product)menuP[7]);  break; }
                case "riminiSre":          { DaneOb.dodaj((Product)menuP[8]);  break; }
                case "riminiMala":         { DaneOb.dodaj((Product)menuP[9]);  break; }
                case "barbecueSre":        { DaneOb.dodaj((Product)menuP[10]); break; }
                case "barbecueMala":       { DaneOb.dodaj((Product)menuP[11]); break; }

            }
        }
    }
}
