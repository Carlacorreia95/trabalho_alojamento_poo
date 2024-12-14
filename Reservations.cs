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
        private int reservation_id { get; set; }
        public DateTime begining_date { get; set; }
        public DateTime ending_date { get; set; }
        public int accommodation_id { get; set; }
        public int employee_id { get; set; }
        public long fiscal_number { get; set; }
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
