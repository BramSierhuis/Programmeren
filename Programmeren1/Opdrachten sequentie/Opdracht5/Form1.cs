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

namespace Opdracht5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBereken_Click(object sender, EventArgs e)
        {
            //Lees de getallen uit de tekstvakken uit
            double getal1 = double.Parse(txtGetal1.Text, CultureInfo.InvariantCulture);
            double getal2 = double.Parse(txtGetal2.Text, CultureInfo.InvariantCulture);
            double getal3 = double.Parse(txtGetal3.Text, CultureInfo.InvariantCulture);

            //Bereken het gemiddelde
            double gemiddelde = (getal1 + getal2 + getal3) / 3;

            //Geef de berekende waarde weer
            lblGemiddelde.Text = gemiddelde.ToString();
        }
    }
}
