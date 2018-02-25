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
            Engineer en1 = new Engineer("Gita", 0, "Inginer");// setam un inginer initial cu id-ul 0
            if (r1%2 !=0)
            {
                en1.id = r1;// daca valoarea este reala, schimbam id-ulinginerului cu val din r1
            }
            //next: Random Select Engineers 

            List<Engineer> RandomSelectedEngineers = new List<Engineer>();// lista cu ingineri random
            RandomSelectedEngineers.Add(en1);//adauga in lista 
            
            //next: Export Engineers
            //next: Shift 1/ Shift 2
        }

        //Incercare Dana
        public virtual void GetSchedule(List<Engineer> engineers, int no = 0)// am mai adaugat un parametru in metoda Danei pentru a nu exista un conflict intre metoda de sus si asta 
        {
            foreach (var item in engineers)
            {
                if (WeellOfFate.Shifts.id % 2 == 0)
                {
                    Console.WriteLine("Complete one half day shift");
                }
                else if (WeellOfFate.Shifts.id >= 10)
                {
                    Console.WriteLine("Complete one whole day of support");
                }
                else
                {
                    Console.WriteLine("One half day shift completed yesterday");
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

