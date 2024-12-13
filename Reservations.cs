using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Alojamento_POO
{
    public class Reservations
    {
        private DateTime begining_date;
        private DateTime ending_date;
        private int accommodation_id;
        private int reservation_id;
        private int employee_id;
        private long fiscal_number;
        // private enum operator;
        // private enum operator;
        public int Reservation_id { get => reservation_id; }

        public Reservations(DateTime begining_date, DateTime ending_date, int accommodation_id, int reservation_id, int employee_id, long fiscal_number)
        {
            this.begining_date = begining_date;
            this.ending_date = ending_date;
            this.accommodation_id = accommodation_id;
            this.reservation_id = reservation_id;
            this.employee_id = employee_id;
            this.fiscal_number = fiscal_number;
        }

    }
}
