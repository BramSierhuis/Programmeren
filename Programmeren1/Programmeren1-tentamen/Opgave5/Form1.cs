using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opgave5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Methode wordt uitgevoerd wanneer er op de bereken knop wordt gedrukt
        private void btnBereken_Click(object sender, EventArgs e) 
        {
            const double EERSTE_KLASSE_PRIJS = 87.46; //De prijzen van de kaartjes
            const double TWEEDE_KLASSE_PRIJS = 53;
            const double RAILRUNNER_PRIJS = 2.5;

            int aantal = int.Parse(txtAantal.Text); //Lees het aantal kaartjes uit
            int railrunner = int.Parse(txtRailrunner.Text);

            //Afhankelijk van of de 1e of 2e klasse is geselecteerd wordt de totaal prijs berekend aan de hand 
            //van de prijs van de 1e of 2e klas kaartjes
            double prijs;
            if (rBtnTweede.Checked) 
                prijs = TWEEDE_KLASSE_PRIJS * aantal + RAILRUNNER_PRIJS * railrunner;
            else
                prijs = EERSTE_KLASSE_PRIJS * aantal + RAILRUNNER_PRIJS * railrunner;

            txtPrijs.Text = "€" + prijs.ToString("0.00"); //Laat het totaal zien aan de gebruiker
        }
    }
}
