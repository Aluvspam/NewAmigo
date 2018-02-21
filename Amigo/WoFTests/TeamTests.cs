using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeellOfFate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeellOfFate.Tests
{
    [TestClass()]
    public class TeamTests
    {
        [TestMethod()]
        public void SaveToFileTest()
        {
            Team team = new Team();
            team.Engineers.Add(new Engineer("Gabitza", 1, "dinLacInPutz"));
            team.Engineers.Add(new Engineer("Dana", 2, "inginera"));
            team.Engineers.Add(new Engineer("AndreiR", 3, "meseriash"));
            team.Engineers.Add(new Engineer("Cristi", 4, "maistru'"));
            team.Engineers.Add(new Engineer("Luana", 5, "spoiler"));
            team.Engineers.Add(new Engineer("Radu2", 6, "chiulangiu'"));
            team.Engineers.Add(new Engineer("Andrei", 7, "Dom'Profesor"));
            team.SaveToFile();
        }

        [TestMethod()]
        public void DeserializeFileTest()
        {
            Team team = new Team();
            team.DeserializeFile();
            Assert.AreEqual(team.Engineers.Count, 8);
        }
    }
}