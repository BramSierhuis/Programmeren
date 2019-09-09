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
            //De prijsen van de kleding stukken
            const int PRIJS_SHIRT = 30;
            const int PRIJS_BROEK = 100;

            //Lees het ingevoerde aantal shirts en broeken uit
            int aantalShirts = int.Parse(txtAantalShirts.Text);
            int aantalBroeken = int.Parse(txtAantalBroeken.Text);

            //Bereken de totole prijs van de kledingstukken
            double prijs = aantalBroeken * PRIJS_BROEK + aantalShirts * PRIJS_SHIRT;
            double btw = prijs * 0.21; //Bereken de btw
            double totaalPrijs = prijs + btw; //Bereken de prijs inclusief btw

            string datum = DateTime.Now.ToString(); //Krijg de datum en de tijd van nu

            //Geef de labels de juiste waardes met 2 cijfers achter de komma
            lblDatum.Text = datum;
            lblPrijs.Text = "€" + prijs.ToString(".00");
            lblBtw.Text = "€" + btw.ToString(".00");
            lblTotaalPrijs.Text = "€" + totaalPrijs.ToString(".00");
        }
    }
}
