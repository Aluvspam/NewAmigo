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
        public Team ()
	    {
        var Engineer = new List(Engineer);
            var Manager = new Manager();  
	    }
        public void ReadFromConsole()
        {
            bool flag = true;
            while (!flag)
	{
	        Console.WriteLine("Cati inginerii sunt prezenti?");
            int numar;
            flag = int.TryParse(Console.ReadLine(), out numar); 
	}
     
                
        }
         
    }
}

