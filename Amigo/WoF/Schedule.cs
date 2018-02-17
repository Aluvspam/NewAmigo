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

        static void BauShift()
        {

        }
        public virtual void GetSchedule()//Schedule following business rules
        {
            List<Engineer> listE = new List<Engineer>();
            //next: Business Rules

            foreach (var item in listE)
            {
                if(listE.Count%2 == 0)
                {

                }
            }



            //next: Random Select Engineers 

            //next: Export Engineers

            //next: Shift 1/ Shift 2

        }
    }
}
