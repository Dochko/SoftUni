namespace CustomLinkedList.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class DynamicListTests
    {
        private DynamicList<int> list;

        [TestInitialize]
        public void DynamicListInitialize()
        {
            this.list = new DynamicList<int>();
        }

        [TestMethod]
        public void TestOnListCreation_CountIsZero()
        {
            int initialCount = this.list.Count;
            Assert.AreEqual(0, initialCount, "A newly created list count should be 0.");
        }

        [TestMethod]
        public void TestAddingValuesIn_EmptyList_ShouldIncreaseCount()
        {
            this.list.Add(5);
            int countIncrementOne = this.list.Count;
            Assert.AreEqual(1, countIncrementOne, "After adding 1 value, the count should increment with 1.");

            this.list.Add(10);
            int countIncrementTwo = this.list.Count;
            Assert.AreEqual(2, countIncrementTwo, "After adding 2 values, the count should increment with 2.");
        }

        [TestMethod]
        public void TestAddingValuesIn_EmptyList()
        {
            this.list.Add(5);
            int valueInIndexZero = this.list[0];
            Assert.AreEqual(5, valueInIndexZero, "The value in list index 0 should be equal to the first value entered.");

            this.list.Add(10);
            int valueInIndexOne = this.list[1];
            Assert.AreEqual(10, valueInIndexOne, "The value in list index 1 should be equal to the second value entered.");
        }

        [TestMethod]
        [ExpectedException(typeof (ArgumentOutOfRangeException))]
        public void TestGetValueAt_NegativeIndex_Exception()
        {
            this.list.Add(5);
            int value = this.list[-1];
        }

        [TestMethod]
        [ExpectedException(typeof (ArgumentOutOfRangeException))]
        public void TestGetValueAt_GreaterIndex_Exception()
        {
            this.list.Add(5);
            int value = this.list[1];
        }

        [TestMethod]
        [ExpectedException(typeof (ArgumentOutOfRangeException))]
        public void TestSetValueTo_NegativeIndex_Exception()
        {
            this.list[-1] = 5;
        }

        [TestMethod]
        [ExpectedException(typeof (ArgumentOutOfRangeException))]
        public void TestSetValueTo_GreaterIndex_Exception()
        {
            this.list[1] = 5;
        }

        [TestMethod]
        public void TestSetOnValidIndex_ThenChangeTheValue()
        {
            this.list.Add(5);
            this.list[0] = 10;
            int changedValueAtIndexZero = this.list[0];
            Assert.AreEqual(10, changedValueAtIndexZero, "The value at index 0 should be changed through the indexer with the new value entered.");
        }

        [TestMethod]
        [ExpectedException(typeof (ArgumentOutOfRangeException))]
        public void TestRemoveAt_NegativeIndex()
        {
            this.list.RemoveAt(-1);
        }

        [TestMethod]
        [ExpectedException(typeof (ArgumentOutOfRangeException))]
        public void TestRemoveAt_GreaterIndex()
        {
            this.list.RemoveAt(1);
        }

        [TestMethod]
        public void TestCountAfter_RemoveAt()
        {
            this.list.Add(5);
            this.list.Add(10);
            this.list.RemoveAt(1);
            int count = this.list.Count;
            Assert.AreEqual(1, count, "After adding two values and then remove one of them, the count must be 1.");
        }

        [TestMethod]
        public void TestRemoveAt()
        {
            this.list.Add(5);
            this.list.Add(10);
            this.list.Add(15);
            this.list.RemoveAt(1);
            int firstNumber = this.list[0];
            int secondNumber = this.list[1];
            Assert.AreEqual(5, firstNumber, "The first number should be the first entered in the list.");
            Assert.AreEqual(15, secondNumber, "The second number should be the third entered in the list.");
        }

        [TestMethod]
        public void TestCountAfter_RemoveNonExistingValue()
        {
            this.list.Add(5);
            this.list.Add(10);
            this.list.Remove(15);
            int count = this.list.Count;
            Assert.AreEqual(2, count, "After adding 2 values and remove a non-existing one, the count should not change.");
        }

        [TestMethod]
        public void TestCountAfter_RemoveValueFromlist()
        {
            this.list.Add(5);
            this.list.Add(10);
            this.list.Add(15);
            this.list.Remove(15);
            int count = this.list.Count;
            Assert.AreEqual(2, count, "After adding 3 values and removing one of them, the count should be 2.");
        }

        [TestMethod]
        public void TestReturnValueAfter_RemoveValueFromList()
        {
            this.list.Add(5);
            this.list.Add(10);
            int index = this.list.Remove(10);
            Assert.AreEqual(1, index, "The index of the removed element should be 1.");
        }

        [TestMethod]
        public void TestReturnValueAfter_RemoveNonExistingValueFromTheList()
        {
            this.list.Add(5);
            this.list.Add(10);
            int index = this.list.Remove(15);
            Assert.AreEqual(-1, index, "The returned index of a non-existing element should be -1.");
        }

        [TestMethod]
        public void TestContainsOn_ExistingElement()
        {
            this.list.Add(5);
            this.list.Add(10);
            bool isFound = this.list.Contains(10);
            Assert.IsTrue(isFound, "When the value is in the list, contains should return true.");
        }

        [TestMethod]
        public void TestContainsOn_NonExistingElement()
        {
            this.list.Add(5);
            this.list.Add(10);
            bool isFound = this.list.Contains(15);
            Assert.IsFalse(isFound, "When the value is not in the list, contains should return false.");
        }
    }
}
