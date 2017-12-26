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
    public partial class PEmenuKartaGotowka : UserControl
    {
        
        
        private static RadioButton stanGotowkaRB;
        private static RadioButton stanKartaRB;
        public static RadioButton StanKartaRB { get { return stanKartaRB; } }
        public static RadioButton StanGotowkaRB { get { return stanGotowkaRB; } }
        
        public PEmenuKartaGotowka()
        {
            InitializeComponent();

            stanGotowkaRB = this.gotowkaRB;
            stanKartaRB = this.kartaRB;         
        }
        
        // w menu pobiera platnosc

        private void kartaZmien(object sender, EventArgs e)
        {
            DaneOb.dodajInfoKG("Płatność kartą");
            DaneOb.dodajInfoMajak2();
        }

        private void gotowkaZmien(object sender, EventArgs e)
        {
            DaneOb.dodajInfoKG("Płatność gotówką");
            DaneOb.dodajInfoMajak2();
        }
    }
}




