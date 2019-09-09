using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBereken_Click(object sender, EventArgs e)
        {
            //Lees het aantal seconden uit uit het tekstvak
            int seconden = int.Parse(txtSeconden.Text);

            //Zelfde logica als in opdracht1
            int uren = seconden / 3600;
            seconden -= uren * 3600;

            int minuten = seconden / 60;
            seconden -= minuten * 60;

            //Geef de berekende waardes weer. Er staan altijd 2 getallen om de waarden weer te geven
            lblDisplay.Text = uren.ToString("00") + ":" + minuten.ToString("00") + ":" + seconden.ToString("00");
        }
    }
}
