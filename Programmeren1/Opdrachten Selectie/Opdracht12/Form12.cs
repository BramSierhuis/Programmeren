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

namespace Opdracht12
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            const int BASEPRICE = 12;
            string seperator = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;

            int age = int.Parse(txtAge.Text);

            switch (age)
            {
                case int n when (n >= 0 && n < 5):
                    lblPrice.Text = "€0" + seperator + "00";
                    break;
                case int n when (n >= 5 && n <= 12):
                    lblPrice.Text = "€" + (BASEPRICE / 2).ToString(".00");
                    break;
                case int n when (n >= 13 && n <= 54):
                    lblPrice.Text = "€" + BASEPRICE.ToString(".00");
                    break;
                case int n when (n >= 54):
                    lblPrice.Text = "€0" + seperator + "00";
                    break;
            }
        }
    }
}
