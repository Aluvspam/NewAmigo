using System;
using System.Collections;
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

		public void SaveToFile()
		{
			TextWriter tw = new StreamWriter("Engineers.txt");
			foreach (string s in List<Engineer>.Engineers)
				tw.WriteLine(s);
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

        public void ReadFromConsole()
        {
            bool flag = true;
            int numar = 0;
            var role = "Engineer";
            while (!flag)
            {
                Console.WriteLine("Cati inginerii sunt prezenti?");
                flag = int.TryParse(Console.ReadLine(), out numar);
            }
            for (int i = 0; i < numar; i++)
            {
                string nume = Console.ReadLine();
                Engineers.Add(new Engineer(nume, i, role));
            }
        }
    }
}

