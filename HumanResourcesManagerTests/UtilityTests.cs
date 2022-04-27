using Microsoft.VisualStudio.TestTools.UnitTesting;
using HumanResourcesManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesManager.Tests
{
    [TestClass()]
    public class UtilityTests
    {
        [TestMethod()]
        public void SortTest()
        {
            /*//_Test version 0_
            List<Worker> workers = new List<Worker>();
            for(int i = 0; i < 10; i++)
            {
                workers.Add(new Worker());
            }
            for (int i = 0; i < 9; i++) 
            { 
                Assert.IsTrue(Int32.Parse(workers[i].getSalary())> Int32.Parse(workers[i + 1].getSalary()));
            }
            */

            /*// _Test version 1_ 

            //Arrange
            List<Worker> workers_empty = new List<Worker>;
            List<Worker> workers = new List<Worker>();
            Worker worker = new Worker();
            for (int i = 0; i < Utility.generator.Next(10,100); i++) 
            {
                workers.Add(worker);
            }
            int workerListLength0 = workers.Count;
            
            //Act
            
            Utility.Sort(workers);
            
            //Assert
            
            for (int i = 0; i < workers.Count-2; i++) 
            { 
                Assert.IsTrue(Int32.Parse(workers[i].getSalary())<= Int32.Parse(workers[i + 1].getSalary()));
            }
            Assert.AreEqual(workerListLength0, workers.Count);
            Assert.IsFalse(Utility.Sort(workers_empty));
            Assert.IsTrue(Utility.Sort(workers));
            */

            /* _Test version 2 (final)_*/
            //
            //Arrange

            List<Worker> workers_empty = new List<Worker>();
            List<Worker> workers = new List<Worker>();
            Worker worker = new Worker();
            for (int i = 0; i < Utility.random.Next(10, 100); i++)
                workers.Add(worker);
            int workerListLength0 = workers.Count;

            //Act

            Utility.Sort(workers, 0, workers.Count - 1);

            //Assert

            for (int i = 0; i < workers.Count - 2; i++)
            {
                Assert.IsTrue(Double.Parse(workers[i].GetSalary()) <= Double.Parse(workers[i + 1].GetSalary()));
            }
            Assert.AreEqual(workerListLength0, workers.Count);
            Assert.IsFalse(Utility.Sort(workers_empty, 0, workers_empty.Count - 1));
            Assert.IsTrue(Utility.Sort(workers, 0, workers.Count - 1));
        }

        [TestMethod()]
        public void CalculateIncomeTaxTest()
        {
            /* _Test version 0_ */
            ////Arrange
            //double salary = 3000;
            //double expectedIncomeTax = 300;
            ////Act
            //double actualIncomeTax = salary * 0.10;
            ////Assert
            //Assert.AreEqual(actualIncomeTax, expectedIncomeTax);

            /*_Test version 1_ */
            ////Arrange
            //double salary = 3000;
            //double expectedIncomeTax = 300;
            ////act
            //double actualIncomeTax = Utility.CalculateIncomeTax(salary);
            ////Assert
            //Assert.AreEqual(expectedIncomeTax, actualIncomeTax);

            /*_Test version 2 (final)_*/
            //Arrange
            double salary_10 = 3000;
            double salary_14 = 6470;
            double salary_20 = 9241;
            double salary_31 = 14841;
            double salary_35 = 20621;
            double salary_47 = 50000;
            double expectedIncomeTax_10 = 300;
            double expectedIncomeTax_14 = 905.8;
            double expectedIncomeTax_20 = 1848.2;
            double expectedIncomeTax_31 = 4600.71;
            double expectedIncomeTax_35 = 7217.35;
            double expectedIncomeTax_47 = 23500;

            //Act
            double actualIncomeTax_10 = Math.Round(Utility.CalculateIncomeTax(salary_10), 2);
            double actualIncomeTax_14 = Math.Round(Utility.CalculateIncomeTax(salary_14), 2);
            double actualIncomeTax_20 = Math.Round(Utility.CalculateIncomeTax(salary_20), 2);
            double actualIncomeTax_31 = Math.Round(Utility.CalculateIncomeTax(salary_31), 2);
            double actualIncomeTax_35 = Math.Round(Utility.CalculateIncomeTax(salary_35), 2);
            double actualIncomeTax_47 = Math.Round(Utility.CalculateIncomeTax(salary_47), 2);

            //Assert
            Assert.AreEqual(expectedIncomeTax_10, actualIncomeTax_10);
            Assert.AreEqual(expectedIncomeTax_14, actualIncomeTax_14);
            Assert.AreEqual(expectedIncomeTax_20, actualIncomeTax_20);
            Assert.AreEqual(expectedIncomeTax_31, actualIncomeTax_31);
            Assert.AreEqual(expectedIncomeTax_35, actualIncomeTax_35);
            Assert.AreEqual(expectedIncomeTax_47, actualIncomeTax_47);
        }   
     
    }
}