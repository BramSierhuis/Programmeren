using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using Model;


namespace UI
{
    public partial class CustomersForm : Form
    {
        private CustomerService customerService = new CustomerService();
        private ReservationService reservationService = new ReservationService();

        public CustomersForm()
        {
            InitializeComponent();
            DisplayCustomers();
        }

        private void DisplayCustomers()
        {
            List<Customer> customers = customerService.GetAll();
            cmbCustomers.Items.AddRange(customers.ToArray());

            cmbCustomers.SelectedIndex = 0;
        }

        private void cmbCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstReservations.Items.Clear();

            List<Reservation> reservations = reservationService.GetAllForCustomer((Customer)cmbCustomers.SelectedItem);
            lstReservations.Items.AddRange(reservations.ToArray());
        }
    }
}
