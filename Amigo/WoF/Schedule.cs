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
        public virtual void GetSchedule(List<Engineer> engineers )//Schedule following business rules
        {
           
            //next: Business Rules

            foreach (var item in engineers)
            {
               if (item.id%2 == 0)//reglua: sa nu lucreze doua zile consecutive
                {

               }
               else if (Shift.)
                {

                }
               else if (true)
               {

               }
            }



            //next: Random Select Engineers 

            //next: Export Engineers

            //next: Shift 1/ Shift 2

        }
    }
}
