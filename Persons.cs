using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Alojamento_POO
{
    internal class Person
    {
        private int age;
        private string name;
        private string sex;
        private int id_person;

        public Person(int age, string name, string sex, int id_person) 
        { 
            this.age = age; // alterar para birth date
            this.name = name;
            this.sex = sex;
            this.id_person = id_person;
        }
    
    }
    #region Client
    internal class Client : Person
    { 
        private long fiscal_number;

        public Client(int age, string name, string sex,int id_person ,long fiscal_number): base(age, name, sex, id_person)
        {
            this.fiscal_number = fiscal_number;
        }
    }
    #endregion
    #region Employee
    internal class Employee : Person
    {
        private string position;
        private string section;

        public Employee(int age, string name, string sex, int id_person, string position, string section) : base(age, name, sex, id_person)
        {
            this.position = position;
            this.section = section;
        }
    }
    #endregion
}
