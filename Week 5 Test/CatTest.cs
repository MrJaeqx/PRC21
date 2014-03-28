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

        [TestMethod]
        public void TestCatType()
        {
            // arange
            string expected = "Cat";
            Cat cat = new Cat("1337", new SimpleDate(1, 1, 1), "Naam", "dingen", false);

            // act
            string actual = cat.AnimalType;

            // assert
            Assert.AreEqual(expected, actual, "Wrong animal type.");
        }

        [TestMethod]
        public void TestCatToString()
        {
            // arange
            string expected = "Cat: 12341, 10-08-2018, Pinky, reserved, diek, 56";
            Cat cat = new Cat((12341).ToString(), new SimpleDate(10, 8, 2018), "Pinky", "diek", true);

            // act
            string actual = cat.ToString();

            // assert
            Assert.AreEqual(expected, actual, "Wrong to string.");
        }
    }
}
