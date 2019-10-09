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
        Random rnd = new Random();

        int[] vooraf = new int[20];
        int[] achteraf = new int[20];

        public Form1()
        {
            InitializeComponent();

            for(int i = 0; i < vooraf.Length; i++)
            {
                vooraf[i] = rnd.Next(500);
            }

            achteraf = vooraf;

            StringBuilder text = new StringBuilder();
            for(int i = 0; i < vooraf.Length; i++)
            {
                text.Append(("Element " + i.ToString("00") + " = " + vooraf[i] + " \n"));
            }

            lblVooraf.Text = text.ToString();
        }

        private void btnVergelijk_Click(object sender, EventArgs e)
        {
            int vergelijkGetal = int.Parse(txtGetal.Text);

            for(int i = 0; i < vooraf.Length; i++)
            {
                if (vooraf[i] >= vergelijkGetal)
                    vooraf[i] += 10;
                else
                    vooraf[i] -= 5;
            }

            StringBuilder text = new StringBuilder();
            for (int i = 0; i < achteraf.Length; i++)
            {
                text.Append(("Element " + i.ToString("00") + " = " + achteraf[i] + " \n"));
            }

            lblAchteraf.Text = text.ToString();
            btnVergelijk.Enabled = false;
        }
    }
}
