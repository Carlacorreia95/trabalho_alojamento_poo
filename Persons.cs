using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Trabalho_Alojamento_POO
{
    public class Person
    {
        public int age { get; set; }
        public string name { get; set; }
        public string sex { get; set; }

        public Person(int age, string name, string sex) 
        { 
            this.age = age; // alterar para birth date
            this.name = name;
            this.sex = sex;
        }
    
    }
    #region Client

    public class Client : Person
    { 
        public long fiscal_number { get; set; }

        public Client(int age, string name, string sex,long fiscal_number): base(age, name, sex)
        {
            this.fiscal_number = fiscal_number;
        }
        public long Fiscal_number()
        { 
            return this.fiscal_number; 
        }
     }
    #endregion
    #region Employee
        public class Employee : Person
    {
        public string position { get; set; }
        public string section { get; set; }
        private int employee_id { get; set; }

        public int Employee_id { get => employee_id; }
        public Employee(int age, string name, string sex, int employee_id, string position, string section) : base(age, name, sex)
        {
            this.position = position;
            this.section = section;
            this.employee_id = employee_id;
        }

    }
    #endregion
}
