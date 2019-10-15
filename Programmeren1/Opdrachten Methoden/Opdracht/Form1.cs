using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            int getal = int.Parse(txtGetal.Text);

            KwadraatByReference(ref getal);

            lblUitkomst.Text = getal.ToString();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            int getal = int.Parse(txtGetal.Text);
            int kwadraat;

            KwadraatByReferenceOut(getal, out kwadraat);

            lblUitkomst.Text = kwadraat.ToString();
        }

        private void btnVal_Click(object sender, EventArgs e)
        {
            int getal = int.Parse(txtGetal.Text);
            int kwadraat = KwadraatByValue(getal);

            lblUitkomst.Text = kwadraat.ToString();
        }

        void KwadraatByReference(ref int getal)
        {
            getal = getal * getal;
        }

        void KwadraatByReferenceOut(int getal, out int kwadraat)
        {
            kwadraat = getal * getal;
        }

        int KwadraatByValue(int getal)
        {
            return getal * getal;
        }
    }
}
