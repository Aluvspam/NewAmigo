using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeellOfFate
{
    public class Engineer : Employee
    {
        public List<Shifts> Shift { get; set; }
        public Engineer(string name, int no, string role) : base(name, no, role)
        {

        }
       
    }
}
