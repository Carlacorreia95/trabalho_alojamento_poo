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

        #region general functions        

        public string filePath = "Clients.json";
        private string updatedJson;

        /// <summary>
        /// Function to update the json file when the lists are changed
        /// </summary>
        /// <param name="filepath">Path to the file</param>
        /// <param name="jsonToUpdate">1-Client 2-Employee 3-Villa 4-Room 5-Reservation</param>
        /// <returns></returns>
        private bool Update_json(string filepath, int jsonToUpdate) { // 1-Client 2-Employee 3-Villa 4-Room 5-Reservation
            try {
                string updatedJson;
            
                switch (jsonToUpdate) {
                    default:
                        updatedJson = "";
                        break;
                    case 1://Client
                    
                        updatedJson = JsonSerializer.Serialize(client_list, new JsonSerializerOptions
                        {
                            WriteIndented = true
                        });
                        break;
                    case 2://Employee
                        updatedJson = JsonSerializer.Serialize(employee_list, new JsonSerializerOptions
                        {
                            WriteIndented = true
                        });
                        break;
                    case 3://Villa
                        updatedJson = JsonSerializer.Serialize(villa_list, new JsonSerializerOptions
                        {
                            WriteIndented = true
                        });
                        break;
                    case 4://Room
                        updatedJson = JsonSerializer.Serialize(room_list, new JsonSerializerOptions
                        {
                            WriteIndented = true
                        });
                        break;
                    case 5://Reservation
                        updatedJson = JsonSerializer.Serialize(reservation_list, new JsonSerializerOptions
                        {
                            WriteIndented = true
                        });
                        break;

                }
                using (StreamWriter writer = new StreamWriter(filepath))
                {
                    writer.Write(updatedJson);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }

            return true;
        }

        /// <summary>
        /// Function to load the data of the several information files 
        /// </summary>
        /// <param name="filepath">Path to the file</param>
        /// <param name="listToUpdate">1-Client 2-Employee 3-Villa 4-Room 5-Reservation</param>
        /// <returns></returns>
        public bool Load_data(string filepath, int listToUpdate){ // 1-Client 2-Employee 3-Villa 4-Room 5-Reservation
            string existingJson = "";

            if (File.Exists(filepath) && new FileInfo(filepath).Length > 0)
            {
                existingJson = File.ReadAllText(filepath);
            }
            else
            {
                existingJson = "";
            }

            switch (listToUpdate)
            {
                default:
                    existingJson = "";
                    break;

                case 1://Client

                    if (existingJson != "") client_list = JsonSerializer.Deserialize<List<Client>>(existingJson) ?? new List<Client>();
                    else client_list = new List<Client>(); // Start with an empty list if the file doesn't exist

                    break;
                case 2://Employee
                    if (existingJson != "") employee_list = JsonSerializer.Deserialize<List<Employee>>(existingJson) ?? new List<Employee>();
                    else employee_list = new List<Employee>(); // Start with an empty list if the file doesn't exist

                    break;
                case 3://Villa
                    if (existingJson != "") villa_list = JsonSerializer.Deserialize<List<Villa>>(existingJson) ?? new List<Villa>();
                    else villa_list = new List<Villa>(); // Start with an empty list if the file doesn't exist

                    break;
                case 4://Room
                    if (existingJson != "") room_list = JsonSerializer.Deserialize<List<Room>>(existingJson) ?? new List<Room>();
                    else room_list = new List<Room>(); // Start with an empty list if the file doesn't exist

                    break;
                case 5://Reservation
                    if (existingJson != "") reservation_list = JsonSerializer.Deserialize<List<Reservations>>(existingJson) ?? new List<Reservations>();
                    else reservation_list = new List<Reservations>(); // Start with an empty list if the file doesn't exist

                    break;

            }

            return true;
        }

        #endregion

        #region Clients file management  
        private List<Client> client_list = new List<Client>();
        public void Add_client(Client client)
        {
            this.client_list.Add(client);
            // Write the updated data back to the file
            Update_json("Clients.json", 1);
        }
        public void Remove_client(long fiscal_number) 
        { 
            this.client_list.RemoveAll(client=>client.Fiscal_number()== fiscal_number);
            Update_json("Clients.json", 1);
        }
        public void Search_client(long fiscal_number) 
        {
           var client = this.client_list.Find(client=>client.Fiscal_number()==fiscal_number);

            if (client != null)
            {
                MessageBox.Show("Name:" + client.name + "\nAge:" + client.age);
            }
            else {
                MessageBox.Show("No Client with that fiscal number");
            }
        }
        #endregion

        #region Employee file management
        private List<Employee> employee_list = new List<Employee>();
        public void Add_employee(Employee employee)
        {
            this.employee_list.Add(employee);
            // Write the updated data back to the file
            Update_json("Employees.json", 2);
        }
        public void Remove_employee(int employee_id)
        {
            this.employee_list.RemoveAll(employee => employee.Employee_id == employee_id);
            Update_json("Employees.json", 2);
        }
        public void Search_employee(int employee_id)
        {
            var employee = this.employee_list.Find(employee => employee.Employee_id == employee_id);
            if (employee != null)
            {
                MessageBox.Show("Name:" + employee.name + "\nAge:" + employee.age);
            }
            else {
                MessageBox.Show("No Employee with that ID");
            }
        }
        #endregion

        #region Accommodation file management
        #region Room
        private List<Room> room_list = new List<Room>();

        public void Add_rooms(Room room)
        {
            this.room_list.Add(room);
            // Write the updated data back to the file
            Update_json("Rooms.json",4);
        }
        public void Remove_rooms(int id) 
        { 
            this.room_list.RemoveAll(room => room.Id== id);
            Update_json("Rooms.json", 4);
        }
        public void Search_rooms(int id)
        {
            var room = this.room_list.Find(room => room.Id == id);
            if (room != null)
            {
                MessageBox.Show("ID:" + room.Id + "\nCapacity:" + room.capacity);
            }
            else {
                MessageBox.Show("No Room with that ID");

            }
        }

        #endregion

        #region Villa
        private List<Villa> villa_list = new List<Villa>();

        public void Add_villa(Villa villa)
        {
            this.villa_list.Add(villa);
            // Write the updated data back to the file
            Update_json("Villas.json", 3);
        }
        public void Remove_villa(int id)
        {
            this.villa_list.RemoveAll(villa => villa.Id == id);
            Update_json("Villas.json", 3);
        }
        public void Search_villa(int id)
        {
            var villa = this.villa_list.Find(villa => villa.Id == id);
            if (villa != null)
            {
                MessageBox.Show("ID:" + villa.Id + "\nCapacity:" + villa.capacity);
            }
            else
            {
                MessageBox.Show("No Villa with that ID");

            }
        }

        #endregion
        #endregion


        #region Reservation file management
        private List<Reservations> reservation_list = new List<Reservations>();
        public void Add_reservation(Reservations reservation)
        {
            this.reservation_list.Add(reservation);
            // Write the updated data back to the file
            Update_json("Reservations.json", 5);
        }
        public void Remove_reservation(int reservation_id)
        {
            this.reservation_list.RemoveAll(reservation => reservation.Reservation_id == reservation_id);
            Update_json("Reservations.json", 5);
        }
        public void Search_reservation(int reservation_id)
        {
            var reservation_search =  this.reservation_list.Find(reservation => reservation.Reservation_id == reservation_id);
            if (reservation_search != null) {
                
                //MessageBox.Show("Res:"+ reservation_searc);
            }
            
        }
        #endregion

    }
}
    
