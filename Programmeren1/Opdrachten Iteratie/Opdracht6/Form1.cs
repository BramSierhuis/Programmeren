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

        private void button1_Click(object sender, EventArgs e)
        {
            double bedrag = double.Parse(txtStartBedrag.Text);

            for(int i = 0; i < 5; i++)
            {
                bedrag *= 1.05;
            }

            lblEindkapitaal.Text = "€" + bedrag.ToString("0.00");
        }
    }
}
