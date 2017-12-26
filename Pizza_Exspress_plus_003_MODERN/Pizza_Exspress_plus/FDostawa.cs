using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Pizza_Exspress_plus
{
    public partial class FDostawa : Form
    {
        private string im, na, nu, ad, adn, adn2, uw, pla; // dlia pobierania if klienta
        private bool vi = false; // status VIP pobiera
        private int x = 0; private int y = 0; //dlia przesuniencia okna
        public FDostawa()
        {
            InitializeComponent();
            dodajKlienta.Enabled = false; // Validacja
            nazwiskoBox.Enabled = false;
            numerTelBox.Enabled = false;
            adresBox.Enabled = false;
            adresNum.Enabled = false;
            adresNum2.Enabled = false;
            gotowkaRB.Enabled = false;
            kartaRB.Enabled = false;
        }

        private void imieZmien(object sender, EventArgs e)
        {
             // im to imie
            im = imieBox.Text.ToString();
            if (im.Length > 2) { nazwiskoBox.Enabled = true; }
        }

        private void nazwiskoZmien(object sender, EventArgs e)
        {
             //ad to nazwisko
            na = nazwiskoBox.Text.ToString();
            if (na.Length > 2) { numerTelBox.Enabled = true; }
        }
        private void statusZmien(object sender, EventArgs e)
        {
            vi = false; // status vip
            if (status.CheckState.ToString() == "Checked") { vi = true; }
        }
        private void adresZmien(object sender, EventArgs e)
        {
             //nazwa ulicy
            ad = adresBox.Text.ToString();
            if (ad.Length < 2) { adresNum.Enabled = true; }
        }
        private void adresNumZmien(object sender, EventArgs e)
        {
            if (adresNum.Text != null) { adresNum2.Enabled = true; adn = adresNum.Text.ToString(); } //adn to numer budynku
        }

        private void adresNum2Zmien(object sender, EventArgs e)
        {
            if (adresNum2.Text != null) { gotowkaRB.Enabled = true; kartaRB.Enabled = true; adn2 = adresNum2.Text.ToString(); } //adn2 to numer mieszkania
        }
        private void kartaZmien(object sender, EventArgs e)
        {
            pla = "Płatność kartą"; dodajKlienta.Enabled = true; // pla platnosc
        }

        private void uwagiZmien(object sender, EventArgs e)
        {
            uw = uwagiBox.Text.ToString(); // uw to uwagi
        }

        private void paintDostawa(object sender, PaintEventArgs e)
        {
            if (numerTelBox.MaskCompleted)
            {
                //numer telefonu
                nu = numerTelBox.Text.ToString();
                adresBox.Enabled = true;
            }            

        }

        private void gotowkaZmien(object sender, EventArgs e)
        {
            pla = "Płatność gotówką"; dodajKlienta.Enabled = true; // pla platnosc
        }

        private void dodajKlientaP(object sender, EventArgs e) 
        {
            ad += " " + adn + " / " + adn2; // dodanie nazwy ulicy numeru budynku i mieszkania
            FMenu newm = new FMenu(); // menu zamowien
            newm.clssSender(im, na, vi, nu, ad, pla + " " + uw + " Dostawa"); // wykorzystuje clssSender dlia tego mam internal w klasie Menu
            this.Hide();
            newm.Show();
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

    }
}
