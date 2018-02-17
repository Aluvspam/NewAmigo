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
		public List<Manager> Manager;

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
	}




}
