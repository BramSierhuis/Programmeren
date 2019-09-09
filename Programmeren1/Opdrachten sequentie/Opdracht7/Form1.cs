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

namespace Opdracht7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWissen_Click(object sender, EventArgs e)
        {
            //Set de tekst van alle in en uitvoer velden naar een lege string, hierdoor zijn de velden leeg
            txtBeginKM.Text = "";
            txtEindKM.Text = "";
            txtPrijsPerKM.Text = "";

            lblExBtw.Text = "";
            lblBtw.Text = "";
            lblIncBtw.Text = "";
        }

        private void btnBedragen_Click(object sender, EventArgs e)
        {
            //Lees de ingevoerden waardes uit de tekstvakken uit
            double beginKM = double.Parse(txtBeginKM.Text, CultureInfo.InvariantCulture);
            double eindKM = double.Parse(txtEindKM.Text, CultureInfo.InvariantCulture);
            double prijsPerKM = double.Parse(txtPrijsPerKM.Text, CultureInfo.InvariantCulture);

            //Bereken het aantal gereden kilometers en vermenigvuldig dit met de prijs per kilometer
            double prijsExBtw = (eindKM - beginKM) * prijsPerKM;
            double btw = prijsExBtw * 0.21; //Bereken de btw
            double prijsIncBtw = prijsExBtw + btw; //Bereken het totaalbedrag

            //Geef de berekende waardes weer met 2 decimalen achter de komma
            lblExBtw.Text = prijsExBtw.ToString(".00");
            lblBtw.Text = btw.ToString(".00");
            lblIncBtw.Text = prijsIncBtw.ToString(".00");
        }
    }
}
