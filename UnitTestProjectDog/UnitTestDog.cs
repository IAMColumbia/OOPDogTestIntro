using System;
using System.Collections.Generic;
using System.Text;
using DogLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjectDog
{
    [TestClass]
    public class UnitTestDog
    {

        Dog d;

        public UnitTestDog()
        {
            d = new Dog();
        }

        [TestMethod]
        public void TestDogHappyBirthday()
        {
            //Arrange
            int orignalAge, afterHappyBirthdayExpectedAge, afterHappyBirthdayDogAge;
            orignalAge = d.Age;
            afterHappyBirthdayExpectedAge = orignalAge + 1; //Assumption the Happy Birthday add 1 year to age

            //Act
            d.HappyBirthday();
            afterHappyBirthdayDogAge = d.Age;

            //Assert
            Assert.AreEqual(afterHappyBirthdayExpectedAge, afterHappyBirthdayDogAge);
        }

        [TestMethod]
        public void TestDogEat()
        {
            //Arrange

            int orignalWeight, afterEatExpectedWeight, afterEatActualDogWieght, afterEatHowMuchSevenActualDogWieght, afterEatSevenExpectedWeight;
            orignalWeight = d.Weight;
            afterEatExpectedWeight = orignalWeight + 1; //Assumption the eat adds 1 to weight

            afterEatSevenExpectedWeight = 10;

            //Act
            d.Eat();
            afterEatActualDogWieght = d.Weight;
            d.Eat(7);
            afterEatHowMuchSevenActualDogWieght = d.Weight;

            //Assert
            Assert.AreEqual(afterEatExpectedWeight, afterEatActualDogWieght);
            Assert.AreEqual(afterEatSevenExpectedWeight, afterEatHowMuchSevenActualDogWieght);
        }
    }
}
