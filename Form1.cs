namespace Trabalho_Alojamento_POO
{
    public partial class Form1 : Form
    {
        public Administrative myCompany;
        public Form1()
        {
            InitializeComponent();
            this.myCompany = new Administrative();
            this.myCompany.Load_data();
        }
        #region clients
        private void Add_button_Click(object sender, EventArgs e)
        {
            Client client = new Client(Convert.ToInt32(this.tb_age_add_client.Text), this.tb_name_add_client.Text, this.tb_sex_add_client.Text, Convert.ToInt64(this.tb_fiscal_number_add_client.Text));
            this.myCompany.Add_client(client);
        }

        private void Remove_button_Click(object sender, EventArgs e)
        {
            this.myCompany.Remove_client(Convert.ToInt64(this.tb_fiscal_number_remove_client.Text));
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            this.myCompany.Search_client(Convert.ToInt64(this.tb_fiscal_number_search_client.Text));
        }
        #endregion
        #region employees
        private void Add_employee_button_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee(Convert.ToInt32(this.tb_age_add_employee.Text, this.tb_name_add_employee.Text, this.tb_sex_add_employee.Text, this.tb_employee_id_add_employee, this.tb_position_add_employee, this.tb_section_add_employee));
            this.myCompany.Add_employee(employee);
        }
        #endregion

    }
}
