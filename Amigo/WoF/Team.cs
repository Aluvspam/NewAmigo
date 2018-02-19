using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeellOfFate
{
    public class Team
    {
        public List<Engineer> Engineers;
        public Manager Manager;

        public Team()
        {
            Engineers = new List<Engineer>();
        }

        public void ReadFromFile(string fileName)
        {
            StreamReader sr = new StreamReader(fileName);
            string text = sr.ReadToEnd();
            string[] names = text.Split(',');
            var id = 0;
            for (int i = 0; i < names.Length; i++)
            {
                var name = names[i];
                var role = "Engineer";
                id++;
                Engineers.Add(new Engineer(name, id, role));
            }
            sr.Close();
        }
    }
}
