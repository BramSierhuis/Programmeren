﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace Logica
{
    public class ReservationService
    {
        private ReservationDAO reservationDAO = new ReservationDAO();

        public List<Reservation> GetAllForCustomer(Customer customer)
        {
            return reservationDAO.GetAllForCustomer(customer);
        }
    }
}
