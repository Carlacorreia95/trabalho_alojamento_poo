using System.Collections.Generic;
using Helper;

namespace Trabalho_Alojamento_POO
{
    public partial class Form1 : Form
    {
        public Helper_class day_counter;
        public Administrative myCompany;
        public List<int> accomodationID_listbox = new List<int>();
        public Form1()
        {
            Initialize_component();
            this.myCompany = new Administrative();
            this.myCompany.Load_data("Clients.json", 1);
            this.myCompany.Load_data("Employees.json", 2);
            this.myCompany.Load_data("Villas.json", 3);
            this.myCompany.Load_data("Rooms.json", 4);
            this.myCompany.Load_data("Reservations.json", 5);

        }
        #region clients
        private void Add_button_Click(object sender, EventArgs e)
        {

            try
            {
                Client client = new Client(Convert.ToInt32(this.tb_age_add_client.Text), this.tb_name_add_client.Text, this.tb_sex_add_client.Text, Convert.ToInt64(this.tb_fiscal_number_add_client.Text));
                this.myCompany.Add_client(client);
            }
            catch (Exception ex)
            {
                Logger.Log_error("Information was invaled", ex);
                MessageBox.Show("Please insert valid information");
            }
        }

        private void Remove_button_Click(object sender, EventArgs e)
        {
            try
            {
                this.myCompany.Remove_client(Convert.ToInt64(this.tb_fiscal_number_remove_client.Text));
            }
            catch (Exception ex)
            {
                Logger.Log_error("Fiscal number was invaled", ex);
                MessageBox.Show("Please insert valid fiscal number");
            }
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            try
            {

                this.myCompany.Search_client(Convert.ToInt64(this.tb_fiscal_number_search_client.Text));
            }
            catch (Exception ex)
            {
                Logger.Log_error("Fiscal number was invaled", ex);
                MessageBox.Show("Please insert a valid fiscal number");
            }
        }
        #endregion

        #region Employees
        private void Add_employee_button_Click(object sender, EventArgs e)
        {
            try
            {
                int employee_id = this.myCompany.employee_list.Any() ? this.myCompany.employee_list.Last().Employee_id + 1 : 1;
                Employee employee = new Employee(Convert.ToInt32(this.tb_age_add_employee.Text), this.tb_name_add_employee.Text, this.tb_sex_add_employee.Text, employee_id, this.tb_position_add_employee.Text, this.tb_section_add_employee.Text);
                this.myCompany.Add_employee(employee);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please insert valid information");
            }

        }

        private void Search_employee_button_Click(object sender, EventArgs e)
        {

            try
            {
                this.myCompany.Search_employee(Convert.ToInt32(this.tb_employee_id_search_employee));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please insert a valid ID");
            }

        }

        private void Remove_employee_button_Click(object sender, EventArgs e)
        {

            try
            {
                this.myCompany.Remove_employee(Convert.ToInt32(this.tb_employee_id_remove_employee));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please insert a valid ID");
            }
        }

        #endregion

        #region Accomodation 
        
