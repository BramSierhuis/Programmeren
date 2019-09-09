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
            double prijs = double.Parse(txtPrijs.Text, CultureInfo.InvariantCulture);
            double btw = Math.Round(prijs * 0.21, 2);
            double totaal = Math.Round(btw + prijs, 2);

            lblPrijs.Text = prijs.ToString(".00");
            lblBtw.Text = btw.ToString(".00");
            lblTotaal.Text = totaal.ToString(".00");
        }
    }
}
