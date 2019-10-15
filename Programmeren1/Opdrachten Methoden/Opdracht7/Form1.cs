using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void button1_Click(object sender, EventArgs e)
        {
            double graden = double.Parse(txtInput.Text);

            if (rBtnCtoK.Checked)
                CelciusToKelvin(ref graden);
            else if (rBtnCtoF.Checked)
                CelciusToFahrenheid(ref graden);
            else if (rBtnFtoC.Checked)
                FahrenheidToCelcius(ref graden);

            lblUitkomst.Text = graden.ToString("0.00");
        }

        void CelciusToKelvin(ref double graden)
        {
            graden = graden + 273;
        }

        void CelciusToFahrenheid(ref double graden)
        {
            graden = (graden * 1.8 + 32);
        }

        void FahrenheidToCelcius(ref double graden)
        {
            graden = (graden - 32) / 1.8;
        }
    }
}
