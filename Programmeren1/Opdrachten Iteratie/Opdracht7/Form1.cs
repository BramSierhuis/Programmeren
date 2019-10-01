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
    public partial class Opdracht7 : Form
    {
        public Opdracht7()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            int zijde = int.Parse(txtSize.Text);
            StringBuilder figure = new StringBuilder();

            for (int i = 0; i < zijde; i++)
            {
                if (i == 0 || i == zijde - 1)
                {
                    for (int j = 0; j < zijde; j++)
                    {
                        figure.Append("X");
                    }

                    figure.Append("\n");
                }
                else
                {
                    for (int j = 0; j < zijde; j++)
                    {
                        if (j == 0)
                            figure.Append("X");
                        else if (j == zijde - 1)
                            figure.Append("X\n");
                        else
                            figure.Append(" ");
                    }
                }
            }

            lblSquare.Text = figure.ToString();
        }
    }
}