        #region room
        private void Add_room_button_Click(object sender, EventArgs e)
        {
            try
            {
                Room room = new Room(this.myCompany.Get_next_id(), Convert.ToInt32(this.tb_capacity_add_room.Text), float.Parse(this.tb_area_add_room.Text), Convert.ToInt32(this.tb_floor_add_room.Text));
                this.myCompany.Add_rooms(room);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please insert valid information");
            }
        }
        private void Search_room_button_Click(object sender, EventArgs e)
        {
            try
            {
                this.myCompany.Search_room(Convert.ToInt32(this.tb_id_search_room.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please insert a valid ID");
            }

        }

        private void Remove_room_button_Click(object sender, EventArgs e)
        {
            try
            {
                this.myCompany.Remove_rooms(Convert.ToInt32(this.tb_remove_add_room.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please insert a valid ID");
            }
        }
        #endregion

        #region villa
        private void Add_villa_button_Click(object sender, EventArgs e)
        {
            try
            {
                Villa villa = new Villa(this.myCompany.Get_next_id(), Convert.ToInt32(this.tb_capacity_add_villa.Text), float.Parse(this.tb_area_add_villa.Text), this.cb_kitchen.Checked, this.cb_sofa_bed.Checked, this.cb_living_room.Checked);
                this.myCompany.Add_villa(villa);
            }
            catch (Exception ex)
            {
                Logger.Log_error("Information was invaled", ex);
                MessageBox.Show("Please insert valid information");
            }
        }

        private void Search_villa_button_Click(object sender, EventArgs e)
        {
            try
            {
                this.myCompany.Search_villa(Convert.ToInt32(this.tb_id_search_villa.Text));
            }
            catch (Exception ex)
            {
                Logger.Log_error("ID was invaled", ex);
                MessageBox.Show("Please insert a valid ID");
            }
        }

        private void Remove_villa_button_Click(object sender, EventArgs e)
        {
            try
            {
                this.myCompany.Remove_villa(Convert.ToInt32(this.tb_id_remove_villa.Text));
            }
            catch (Exception ex)
            {
                Logger.Log_error("ID was invaled", ex);
                MessageBox.Show("Please insert a valid ID");
            }
        }
        #endregion
        #endregion

        #region Reservation
        public bool Is_date_available(DateTime StartDate1, DateTime EndDate1, DateTime StartDate2, DateTime EndDate2)
        {

            return EndDate1 < StartDate2 || EndDate2 < StartDate1;
        }

        private bool Is_accommodation_available(int accommodationId, DateTime startDate, DateTime endDate)
        {
            // Loop through the reservation list and check for conflicts
            foreach (var reservation in this.myCompany.reservation_list)
            {
                if (reservation.accommodation_id == accommodationId)
                {
                    // Check if the dates overlap
                    if (!(endDate < reservation.begining_date || startDate > reservation.ending_date))
                    {
                        return false; // Overlap found, not available
                    }
                }
            }
            return true; // No conflicts, available
        }

        private void Show_available_accomodations()
        {
            DateTime selectedStartDate = monthCalendar1.SelectionStart;
            DateTime selectedEndDate = monthCalendar1.SelectionEnd;

            // Clear the ListBox first
            this.lbx_Reservations.Items.Clear();
            this.accomodationID_listbox.Clear();

            // Add Rooms to the ListBox
            foreach (var room in this.myCompany.room_list)
            {
                if (Is_accommodation_available(room.Id, selectedStartDate, selectedEndDate))
                {
                    this.lbx_Reservations.Items.Add($"Room ID: {room.Id}, Capacity: {room.capacity}, Area: {room.area}m², Floor: {room.floor}");
                    this.accomodationID_listbox.Add(room.Id);
                }
            }

            // Add Villas to the ListBox
            foreach (var villa in this.myCompany.villa_list)
            {
                if (Is_accommodation_available(villa.Id, selectedStartDate, selectedEndDate))
                {
                    this.lbx_Reservations.Items.Add($"Villa ID: {villa.Id}, Capacity: {villa.capacity}, Area: {villa.area}m², Kitchen: {villa.kitchen}, Sofa Bed: {villa.sofa_bed}, Living Room: {villa.living_room}");
                    this.accomodationID_listbox.Add(villa.Id);
                }
            }
        }

        private void add_reservation_button_Click(object sender, EventArgs e)
        {
            try
            {
                int accomodationId = this.accomodationID_listbox[this.lbx_Reservations.SelectedIndex];
                if (this.myCompany.client_list.Find(client => client.Fiscal_number() == Convert.ToInt64(this.tb_fiscal_number_reservation.Text)) == null) MessageBox.Show("No client with that fiscal number");
                else if (this.myCompany.employee_list.Find(employee => employee.Employee_id == Convert.ToInt32(this.tb_employee_id_reservation.Text)) == null) MessageBox.Show("No employee with that id");
                else if (this.myCompany.room_list.Find(room => room.Id == accomodationId) == null
                    && this.myCompany.villa_list.Find(villa => villa.Id == accomodationId) == null) MessageBox.Show("No accomodation with that id");
                else
                {

                    day_counter = new Helper_class();
                    int number_of_days = day_counter.Calculate_days(monthCalendar1.SelectionStart, monthCalendar1.SelectionEnd);
                    if (number_of_days > 0) {
                        MessageBox.Show("Congratulations, you have just reserved " + number_of_days.ToString() + " days");
                        Reservations reservation = new Reservations(monthCalendar1.SelectionStart, monthCalendar1.SelectionEnd, accomodationId, this.myCompany.reservation_list.Count + 1, Convert.ToInt32(this.tb_employee_id_reservation.Text), Convert.ToInt64(this.tb_fiscal_number_reservation.Text));
                        this.myCompany.Add_reservation(reservation);
                    } 
                    else MessageBox.Show("Please Select a valid amount of days");


                }
            }
            catch (Exception ex)
            {
                Logger.Log_error("Information was invaled", ex);
                MessageBox.Show("Please insert valid information");
            }
        }

        private void bt_search_dates_Click(object sender, EventArgs e)
        {
            Show_available_accomodations();
        }
        #endregion

    }
}