using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBereken_Click(object sender, EventArgs e)
        {
            const int prijsShirt = 30;
            const int prijsBroek = 100;

            int aantalShirts = int.Parse(txtAantalShirts.Text);
            int aantalBroeken = int.Parse(txtAantalBroeken.Text);

            double prijs = aantalBroeken * prijsBroek + aantalShirts * prijsShirt;
            double btw = prijs * 0.21;
            double totaalPrijs = prijs + btw;

            string datum = DateTime.Now.ToString();

            lblDatum.Text = datum;
            lblPrijs.Text = "€" + prijs.ToString(".00");
            lblBtw.Text = "€" + btw.ToString(".00");
            lblTotaalPrijs.Text = "€" + totaalPrijs.ToString(".00");
        }
    }
}
