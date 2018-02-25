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

            //next: Random Select Engineers 
            List<Engineer> RandomSelectedEngineers = new List<Engineer>();

             
            

            //next: Business Rules

            //next: Export Engineers

            //next: Shift 1/ Shift 2

        }
    }
}
