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
            /* _Test version 0_ */
            //
            //List<Worker> workers = new List<Worker>();
            //for(int i = 0; i < 10; i++)
            //{
            //    workers.Add(new Worker());
            //}
            //for (int i = 0; i < 9; i++) 
            //{ 
            //    Assert.IsTrue(Int32.Parse(workers[i].getSalary())> Int32.Parse(workers[i + 1].getSalary()));
            //}

            /* _Test version 1_ */
            //
            //Arrange
            //List<Worker> workers_empty = new List<Worker>;
            //List<Worker> workers = new List<Worker>();
            //Worker worker = new Worker();
            //for (int i = 0; i < Utility.generator.Next(10,100); i++) 
            //{
            //    workers.Add(worker);
            //}
            //int workerListLength0 = workers.Count;
            ////Act
            //Utility.Sort(workers);
            ////Assert
            //for (int i = 0; i < workers.Count-2; i++) 
            //{ 
            //    Assert.IsTrue(Int32.Parse(workers[i].getSalary())<= Int32.Parse(workers[i + 1].getSalary()));
            //}
            //Assert.AreEqual(workerListLength0, workers.Count);
            //Assert.IsFalse(Utility.Sort(workers_empty));
            //Assert.IsTrue(Utility.Sort(workers));

            /* _Test version 2_*/
            //Arrange
            List<Worker> workers_empty = new List<Worker>();
            List<Worker> workers = new List<Worker>();
            Worker worker = new Worker();
            for (int i = 0; i < Utility.generator.Next(10, 100); i++)
                workers.Add(worker);
            int workerListLength0 = workers.Count;
            //Act
            Utility.Sort(workers,0,workers.Count-1);
            //Assert
            for (int i = 0; i < workers.Count - 2; i++)
            {
                Assert.IsTrue(Int32.Parse(workers[i].getSalary()) <= Int32.Parse(workers[i + 1].getSalary()));
            }
            Assert.AreEqual(workerListLength0, workers.Count);
            Assert.IsFalse(Utility.Sort(workers_empty,0, workers_empty.Count-1));
            Assert.IsTrue(Utility.Sort(workers,0,workers.Count-1));
        }
    }
}