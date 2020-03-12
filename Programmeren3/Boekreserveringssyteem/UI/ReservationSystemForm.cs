using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class ReservationSystemForm : Form
    {
        public ReservationSystemForm()
        {
            InitializeComponent();
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomersForm form = new CustomersForm();
            form.Show();
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BooksForm form = new BooksForm();
            form.Show();
        }

        private void reservationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReservationsForm form = new ReservationsForm();
            form.Show();
        }
    }
}
