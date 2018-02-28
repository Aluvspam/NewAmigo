using System;
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
        public virtual void GetSchedule(List<Engineer> engineers)//Schedule following business rules
        {
            //next: Random Select Engineers 

            Random random = new Random(0);
            var r1 = random.Next(engineers.Count);//imi selecteaza random dupa numarul de ingineri
            Engineer en1 = new Engineer("Gita", 0, "Inginer");// setam un inginer initial cu id-ul 0 TO DO: do we really need this?
            if (r1 % 2 != 0)
            {
                en1.id = r1;// daca valoarea este reala, schimbam id-ulinginerului cu val din r1
            }
            //next: Random Select Engineers 

            List<Engineer> RandomSelectedEngineers = new List<Engineer>();// lista cu ingineri random
            RandomSelectedEngineers.Add(en1);//adauga in lista 

            //next: Export Engineers
            //next: Shift 1/ Shift 2

            //incercare andrei
            //we asume that we created shifts in chronological order if last shift is 2 weeks from now we already created the schedule and we can return it, else we need to create it now
            if (Shifts[Shifts.Count - 1].StartTime.Day < DateTime.Now.Day + 14)
            {
                CreateRandomSchedule();
            }
        }
        //populates shifts
        private void CreateRandomSchedule()
        {
            throw new NotImplementedException();
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

