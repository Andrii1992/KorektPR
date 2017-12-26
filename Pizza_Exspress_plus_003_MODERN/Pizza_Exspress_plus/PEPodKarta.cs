using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; 
using System.Threading;

namespace Pizza_Exspress_plus
{
    public partial class PEPodKarta : UserControl
    {
        private static Label odsPod;
        public static Label OdsPod { get { return odsPod; } }
        public PEPodKarta()
        {
            InitializeComponent();
            if (DaneOb.Prod.Count > 0) { drukujPar.Enabled = true; }
            else { drukujPar.Enabled = false; }
            odsPod = this.kartaP;

        }

    
       // w menu wyswietla finalnu cenu dlia karty
        private void drukujParagon(object sender, EventArgs e)
        {
            FileStream paragon = null;
            StreamWriter writer = null;

            try
            {

                if (DaneOb.adresSprawdz(DaneOb.AdresParagon))
                {
                    File.WriteAllText(DaneOb.AdresParagon, string.Empty); //czysci paragon
                    paragon = new FileStream(DaneOb.AdresParagon, FileMode.Open);
                    writer = new StreamWriter(paragon);

                }
                else
                {

                    paragon = new FileStream(DaneOb.AdresParagon, FileMode.Create);
                    writer = new StreamWriter(paragon);
                    DaneOb.plikInfo("Plik " + DaneOb.AdresParagon + " został stworzony", ToolTipIcon.Info);
                }
                // paragon
                writer.WriteLine("PIZZA express + /POLSKA/ Sp. z o. o.   ");
                writer.WriteLine("ul. Jagiellońska 52, 10-279 Olsztyn    ");
                writer.WriteLine("        NIP 526-10-37-739              ");
                writer.WriteLine("---------------------------------------");
                writer.WriteLine();
                writer.WriteLine(DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day);
                writer.WriteLine();
                writer.WriteLine("        PARAGON FISKALNY            ");

                for (int i = 0; i < DaneOb.Prod.Count; i++)
                {
                    writer.WriteLine(DaneOb.Prod[i].Nazwa.PadRight(31, '.') + DaneOb.Prod[i].Cena.ToString("0.00").PadLeft(5, '.'));
                }
                writer.WriteLine();
                writer.WriteLine("Podsuma                        " + DaneOb.Final.ToString("0.00"));
                writer.WriteLine();
                writer.WriteLine();
                writer.WriteLine("---------------------------------------");
                writer.WriteLine("PSRZEDARZ OPODATKOWANIA A      " + Math.Round((DaneOb.Final * 0.1d), 2).ToString("0.00"));
                writer.WriteLine("PTU A 23 %                     " + Math.Round(((DaneOb.Final * 0.1d) * 0.22d), 2).ToString("0.00"));
                writer.WriteLine("PSRZEDARZ OPODATKOWANIA D      " + Math.Round((DaneOb.Final - (DaneOb.Final * 0.1d)), 2).ToString("0.00"));
                writer.WriteLine("PTU A 5.00 %                   " + Math.Round(((DaneOb.Final - (DaneOb.Final * 0.1d)) * 0.05d), 2).ToString("0.00"));
                writer.WriteLine("SUMA PTU                       " + Math.Round((((DaneOb.Final * 0.1d) * 0.22d) + ((DaneOb.Final - (DaneOb.Final * 0.1d)) * 0.05d)), 2).ToString("0.00"));
                writer.WriteLine("---------------------------------------");
                writer.WriteLine(DateTime.Now.Hour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00") + ":" + DateTime.Now.Second.ToString("00"));
                writer.WriteLine();
                writer.WriteLine();
                writer.WriteLine("SUMA PLN                       " + DaneOb.Final.ToString("0.00"));
                writer.WriteLine();
                writer.WriteLine();
                writer.WriteLine("Platnosc karta                         ");
                writer.WriteLine();
                writer.WriteLine();
                writer.WriteLine();
                writer.WriteLine("---------------------------------------");
                writer.WriteLine("       www.expresspluswz.com.pl        ");
                writer.WriteLine("       Info linija 800 500 789         ");
                writer.WriteLine("    Nr rejestrowy GETAR E0002022WBW    ");



            }
            catch (Exception x)
            {
                DaneOb.plikInfo(x.Message, ToolTipIcon.Error);
            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                    writer = null;
                }
                if (paragon != null)
                {
                    paragon.Close();
                    paragon = null;
                }
            }

            DaneOb.dodajInfoKlienta();
            
            DaneOb.wyczysc();
            kartaP.Text = "0";
            DaneOb.KartaGotowka = "";
            PEmenuKartaGotowka.StanKartaRB.Checked = false;
            FMenu.Zakryc.BringToFront();

            if (DaneOb.IdikatorKlassy)
            {
                FMenu.Fmenu.Hide();
                DaneOb.resetujIdikatorKlassy();
            }

        }


        private void odswiez(object sender, EventArgs e)
        {
            kartaP.Text = DaneOb.Final.ToString();
            // jesli jest towar na liscie do mozna drukowac paragon
            if (DaneOb.Prod.Count > 0) { drukujPar.Enabled = true; }
            else { drukujPar.Enabled = false; }
        }

        private void kartaPaint(object sender, PaintEventArgs e)
        {
            kartaP.Text = DaneOb.Final.ToString();            
        }

    }
}
