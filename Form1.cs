namespace Trabalho_Alojamento_POO
{
    public partial class Form1 : Form
    {
        public Administrative myCompany;
        public Form1()
        {
            InitializeComponent();
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
                MessageBox.Show("Please insert a valid fiscal number");
            }
        }
        #endregion

        #region employees
        private void Add_employee_button_Click(object sender, EventArgs e)
        {
            try
            {
                Employee employee = new Employee(Convert.ToInt32(this.tb_age_add_employee.Text), this.tb_name_add_employee.Text, this.tb_sex_add_employee.Text, Convert.ToInt32(this.tb_employee_id_add_employee.Text), this.tb_position_add_employee.Text, this.tb_section_add_employee.Text);
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

        #region room
        private void Add_room_button_Click(object sender, EventArgs e)
        {
            try
            {
                Room room = new Room(Convert.ToInt32(this.tb_id_add_room.Text), Convert.ToInt32(this.tb_capacity_add_room.Text), float.Parse(this.tb_area_add_room.Text), Convert.ToInt32(this.tb_floor_add_room.Text));
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
                this.myCompany.Search_rooms(Convert.ToInt32(this.tb_id_search_room.Text));
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



        private void Add_villa_button_Click(object sender, EventArgs e)
        {
            try
            {
                Villa villa = new Villa(Convert.ToInt32(this.tb_id_add_villa.Text), Convert.ToInt32(this.tb_capacity_add_villa.Text), float.Parse(this.tb_area_add_villa.Text), this.cb_kitchen.Checked, this.cb_sofa_bed.Checked, this.cb_living_room.Checked);
                this.myCompany.Add_villa(villa);
            }
            catch (Exception ex)
            {
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
                MessageBox.Show("Please insert a valid ID");
            }
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}