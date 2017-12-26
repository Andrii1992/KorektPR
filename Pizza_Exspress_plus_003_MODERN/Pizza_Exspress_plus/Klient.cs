using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
namespace Pizza_Exspress_plus
{
    class Klient : IZapiszD
    {
        
        private string imie;
        private string nazwisko;
        private bool vip;
        private string numer_telef;
        private string adres;
        private string uwagi;
        

        public string Imie { get => imie; }
        public string Nazwisko { get => nazwisko; }
        public bool Vip { get => vip; }
        public string Numer_telef { get => numer_telef; }
        public string Adres { get => adres; }
        public string Uwagi { get => uwagi; }


        public Klient(string imie, string nazwisko, bool vip, string numer_telef, string adres, string uwagi)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.vip = vip;
            this.numer_telef = numer_telef;
            this.adres = adres;
            this.uwagi = uwagi;
            zapiszDane(imie, nazwisko, vip, numer_telef, adres, uwagi);
        }

        public void zapiszDane(string imie, string nazwisko, bool vip, string numer_telef, string adres, string uwagi)
        {
            bool dopis = false;
            FileStream fstream = null;
            StreamWriter writer = null;
            try
            {


                if (DaneOb.adresSprawdz(DaneOb.AdresArchiw))
                {
                    File.WriteAllText(DaneOb.AdresArchiw, string.Empty); //czysci paragon
                    fstream = new FileStream(DaneOb.AdresArchiw, FileMode.Open);
                    writer = new StreamWriter(fstream);

                }
                else
                {

                    fstream = new FileStream(DaneOb.AdresArchiw, FileMode.Create);
                    writer = new StreamWriter(fstream);
                    DaneOb.plikInfo("Plik " + DaneOb.AdresArchiw + " został stworzony", ToolTipIcon.Info);
                }

                    writer.WriteLine();
                    writer.WriteLine("-------------------------------------");
                    writer.WriteLine();
                    writer.WriteLine();
                    writer.WriteLine("Imie              " + imie);
                    writer.WriteLine("Nazwisko          " + nazwisko);
                    writer.WriteLine("Status vip        " + vip);
                    writer.WriteLine("Numer telefonu    " + numer_telef);
                    writer.WriteLine("Czas lub adres    " + adres);
                    writer.WriteLine(uwagi);
                    writer.WriteLine();
                    writer.WriteLine();

                if (dopis)
                {
                    fstream.Seek(0, SeekOrigin.End);
                    dopis = false;
                }

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
                if (fstream != null)
                {
                    fstream.Close();
                    fstream = null;
                }
            }             

        }
    }
}
