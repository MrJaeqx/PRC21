using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnimalShelter;

namespace TestProject
{
    [TestClass]
    public class AdministrationTest
    {
        [TestMethod]
        public void TestAdd()
        {
            // arrange
            Administration admin = new Administration();
            Dog doge = new Dog("1337", new SimpleDate(1, 1, 1), "Naam", new SimpleDate(1, 1, 1), false);
            bool expected = true;

            // act
            bool succes = admin.Add(doge);

            // assert
            Assert.AreEqual(expected, succes, "Dog not added");
        }

        [TestMethod]
        public void TestAddDouble()
        {
            // arrange
            Administration admin = new Administration();
            Dog doge = new Dog("12341", new SimpleDate(1, 1, 1), "Naam", new SimpleDate(1, 1, 1), false);
            bool expected = false;

            // act
            bool succes = admin.Add(doge);

            // assert
            Assert.AreEqual(expected, succes, "Dog added double");
        }

        //[TestMethod]
        //public void TestAddTooLongChipNumber()
        //{
        //    // arange
        //    Administration admin = new Administration();
        //    Dog doge = new Dog("18489474867346", new SimpleDate(1, 1, 1), "Naam", new SimpleDate(1, 1, 1), false);
        //    bool expected = false;

        //    // act
        //    bool actual = admin.Add(doge);
            
        //    // assert
        //    Assert.AreEqual(expected, actual, "Chip number too long");
        //}

        [TestMethod]
        public void TestRemove()
        {
            // arrange
            Administration admin = new Administration();
            string chip = "12341";
            bool expected = true;

            // act
            bool succes = admin.RemoveAnimal(chip);

            // assert
            Assert.AreEqual(expected, succes, "Dog not removed");
        }

        [TestMethod]
        public void TestRemoveNonExistent()
        {
            // arrange
            Administration admin = new Administration();
            string chipNumber = "11111111";
            bool expected = false;

            // act
            bool succes = admin.RemoveAnimal(chipNumber);

            // assert
            Assert.AreEqual(expected, succes, "Non existing dog removed.");
        }

        [TestMethod]
        public void TestFind()
        {
            // arrange
            Administration admin = new Administration();
            Dog doge = new Dog("13372", new SimpleDate(1, 1, 1), "Naam", new SimpleDate(1, 1, 1), false);
            string chip = "13372";
            Dog expected = doge;
            admin.Add(doge);

            // act
            Animal succes = admin.FindAnimal(chip);

            // assert
            Assert.AreEqual(expected, succes, "Dog not found");
        }

        [TestMethod]
        public void TestFindFalse()
        {
            // arrange
            Administration admin = new Administration();
            string chip = "13372";
            Dog expected = null;

            // act
            Animal succes = admin.FindAnimal(chip);

            // assert
            Assert.AreEqual(expected, succes, "Dog not found");
        }
    }
}
