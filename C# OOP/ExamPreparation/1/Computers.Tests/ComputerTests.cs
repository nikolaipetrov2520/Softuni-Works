namespace Computers.Tests
{
    using NUnit.Framework;
    using System;

    public class ComputerTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void PartCtorWork()
        {
            Part part = new Part("gosho", 5);

            Assert.AreEqual("gosho", part.Name);
            Assert.AreEqual(5, part.Price);

        }

        [Test]
        public void ComputerCtorWork()
        {
            Computer computer = new Computer("acer");

            Assert.AreEqual("acer", computer.Name);           
        }


        [Test]
        public void ComputerNameThrowEx()
        {
            Assert.Throws<ArgumentNullException>(()=>
            {
                Computer computer = new Computer(null);
            });
        }


        [Test]
        public void ComputerPartsAdd()
        {
            Part part = new Part("gosho", 5);
            Computer computer = new Computer("Acer");
            computer.AddPart(part);
            Assert.AreEqual(1, computer.Parts.Count);         
        }

        [Test]
        public void ParIsNullAdd()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                Part part = null;
                Computer computer = new Computer("Acer");
                computer.AddPart(part);               
            });
            
        }

        [Test]
        public void ComputerTotalSum()
        {
            Part part1 = new Part("gosho", 5);
            Part part2 = new Part("pesho", 6);
            Computer computer = new Computer("Acer");
            computer.AddPart(part1);
            computer.AddPart(part2);
            Assert.AreEqual(11, computer.TotalPrice);
        }

        [Test]
        public void RemovePart()
        {
            Part part1 = new Part("gosho", 5);
            Part part2 = new Part("pesho", 6);
            Computer computer = new Computer("Acer");
            computer.AddPart(part1);
            computer.AddPart(part2);
            computer.RemovePart(part1);
            Assert.AreEqual(1, computer.Parts.Count);
        }

        [Test]
        public void GetPart()
        {
            Part part1 = new Part("gosho", 5);
            Part part2 = new Part("pesho", 6);
            Computer computer = new Computer("Acer");
            computer.AddPart(part1);
            computer.AddPart(part2);
            Assert.AreEqual(part1, computer.GetPart("gosho"));
        }
    }
}