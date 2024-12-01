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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Client client = new Client(Convert.ToInt32(this.tb_age.Text), this.tb_name.Text, this.sex.Text, Convert.ToInt64(this.fiscal_number.Text));
            this.myCompany.Add_client(client);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
