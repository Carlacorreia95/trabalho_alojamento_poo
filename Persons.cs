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

        public Person(int age, string name, string sex) 
        { 
            this.age = age;
            this.name = name;
            this.sex = sex;
        }
    
    }
    internal class Client 
    { 
        private long fiscal_id;

        public Client(int age, string name, string sex, long fiscal_id): base( age, name, sex)
        {
        }
    }
}
