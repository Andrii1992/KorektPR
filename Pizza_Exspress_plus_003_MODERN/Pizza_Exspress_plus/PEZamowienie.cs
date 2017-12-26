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
    public partial class PEZamowienie : UserControl
    {
        public PEZamowienie()
        {
            InitializeComponent();
        }
          // menu wyboru stanu

        private void lokalOtwoz(object sender, EventArgs e)
        {
            DaneOb.dodajInfoMajak();
            FMenu r = new FMenu();
            r.Show();
        }

        private void odebracOtwoz(object sender, EventArgs e)
        {
            FOdbior odbiur = new FOdbior();            
            odbiur.Show();
        }

        private void dostawaOtwoz(object sender, EventArgs e)
        {
            FDostawa r = new FDostawa();
            r.Show();
        }
    }
}
