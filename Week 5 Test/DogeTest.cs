using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnimalShelter;

namespace TestProject
{
    [TestClass]
    public class DogeTest
    {

        [TestMethod]
        public void TestDogeTooLongChipNumber()
        {
            // arrange
            string chipNumber = "234567890";
            string expected = "23456";

            // act
            Dog doge = new Dog(chipNumber, new SimpleDate(1,1,1), "Doge", new SimpleDate(1,1,1), false);
            string actual = doge.ChipRegistrationNumber;

            // assert
            Assert.AreEqual(expected, actual, "Number not correctly trimmed");
        }

        [TestMethod]
        public void TestReservedSet()
        {
            // arrange
            bool reserved = true;
            bool expected = true;
            Dog dog = new Dog("1337", new SimpleDate(1, 1, 1), "Naam", new SimpleDate(1,1,1), false);

            // act
            dog.IsReserved = reserved;

            // assert
            bool actual = dog.IsReserved;
            Assert.AreEqual(expected, actual, "Reserved not set");
        }
    }
}
