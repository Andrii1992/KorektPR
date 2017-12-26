using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using System.Threading;
namespace Pizza_Exspress_plus
{
    static class DaneOb
    {
        private static BindingList<Product> prod = new BindingList<Product>();
        private static double final = 0d;
        private static string kartaGotowka;
        private static bool majak = false;
        private static bool majak2 = false;
        private static bool idikatorKlassy = false;
        private static string adresParagon = "paragon.txt";
        private static string adresArchiw = "KlienciDane.txt";        
        public static double Final { get => final; }
        internal static BindingList<Product> Prod { get => prod; }
        public static bool Majak { get => majak; }
        public static bool Majak2 { get => majak2; }
        public static string KartaGotowka { get => kartaGotowka; set => kartaGotowka = value; }
        public static string AdresParagon { get => adresParagon; set => adresParagon = value; }
        public static string AdresArchiw { get => adresArchiw; set => adresArchiw = value; }
        public static bool IdikatorKlassy { get => idikatorKlassy; }

        public static void usun()
        {
            if (final > 0d)
            {
                final = final - ((Product)prod.Last()).Cena;
                final = Math.Round(final, 2);
                prod.Remove(prod.Last());
            }
        }

        public static void wyczysc()
        {
            prod.Clear();
            final = 0d;
        }

        public static void dodaj(Product temp)
        {
            prod.Add(temp);
            final += Math.Round(temp.Cena, 2);
        }
        public static void dodajInfoKG(string info)
        {
            KartaGotowka = info;
        }
        public static void usunInfoKG()
        {
            KartaGotowka = "";
        }
        public static void dodajInfoMajak()
        {
            majak = true;
        }
        public static void resetujMajak()
        {
            majak = false;
        }
        public static void dodajInfoMajak2()
        {
            majak2 = true;
        }
        public static void resetujMajak2()
        {
            majak2 = false;
        }

        public static void dodajIdikatorKlassy()
        {
            idikatorKlassy = true;
        }
        public static void resetujIdikatorKlassy()
        {
            idikatorKlassy = false;
        }
        
        public static void dodajInfoKlienta()
        {
            FileStream fstream = null;
            StreamWriter writer = null;

            try
            {
                if (File.Exists(AdresParagon))
                {
                    string[] dane = File.ReadAllLines(AdresParagon);
                    if (dane != null)
                    {
                        if (adresSprawdz(AdresArchiw))
                        {

                            writer = File.AppendText(AdresArchiw);
                            foreach (string daneF in dane)
                            {
                                writer.WriteLine(daneF);
                            }

                        }
                        else
                        {
                            fstream = new FileStream(AdresArchiw, FileMode.Create);
                            fstream.Close();

                            writer = File.AppendText(AdresArchiw);
                            foreach (string daneF in dane)
                            {
                                writer.WriteLine(daneF);
                            }
                            plikInfo("Plik " + AdresArchiw + " został stworzony", ToolTipIcon.Info);

                        }
                    }
                    else
                    {
                        plikInfo(" Plik " + AdresParagon + " jest pusty", ToolTipIcon.Error);
                    }

                }
                else
                {
                    plikInfo("Nie istnieje plik " + AdresParagon, ToolTipIcon.Error);
                }

            }
            catch (Exception x)
            {
                plikInfo(x.Message, ToolTipIcon.Error);
            }
            finally
            {
                if (writer != null)
                {                   
                    writer.Close();
                    writer = null;                   

                }
                if (fstream != null)
                {                    
                    fstream.Close();
                    fstream = null;
                }
            }
        }


        public static bool adresSprawdz(string adres)
        {
            if (File.Exists(adres))
            {                
                FileInfo info = new FileInfo(adres);

                if (info.IsReadOnly) // jesli istneje i tylko do odczytu 
                {
                    int liczbaAw = 1; // liczba awarijnycz zapisow
                    string rezerw = "";                    

                    if (!adres.Contains("-liczba_zapisow_AWARYJNE_KOPIOWANIE_"))
                    {
                        rezerw = adres;
                    }
                    else
                    {
                        if (adres.EndsWith("paragon.txt")) { rezerw = "paragon.txt"; }
                        if (adres.EndsWith("KlienciDane.txt")) { rezerw = "KlienciDane.txt"; }
                    }

                    while (File.Exists(adres)) // dopuki nie bedzie unikalna nazwa lub awaryjny plik dostepny do zapisu
                    {

                        if (File.Exists(liczbaAw.ToString("000") + "-liczba_zapisow_AWARYJNE_KOPIOWANIE_" + rezerw))
                        {
                            FileInfo info2 = new FileInfo(liczbaAw.ToString("000") + "-liczba_zapisow_AWARYJNE_KOPIOWANIE_" + rezerw);

                            if (!info2.IsReadOnly)
                            {

                                switch (string.Compare("paragon.txt", rezerw))
                                { 

                                    case 0:
                                        {
                                            AdresParagon = (liczbaAw.ToString("000") + "-liczba_zapisow_AWARYJNE_KOPIOWANIE_" + rezerw);
                                            adres = AdresParagon;

                                            break;
                                        }
                                    case 1:
                                        {                                           
                                            AdresArchiw = (liczbaAw.ToString("000") + "-liczba_zapisow_AWARYJNE_KOPIOWANIE_" + rezerw);
                                            adres = AdresArchiw;

                                            break;
                                        }
                                }

                                return true; //otworz
                            }
                            else
                            {
                                liczbaAw++;
                            }

                        }
                        else  // awarij nie bylo
                        {
                            switch (string.Compare("paragon.txt", rezerw))
                            {

                                case 0:
                                    {
                                        AdresParagon = (liczbaAw.ToString("000") + "-liczba_zapisow_AWARYJNE_KOPIOWANIE_" + rezerw);
                                        adres = AdresParagon;                                       

                                        break;
                                    }
                                case 1:
                                    {                                        
                                        AdresArchiw = (liczbaAw.ToString("000") + "-liczba_zapisow_AWARYJNE_KOPIOWANIE_" + rezerw);
                                        adres = AdresArchiw;                                        

                                        break;
                                    }
                            }
                           liczbaAw++;

                        }

                    }
                    return false; //stwoz

                }
                else
                {                    
                   return true; //otworz

                }
            }
            return false; //stwoz

        }

        public static void plikInfo(string info, ToolTipIcon ade)
        {           
            FStart.Notifier.ShowBalloonTip(5000, "PIZZA express + ", info, ade);
            Thread.Sleep(1000); // jak dwa pliki naraz tworzone to zeby bylo widac
        }

    }
}