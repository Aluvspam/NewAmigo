using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeellOfFate
{
    public class Employee
    {
        public string Name;
        public int id;//initial era protected, dar am facut-o publica pentru ca am nevoie sa o folosesc pentru business rules 
        public string Role;

        public Employee(string name, int no, string role)
        {
            Name = name;
            id = no;
            Role = role;
        }
        public override string ToString()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    }
}
