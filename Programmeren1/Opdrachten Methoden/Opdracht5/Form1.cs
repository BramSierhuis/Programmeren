using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void btnPlus_Click(object sender, EventArgs e)
        {
            int getal1 = int.Parse(txtGetal1.Text);
            int getal2 = int.Parse(txtGetal2.Text);
            double uitkomst = Add(getal1, getal2);

            lblUitkomst.Text = uitkomst.ToString();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            int getal1 = int.Parse(txtGetal1.Text);
            int getal2 = int.Parse(txtGetal2.Text);
            double uitkomst = Substract(getal1, getal2);

            lblUitkomst.Text = uitkomst.ToString();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            int getal1 = int.Parse(txtGetal1.Text);
            int getal2 = int.Parse(txtGetal2.Text);
            double uitkomst = Multiply(getal1, getal2);

            lblUitkomst.Text = uitkomst.ToString();
        }

        private void btnDelen_Click(object sender, EventArgs e)
        {
            int getal1 = int.Parse(txtGetal1.Text);
            int getal2 = int.Parse(txtGetal2.Text);
            double uitkomst = Devide(getal1, getal2);

            lblUitkomst.Text = uitkomst.ToString();
        }

        double Add(int x, int y)
        {
            double output = x + y;
            return output;
        }

        double Substract(int x, int y)
        {
            double output = x - y;
            return output;
        }

        double Multiply(int x, int y)
        {
            double output = x * y;
            return output;
        }

        double Devide(int x, int y)
        {
            double output = (double) x / (double) y;
            return output;
        }
    }
}
