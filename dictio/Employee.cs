using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace dictio
{
    public class Employee
    {
        public int ID { get; set; }
        public string Role { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public float Rate { get; set; }
        public float Salary
        {
            get
            {
                return Rate * 8 * 5 * 4 * 12;
            }
        }
        public Employee(int ID, string Role, string Name, int Age, float Rate) 
        {
            this.ID = ID;
            this.Name = Name;
            this.Age = Age;
            this.Rate = Rate;
            this.Role = Role;
        }
    }
}
