namespace BashSoftTesting
{
    using System;
    using System.Collections.Generic;
    using Executor.Contracts;
    using Executor.DataStructures;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class OrderedDataStructureTester
    {
        private ISimpleOrderedBag<string> names;

        [TestMethod]
        public void TestEmptyCtor()
        {
            this.names = new SimpleSortedList<string>();
            Assert.AreEqual(16, this.names.Capacity);
            Assert.AreEqual(0, this.names.Size);
        }

        [TestMethod]
        public void TestCtorWithInitialCapacity()
        {
            this.names = new SimpleSortedList<string>(20);
            Assert.AreEqual(20, this.names.Capacity);
            Assert.AreEqual(0, this.names.Size);
        }


        [TestMethod]
        public void TestCtorWithAllParams()
        {
            this.names = new SimpleSortedList<string>(StringComparer.OrdinalIgnoreCase, 20);
            Assert.AreEqual(20, this.names.Capacity);
            Assert.AreEqual(0, this.names.Size);
        }


        [TestMethod]
        public void TestCtorWithInitialCompararer()
        {
            this.names = new SimpleSortedList<string>(StringComparer.OrdinalIgnoreCase);
            Assert.AreEqual(16, this.names.Capacity);
            Assert.AreEqual(0, this.names.Size);
        }

        [TestInitialize]
        public void SetUp()
        {
            this.names = new SimpleSortedList<string>(StringComparer.OrdinalIgnoreCase);
        }

        [TestMethod]
        public void TestAddIncreaseSize()
        {
            this.names.Add("Nasko");
            Assert.AreEqual(1, this.names.Size);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestAddNullThrowsException()
        {
            this.names.Add(null);
        }

        [TestMethod]
        public void TestAddUnsortedDataIsHeldSorted()
        {
            string[] check = new[] {"Balkan", "Georgi", "Rosen"};
            this.names.Add("Rosen");
            this.names.Add("Georgi");
            this.names.Add("Balkan");
            int counter = 0;
            foreach (var name in this.names)
            {
                Assert.AreEqual(check[counter++], name);
            }
        }

        [TestMethod]
        public void TestAddingMoreThanInitialCapacity()
        {
            for (int i = 0; i < 17; i++)
            {
                this.names.Add("S");
            }

            Assert.AreEqual(17, this.names.Size);
            Assert.AreNotEqual(16, this.names.Capacity);
        }

        [TestMethod]
        public void TestAddingAllFromCollectionIncreasesSize()
        {
            List<string> checker =new List<string>();
            checker.Add("first");
            checker.Add("second");
            this.names.AddAll(checker);
            Assert.AreEqual(2, this.names.Size);
            
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestAddingAllFromNullThrowsException()
        {
            this.names.AddAll(null);
        }

        [TestMethod]
        public void TestAddAllKeepsSorted()
        {
            List<string> checker = new List<string>() { "Balkan", "Georgi", "Rosen" };
            string[] check = new[] { "Balkan", "Georgi", "Rosen" };
            this.names.AddAll(checker);
            int counter = 0;
            foreach (var name in this.names)
            {
                Assert.AreEqual(check[counter++], name);
            }
        }

        [TestMethod]
        public void TestRemoveValidElementDecreasesSize()
        {
            this.names.Add("Nasko");
            this.names.Remove("Nasko");

            Assert.AreEqual(0, this.names.Size);
        }

        [TestMethod]
        public void TestRemoveValidElementRemovesSelectedOne()
        {
            this.names.Add("Nasko");
            this.names.Add("Ivan");
            this.names.Remove("Ivan");
            var isNotThere = this.names.Remove("Ivan");
            Assert.AreEqual(isNotThere , false);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestRemovingNullThrowsException()
        {
            this.names.Remove(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestJoinWithNull()
        {
            this.names.Add("Nasko");
            this.names.Add("Stoyan");
            this.names.JoinWith(null);
        }

        [TestMethod]
        public void TestJoinWorksFine()
        {
            this.names.Add("Nasko");
            this.names.Add("Stoyan");

            Assert.AreEqual(this.names.JoinWith(","),"Nasko,Stoyan");
        }



    }
}
