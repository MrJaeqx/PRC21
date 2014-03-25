using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnimalShelter;

namespace TestProject
{
    [TestClass]
    public class CatTest
    {
        [TestMethod]
        public void TestCatTooLongChipNumber()
        {
            // arrange
            string chipNumber = "234567890";
            string expected = "23456";

            // act
            Cat cat = new Cat(chipNumber, new SimpleDate(1, 1, 1), "Name", "euleuleul", false);
            string actual = cat.ChipRegistrationNumber;

            // assert
            Assert.AreEqual(expected, actual, "Number not correctly trimmed");
        }

        [TestMethod]
        public void TestBadHabitsSet()
        {
            // arrange
            string badHabit = "Hoi";
            string expected = "Hoi";
            Cat cat = new Cat("1337", new SimpleDate(1,1,1), "Naam", "", false);

            // act
            cat.BadHabits = badHabit;

            // assert
            string actual = cat.BadHabits;
            Assert.AreEqual(expected, actual, "Bad habit not set");
        }

        [TestMethod]
        public void TestReservedSet()
        {
            // arrange
            bool reserved = true;
            bool expected = true;
            Cat cat = new Cat("1337", new SimpleDate(1, 1, 1), "Naam", "", false);

            // act
            cat.IsReserved = reserved;

            // assert
            bool actual = cat.IsReserved;
            Assert.AreEqual(expected, actual, "Reserved not set");
        }
    }
}
