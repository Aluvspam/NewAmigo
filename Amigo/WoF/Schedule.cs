using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeellOfFate
{
    class Schedule
    {
        public List<Shift> Shifts;
        public Schedule()
        {
            Shifts = new List<Shift>();
        }
        static void BauShift()
        {

        }
       /* public virtual void GetSchedule(List<Engineer> engineers)//Schedule following business rules
        {
            //next: Business Rules
            foreach (var item in engineers)
            {
                if (item.id % 2 == 0)//regula: sa nu lucreze doua zile consecutive
                {

                }
                else if (Shift.)
                {

                }
                else if (true)
                {

                }
            }
        }*/

        //next: Random Select Engineers 
        //next: Export Engineers
        //next: Shift 1/ Shift 2
        //Incercare Dana
        public virtual void GetSchedule(List<Engineer> engineers)
        {
            foreach (var item in engineers)
            {
                if (item.id % 2 == 0)
                {
                   
                    Console.WriteLine("Complete one half day shift");
                }
                else
                { Console.WriteLine("One half day shift completed");
                }
                    
                else if (item.id >= 10)
                {
                    Console.WriteLine("Complete one whole day of support");
                }
               
                Random random = new Random();
                int randomID = random.Next();
            }
        }
        
        public override string ToString()
        {
            var result = "";
            foreach (var item in Shifts)//
            {
                result += "Shift: " + Shifts + Environment.NewLine;
            }
            return result;
        }
    }
}

