using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Pizza_Exspress_plus
{
    public partial class FMenu : Form
    {
        private BindingList<Product> produkts = new BindingList<Product>(); // lista 
        private Klient temp; // dlia przerzcania info obiektu klient        
        private int x = 0; private int y = 0; // do przesuniecia okna
        private static UserControl zakryc; // zeby przekryc inna panel w menu 
        private static Form fmenu; //zeby zakryc z innego miejsca
        public static UserControl Zakryc { get { return zakryc; } }
        public static Form Fmenu { get { return fmenu; } }
        


        //korzystam z clssSender w clasie  Dostawa dlia tego mod internal
        internal void clssSender(string imie, string nazwisko, bool vip, string numer_telef, string adres, string uwagi)
        {
            temp = new Klient(imie, nazwisko, vip, numer_telef, adres, uwagi);
            numerTelW.Text = numer_telef;
            adresW.Text = adres;
            DaneOb.dodajIdikatorKlassy();
            DaneOb.dodajIdikatorKlassy();
        }

        public FMenu()
        {
            InitializeComponent();
            numerTelW.Text = ""; //  jak wchodzimy przez zamowienie z lokalu nic nie bylo wyswietlane 
            adresW.Text = "";  // --||--||-
            zakryc = this.zakrycie;
            fmenu = this;
        }

        private void zminimalizuj(object sender, EventArgs e) // minimalizacja
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void powiekszPomiejsz(object sender, EventArgs e) //powienkszenie pomiejszenie
        {
            if (this.WindowState == System.Windows.Forms.FormWindowState.Maximized)
            {
                this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
            else
            {
                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            }
        }

        private void zamknij(object sender, EventArgs e) //zanmykanie tylko tego okna
        {
            this.Hide();
        }

        private void przesunD(object sender, MouseEventArgs e) // pszesuniecie
        {
            x = e.X; y = e.Y;
        }

        private void przesunM(object sender, MouseEventArgs e) // pszesuniecie
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Location = new System.Drawing.Point(this.Location.X + (e.X - x), this.Location.Y + (e.Y - y));

            }
        }

        private void usunDaneZListy(object sender, EventArgs e) //usuwam dane z listy pojedynczo
        {
            DaneOb.usun();
        }

        private void dodajPizze(object sender, EventArgs e) //wybor piz
        {
            pizzE_P1.BringToFront();
        }

        private void dodajSouse(object sender, EventArgs e) //wybor sosow
        {
            sousE_P1.BringToFront();
        }

        private void dodajNapoje(object sender, EventArgs e) //wybur napojow
        {
            napojE_P1.BringToFront();
        }

        private void podsumujZamowienie(object sender, EventArgs e)
        {
            // jesli wchodzisz przez dostawe to zeby nie bylo menu wyboru platnosci
            if ((DaneOb.IdikatorKlassy == true) && (temp.Uwagi.Contains("Płatność kartą")) || (DaneOb.KartaGotowka == "Płatność kartą"))
            {
                podKartaP.BringToFront();
                PEPodKarta.OdsPod.Text = DaneOb.Final.ToString();                
            }
            // a przez inne to  menu wyboru platnosci
            else if ((DaneOb.IdikatorKlassy == true) && (temp.Uwagi.Contains("Płatność gotówką")) || (DaneOb.KartaGotowka == "Płatność gotówką"))
            {
                podsumowanieReszta.BringToFront();
                PEPodsumowanieReszta.OdsPod.Text = DaneOb.Final.ToString();
            }
                     
          //  podsumowanie.Enabled = false;           

        }

        private void menuPaint(object sender, PaintEventArgs e)
        {
            // zeby nie mozna bylo kliknac na podsumowanie bez wybranej wczesniej platnosci
            if (DaneOb.Majak) { menuKartaGotowkaO.BringToFront(); podsumowanie.Enabled = false; DaneOb.resetujMajak();/*wraca majak na false*/ }
            
        }

        private void klikMenu(object sender, EventArgs e)
        {
            // jesli platnosc wybrana to podwojnym klikiem mozna podsumowac
            if (DaneOb.Majak2)
            {
                podsumowanie.Enabled = true;
                DaneOb.resetujMajak2(); //wraca majak2 na false
            }
            
        }

    }
}
