using NUnit.Framework;
using System;
using TheRace;

namespace TheRace.Tests
{
    public class RaceEntryTests
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void UniCarCtorWork()
        {
            UnitCar car = new UnitCar("golf", 100, 2000);

            Assert.AreEqual("golf", car.Model);
            Assert.AreEqual(100, car.HorsePower);
            Assert.AreEqual(2000, car.CubicCentimeters);
        }

        [Test]
        public void UniDriverCtorWork()
        {
            UnitCar car = new UnitCar("golf", 100, 2000);
            UnitDriver driver = new UnitDriver("gosho", car);

            Assert.AreEqual("gosho", driver.Name);
            Assert.AreEqual(car, driver.Car);

        }

        [Test]
        public void UniDriverCtorNotWork()
        {


            Assert.Throws<ArgumentNullException>(() =>
            {
                UnitCar car = new UnitCar("golf", 100, 2000);
                UnitDriver driver = new UnitDriver(null, car);
            });


        }

        [Test]
        public void AddDriverDriverIsNull()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                UnitDriver driver = null;
                RaceEntry race = new RaceEntry();
                race.AddDriver(driver);
            });
        }

        [Test]
        public void AddDriverWork()
        {

            UnitCar car = new UnitCar("golf", 100, 2000);
            UnitDriver driver = new UnitDriver("gosho", car);
            RaceEntry race = new RaceEntry();
            race.AddDriver(driver);

            Assert.AreEqual(race.Counter, 1);

        }

        [Test]
        public void AddDriverDriverExist()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                UnitCar car = new UnitCar("golf", 100, 2000);
                UnitDriver driver = new UnitDriver("gosho", car);
                RaceEntry race = new RaceEntry();
                race.AddDriver(driver);
                race.AddDriver(driver);

            });

        }

        [Test]
        public void CalcAverageDriverIsLess2()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                UnitCar car = new UnitCar("golf", 100, 2000);
                UnitDriver driver = new UnitDriver("gosho", car);
                RaceEntry race = new RaceEntry();
                race.AddDriver(driver);
                race.CalculateAverageHorsePower();

            });

        }

        [Test]
        public void CalcAverageWork()
        {

            UnitCar car1 = new UnitCar("golf", 100, 2000);
            UnitDriver driver1 = new UnitDriver("gosho", car1);
            UnitCar car2 = new UnitCar("lada", 300, 2000);
            UnitDriver driver2 = new UnitDriver("pesho", car2);
            RaceEntry race = new RaceEntry();
            race.AddDriver(driver1);
            race.AddDriver(driver2);

            Assert.AreEqual(race.CalculateAverageHorsePower(), 200);

        }
    }
}