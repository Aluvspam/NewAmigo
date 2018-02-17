using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeellOfFate
{
    public class Manager: Employee
    {
        public Manager(string name, int no, string role) : base(name, no, role)
        {
            Name = name;
            id = no;
            Role = role;
        }
        public static void InputData()
        {
			
	
        }
		public void SaveToFile()
		{
			TextWriter tw = new StreamWriter("Engineers.txt");
			foreach (string s in List<Engineer>.Engineers)
			tw.WriteLine(s);
		}

		
		
	}
}
