using System;
using System.Collections.Generic;
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
            int[] names = new int[] { text.Split(",") };

            id = 0;
            for (int i = 0; i < names.Length; i++)
            {
                name = names[i];
                role = "Engineer";
                id++;
                Engineers.Add(new Engineer(names, role, id));
            }

            sr.Close();
        }
    }

}
