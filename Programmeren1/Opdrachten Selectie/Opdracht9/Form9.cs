using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht9
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int age = int.Parse(txtAge.Text);
            int duration = int.Parse(txtDuration.Text);
            int fee = 0;

            if (rBtnFootball.Checked)
                fee = 175;
            else if (rBtnHandball.Checked)
                fee = 225;

            if (age > 40)
                fee -= 25;

            if (duration > 10)
                fee -= 20;

            lblFee.Text = "€" + fee.ToString(".00");
        }
    }
}
