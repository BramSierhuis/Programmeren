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
    public partial class ControlPanel : Form
    {
        private ITreinController controller;

        public ControlPanel(ITreinReis treinReis, ITreinController controller)
        {
            InitializeComponent();

            this.controller = controller;
        }

        private void btnVolgendStation_Click(object sender, EventArgs e)
        {
            controller.VolgendStation();
        }

        private void btnNieuwDisplay_Click(object sender, EventArgs e)
        {
            controller.NieuwDisplay();
        }
    }
}
