using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void btnCompare_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text);

            int som = 0;
            for(int i = 0; i <= n; i++)
            {
                som += i;
            }

            int formule = n * (n + 1) / 2;

            lblSom.Text = som.ToString();
            lblFormule.Text = formule.ToString();

            if (som == formule)
                lblOutput.Text = "De som en formule zijn gelijk";
            else
                lblOutput.Text = "De som en formule zijn niet gelijk";
        }
    }
}
