﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeellOfFate
{
    class Schedule
    {
        public List<Shifts> Shifts;
        public Schedule()
        {
           Shifts = new List<Shifts>();
        }
        static void BauShift()
        {

        }
        public virtual void GetSchedule(List<Engineer> engineers )//Schedule following business rules
        {

            //next: Random Select Engineers 
            List<Engineer> RandomSelectedEngineers = new List<Engineer>();

                 }
             }
         }

        //next: Random Select Engineers 
        //next: Export Engineers
        //next: Shift 1/ Shift 2
        //Incercare Dana
        public virtual void GetSchedule(List<Engineer> engineers)
        {
            foreach (var item in engineers)
            {
                if (WeellOfFate.Shifts.id % 2 == 0)
                {
                    Console.WriteLine("Complete one half day shift");
                }
                else
                {
                    Console.WriteLine("One half day shift completed yesterday");
                }
                else if (WeellOfFate.Shifts.id >= 10)
                {
                    Console.WriteLine("Complete one whole day of support");
                }
               
                Random random = new Random();
                int randomID = random.Next(50);
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

