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

namespace Opdracht4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBereken_Click(object sender, EventArgs e)
        {
            //Lees de prijs uit uit het tekstvak
            double prijs = double.Parse(txtPrijs.Text, CultureInfo.InvariantCulture);
            double btw = prijs * 0.21; //Bereken de btw
            double totaal = btw + prijs; //Bereken de totaalprijs

            //Geef de berekende waardes weer met 2 decimalen achter de komma
            lblPrijs.Text = prijs.ToString(".00");
            lblBtw.Text = btw.ToString(".00");
            lblTotaal.Text = totaal.ToString(".00");
        }
    }
}
