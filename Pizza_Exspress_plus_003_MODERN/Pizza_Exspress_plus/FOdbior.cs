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
    
    public partial class FOdbior : Form
    {
        private int x = 0; private int y = 0; // do przesuniecia okna
        public FOdbior()
        {            
            InitializeComponent();
            dodajKlienta.Enabled = false; // Validacja
            nazwiskoBox.Enabled = false;
            numerTelBox.Enabled = false;
            gotowkaRB.Enabled = false;
            kartaRB.Enabled = false;



            for (int i = 10; i < 23; i++) { godzina.Items.Add(i.ToString());}
            for (int i = 0; i < 61; i++) { if (i < 10) { minuta.Items.Add("0" + i.ToString()); } else minuta.Items.Add(i.ToString()); }


        }
        private string im, na, nu, uw, czG = "--",czM = "--", pla; // dlia pobierania if klienta
        private bool vi = false; // status VIP pobiera
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
        
        private void wybierzGodzine(object sender, EventArgs e) // pobiera godzine 
        {
            czG = godzina.Text; 
        }

        private void wybierzMinute(object sender, EventArgs e) // pobiera minute
        {
            czM = minuta.Text; //minuta
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

        private void uwagiZmien(object sender, EventArgs e)
        {
            uw = uwagiBox.Text.ToString(); // uw to uwagi
        } 

        private void paintOdbiur(object sender, PaintEventArgs e)
        {
            if (numerTelBox.MaskCompleted)
            {
                //numer telefonu
                nu = numerTelBox.Text.ToString();
                gotowkaRB.Enabled = true;
                kartaRB.Enabled = true;               
            }

        }

        private void statusZmien(object sender, EventArgs e)
        {
            vi = false; // status vip
            if (status.CheckState.ToString() == "Checked") { vi = true; }
        }


        private void kartaZmien(object sender, EventArgs e)
        {
            pla = "Płatność kartą"; dodajKlienta.Enabled = true; // pla platnosc
        }

        private void gotowkaZmien(object sender, EventArgs e)
        {
            pla = "Płatność gotówką"; dodajKlienta.Enabled = true; // pla platnosc
        }


        private void dodajKlientaP(object sender, EventArgs e)
        {            
            FMenu newm = new FMenu(); // menu zamowien
            newm.clssSender(im, na, vi, nu,czG + ":" + czM, pla + " " + uw + " Odbiur"); // wykorzystuje clssSender dlia tego mam internal w klasie Menu
            this.Hide();
            newm.Show();
        }

    }
}
