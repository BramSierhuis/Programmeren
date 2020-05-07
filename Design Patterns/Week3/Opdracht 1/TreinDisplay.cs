using Opracht_1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht_1
{
    public partial class TreinDisplay : Form, ITreinDisplay
    {
        public TreinDisplay(ITreinReis treinReis)
        {
            InitializeComponent();

            treinReis.AddObserver(this);
        }

        public void Update(string huidigStation, string volgendStation, string spoor, DateTime aankomstTijd)
        {
            lblHuidigStation.Text = huidigStation;
            lblVolgendStation.Text = volgendStation;
            lblAankomstSpoor.Text = spoor;
            lblAankomsttijd.Text = aankomstTijd.ToString();
        }
    }
}
