using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Trabalho_Alojamento_POO
{
    public class Administrative
    {

        //criar lista de clientes
        public string filePath = "Clients.json";
        
        private List<Client> client_list = new List<Client>();
        private List<Accommodation> accommodation_list = new List<Accommodation>();
        private List<Employee> employee_list = new List<Employee>();

        #region clients file management
        private bool Update_json() 
        {
            try
            {
                // Write the updated data back to the file
                string updatedJson = JsonSerializer.Serialize(client_list, new JsonSerializerOptions
                {
                    WriteIndented = true
                });
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.Write(updatedJson);
                }

                return true;
            }
            catch (Exception ex) { 
                Console.WriteLine(ex.ToString());
                return false;
            }
            
        }
        public bool Load_data()
        {
            if (File.Exists(filePath) && new FileInfo(filePath).Length > 0)
            {
                string existingJson = File.ReadAllText(filePath);
                client_list = JsonSerializer.Deserialize<List<Client>>(existingJson) ?? new List<Client>();
            }
            else
            {
                client_list = new List<Client>(); // Start with an empty list if the file doesn't exist
            }
            return true;
        }
        public void Add_client(Client client)
        {
            this.client_list.Add(client);
            // Write the updated data back to the file
            Update_json();
        }
        public void Remove_client(long fiscal_number) 
        { 
            // this.client_list.RemoveAll(client=>client.Fiscal_number()== fiscal_number);
            Update_json();
        }
        public void Search_client(long fiscal_number) 
        {
            //this.client_list.Find(client=>client.Fiscal_number()==fiscal_number);
        }
        #endregion

        #region accommodation file managment
        public void Add_accommodation(Accommodation accommodation)
        {
            this.accommodation_list.Add(accommodation);
            // Write the updated data back to the file
            Update_json();
        }
        public void Remove_accommodation(int id) 
        { 
            this.accommodation_list.RemoveAll(accommodation => accommodation.Id()== id);
            Update_json();
        }
        public void Search_accommodation(int id)
        {
            this.accommodation_list.Find(accommodation => accommodation.Id() == id);
        }
        #endregion

        #region Employee file managment
        public void Add_employee(Employee employee)
        {
            this.employee_list.Add(employee);
            // Write the updated data back to the file
            Update_json();
        }
        public void Remove_employee(int employee_id)
        {
            this.employee_list.RemoveAll(employee => employee.Employee_id() == employee_id);
            Update_json();
        }
        public void Search_employee(int employee_id)
        {
            this.employee_list.Find(employee => employee.Employee_id() == employee_id);
        }
        #endregion

    }
}
    
