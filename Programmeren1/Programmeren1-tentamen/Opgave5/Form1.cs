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

        private void btnBereken_Click(object sender, EventArgs e)
        {
            const double EERSTE_KLASSE_PRIJS = 87.46;
            const double TWEEDE_KLASSE_PRIJS = 53;
            const double RAILRUNNER_PRIJS = 2.5;

            int aantal = int.Parse(txtAantal.Text);
            int railrunner = int.Parse(txtRailrunner.Text);

            double prijs;
            if (rBtnTweede.Checked)
                prijs = TWEEDE_KLASSE_PRIJS * aantal + RAILRUNNER_PRIJS * railrunner;
            else
                prijs = EERSTE_KLASSE_PRIJS * aantal + RAILRUNNER_PRIJS * railrunner;

            txtPrijs.Text = "€" + prijs.ToString("0.00");
        }
    }
}
