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
                Logger.Log_error("Failed to update json", ex);
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
        public bool Load_data(string filepath, int listToUpdate) { // 1-Client 2-Employee 3-Villa 4-Room 5-Reservation
            string existingJson = "";
            try {
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
            }
            catch (Exception ex)
            {
                Logger.Log_error("Failed to Load Data", ex);
                return false;
            }

            return true;
        }

        #endregion

        #region Clients file management  
        public List<Client> client_list = new List<Client>();
        public void Add_client(Client client)
        {
            try{
                this.client_list.Add(client);
                // Write the updated data back to the file
                Update_json("Clients.json", 1);
            }
            catch (Exception ex)
            {
            Logger.Log_error("Failed to Add Client", ex); 
            }
        }
        public void Remove_client(long fiscal_number) 
        {
            try
            {
                this.client_list.RemoveAll(client => client.Fiscal_number() == fiscal_number);
                Update_json("Clients.json", 1);
            }
            catch (Exception ex)
            {
                Logger.Log_error("Failed to remove client",ex);
            }
        }
        public void Search_client(long fiscal_number) 
        {
            try
            {
                var client = this.client_list.Find(client => client.Fiscal_number() == fiscal_number);

                if (client != null)
                {
                    MessageBox.Show("Name:" + client.name + "\nAge:" + client.age);
                }
                else
                {
                    MessageBox.Show("No Client with that fiscal number");
                }
            }
            catch (Exception ex) 
            {
                Logger.Log_error("Failed to search client",ex);
            }
        }
        #endregion

        #region Employee file management
        public List<Employee> employee_list = new List<Employee>();
        public void Add_employee(Employee employee)
        {
            try
            {
                this.employee_list.Add(employee);
                // Write the updated data back to the file
                Update_json("Employees.json", 2);
            }
            catch (Exception ex) 
            {
                Logger.Log_error("Failed to add employee",ex);
            }
        }
        public void Remove_employee(int employee_id)
        {
            try
            {
                this.employee_list.RemoveAll(employee => employee.Employee_id == employee_id);
                Update_json("Employees.json", 2);
            }
            catch(Exception ex)
            {
                Logger.Log_error("Failed to remove employee", ex);
            }
        }
        public void Search_employee(int employee_id)
        {
            try
            {
                var employee = this.employee_list.Find(employee => employee.Employee_id == employee_id);
                if (employee != null)
                {
                    MessageBox.Show("Name:" + employee.name + "\nAge:" + employee.age);
                }
                else
                {
                    MessageBox.Show("No Employee with that ID");
                }
            }
            catch (Exception ex)
            {
                Logger.Log_error("Failed to search employee",ex);
            }
        }
        #endregion

        #region Accommodation file management
        public int Get_next_id()
        {
            try
            {
                // Find the highest ID in rooms and villas
                int maxRoomId = room_list.Any() ? room_list.Max(r => r.Id) : 0;
                int maxVillaId = villa_list.Any() ? villa_list.Max(v => v.Id) : 0;

                // The next ID is the max of both + 1
                return Math.Max(maxRoomId, maxVillaId) + 1;
            }
            catch (Exception ex) 
            {
                Logger.Log_error("Failed to get the next ID",ex);
                return 0;
            }
        }

        #region Room
        public List<Room> room_list = new List<Room>();

        public void Add_rooms(Room room)
        {
            try
            {
                this.room_list.Add(room);
                // Write the updated data back to the file
                Update_json("Rooms.json", 4);
            }
            catch (Exception ex) 
            {
                Logger.Log_error("Failed to add rooms",ex);
            }
        }
        public void Remove_rooms(int id) 
        {
            try
            {
                this.room_list.RemoveAll(room => room.Id == id);
                Update_json("Rooms.json", 4);
            }
            catch (Exception ex) 
            {
                Logger.Log_error("Failed to remove room",ex);
            }

        }
        public void Search_room(int id)
        {
            try {
                var room = this.room_list.Find(room => room.Id == id);
                if (room != null)
                {
                    MessageBox.Show("ID:" + room.Id + "\nCapacity:" + room.capacity);
                }
                else {
                    MessageBox.Show("No Room with that ID");
                }
            }
            catch (Exception ex) 
            {
                Logger.Log_error("Failed to search room",ex);
            }

        }

        #endregion

        #region Villa
        public List<Villa> villa_list = new List<Villa>();

        public void Add_villa(Villa villa)
        {
            try
            {
                this.villa_list.Add(villa);
                // Write the updated data back to the file
                Update_json("Villas.json", 3);
            }
            catch (Exception ex) 
            {
                Logger.Log_error("Failed to add Villa", ex);
            }
        }
        public void Remove_villa(int id)
        {
            try
            {
                this.villa_list.RemoveAll(villa => villa.Id == id);
                Update_json("Villas.json", 3);
            }
            catch (Exception ex) 
            {
                Logger.Log_error("Failed to remove villa",ex);
            }
        }
        public void Search_villa(int id)
        {
            try
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
            catch (Exception ex) 
            {
                Logger.Log_error("Failed to search villa", ex);
            }
        }

        #endregion
        #endregion


        #region Reservation file management
        public List<Reservations> reservation_list = new List<Reservations>();
        public void Add_reservation(Reservations reservation)
        {
            try
            {
                this.reservation_list.Add(reservation);
                // Write the updated data back to the file
                Update_json("Reservations.json", 5);
            }
            catch (Exception ex) 
            {
                Logger.Log_error("Failed to add reservation",ex);
            }
        }
        
        public void Remove_reservation(int reservation_id)
        {
            try
            {
                this.reservation_list.RemoveAll(reservation => reservation.Reservation_id == reservation_id);
                Update_json("Reservations.json", 5);
            }
            catch (Exception ex) 
            {
                Logger.Log_error("Failed to remove reservation",ex);
            }
        }
        public void Search_reservation(int reservation_id)
        {
            try
            {
                var reservation_search = this.reservation_list.Find(reservation => reservation.Reservation_id == reservation_id);
                if (reservation_search != null)
                {

                    MessageBox.Show("No reservation found with that id");
                }
            }
            catch (Exception ex) 
            {
                Logger.Log_error("Failed to search a reservation",ex);
            }
        }
        #endregion

    }
}
    
