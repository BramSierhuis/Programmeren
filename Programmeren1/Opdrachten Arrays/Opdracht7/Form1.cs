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

        private void btnGooien_Click(object sender, EventArgs e)
        {
            int[] dobbelsteen = { 0, 0, 0, 0, 0, 0 };
            Random rnd = new Random();

            for(int i = 0; i <= 6000; i++)
            {
                int worp = rnd.Next(1, 7);

                dobbelsteen[worp - 1]++;
            }

            lbl1.Text = "Waarde 1 is " + dobbelsteen[0].ToString() + " keer gegooid.";
            lbl2.Text = "Waarde 2 is " + dobbelsteen[1].ToString() + " keer gegooid.";
            lbl3.Text = "Waarde 3 is " + dobbelsteen[2].ToString() + " keer gegooid.";
            lbl4.Text = "Waarde 4 is " + dobbelsteen[3].ToString() + " keer gegooid.";
            lbl5.Text = "Waarde 5 is " + dobbelsteen[4].ToString() + " keer gegooid.";
            lbl6.Text = "Waarde 6 is " + dobbelsteen[5].ToString() + " keer gegooid.";
        }
    }
}
