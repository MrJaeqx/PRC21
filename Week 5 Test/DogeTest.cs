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

        [TestMethod]
        public void TestDogType()
        {
            // arange
            string expected = "Dog";
            Dog dog = new Dog("1337", new SimpleDate(1, 1, 1), "Naam", new SimpleDate(1, 1, 1), false);

            // act
            string actual = dog.AnimalType;

            // assert
            Assert.AreEqual(expected, actual, "Wrong animal type.");
        }

        [TestMethod]
        public void TestDogPriceLow()
        {
            // arange
            decimal expected = 200;
            Dog dog = new Dog("1337", new SimpleDate(1, 1, 1), "Naam", new SimpleDate(1, 1, 1), false);

            // act
            decimal actual = dog.Price;

            // assert
            Assert.AreEqual(expected, actual, "Wrong low price.");
        }

        [TestMethod]
        public void TestDogPriceHigh()
        {
            // arange
            decimal expected = 350;
            Dog dog = new Dog("500444", new SimpleDate(1, 1, 1), "Naam", new SimpleDate(1, 1, 1), false);

            // act
            decimal actual = dog.Price;

            // assert
            Assert.AreEqual(expected, actual, "Wrong high price.");
        }

        [TestMethod]
        public void TestDogToString()
        {
            // arange
            string expected = "Dog: 12321, 01-01-1651, Munnie, not reserved, 05-08-1483, 200";
            Dog dog = new Dog((12321).ToString(), new SimpleDate(1, 1, 1651), "Munnie", new SimpleDate(5, 8, 1483), false);

            // act
            string actual = dog.ToString();

            // assert
            Assert.AreEqual(expected, actual, "Wrong to string.");
        }
    }
}
