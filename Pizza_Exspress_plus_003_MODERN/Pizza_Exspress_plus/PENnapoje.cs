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
    public partial class PENnapoje : UserControl
    {
        List<Napoje> menuN = new List<Napoje>(); // menu napojow
        
        public PENnapoje()
        {
            InitializeComponent();
            menuN.Add(new Napoje("Pepsi 0.5l", 3, "0.5", 'N'));
            menuN.Add(new Napoje("Pepsi 1l", 5, "1", 'N'));
            menuN.Add(new Napoje("Pepsi 2l", 8, "2", 'N'));
            menuN.Add(new Napoje("Coca-Cola 0.5l", 3, "0.5", 'N'));
            menuN.Add(new Napoje("Coca-Cola 1l", 5, "1", 'N'));
            menuN.Add(new Napoje("Coca-Cola 2l", 8, "2", 'N'));
            menuN.Add(new Napoje("Fanta 0.5l", 3, "0.5", 'N'));
            menuN.Add(new Napoje("Fanta 1l", 5, "1", 'N'));
            menuN.Add(new Napoje("Fanta 2l", 8, "2", 'N'));
            menuN.Add(new Napoje("Sprite 0.5l", 3, "0.5", 'N'));
            menuN.Add(new Napoje("Sprite 1l", 5, "1", 'N'));
            menuN.Add(new Napoje("Sprite 2l", 8, "2", 'N'));
        }                      

        private void dodaj(object sender, EventArgs e)
        {
            Button dodajT = sender as Button;

            switch (dodajT.Name.ToString())
            {
                case "pepsi05":  { DaneOb.dodaj((Product)menuN[0]);  break; }
                case "pepsi1l":  { DaneOb.dodaj((Product)menuN[1]);  break; }
                case "pepsi2l":  { DaneOb.dodaj((Product)menuN[2]);  break; }
                case "cola05":   { DaneOb.dodaj((Product)menuN[3]);  break; }
                case "cola1l":   { DaneOb.dodaj((Product)menuN[4]);  break; }
                case "cola2l":   { DaneOb.dodaj((Product)menuN[5]);  break; }
                case "fanta05":  { DaneOb.dodaj((Product)menuN[6]);  break; }
                case "fanta1l":  { DaneOb.dodaj((Product)menuN[7]);  break; }
                case "fanta2l":  { DaneOb.dodaj((Product)menuN[8]);  break; }
                case "sprite05": { DaneOb.dodaj((Product)menuN[9]);  break; }
                case "sprite1l": { DaneOb.dodaj((Product)menuN[10]); break; }
                case "sprite2l": { DaneOb.dodaj((Product)menuN[11]); break; }

            }

        }
    }
}
