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
    public partial class FStart : Form
    {

        private int x = 0; private int y = 0; // do przesuniecia okna

        public static NotifyIcon Notifier { get { return notifier; } }

        private static NotifyIcon notifier;
        public FStart()
        {
            InitializeComponent();
            notifier = this.PizzaNotifyIcon;
            this.FormClosed += delegate { notifier = null; };
        }


        private void zminimalizuj(object sender, EventArgs e) // minimalizacja
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void powiekszPomiejsz(object sender, EventArgs e) // powienkszenie pomiejszenie
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

        private void zamknij(object sender, EventArgs e) // zamyka aplikacje
        {
             Close();
        }

        private void przesunM(object sender, MouseEventArgs e)// pszesuniecie
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Location = new System.Drawing.Point(this.Location.X + (e.X - x), this.Location.Y + (e.Y - y));

            }
        }

        private void przesunD(object sender, MouseEventArgs e)// pszesuniecie
        {
            x = e.X; y = e.Y;
        }

        private void noweZamowienie(object sender, EventArgs e)
        {
            zamowienie.BringToFront();
        }

        private void wyswietlPeomocje(object sender, EventArgs e)
        {
            promocje.BringToFront(); 
        }

        private void normaRozm(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }
    }
}
