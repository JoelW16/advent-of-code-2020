using NUnit.Framework;
using System.IO;

namespace aoc2020.airporttravel.test
{
    public class PassportSetTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FindsTwoValidPassports()
        {
            var pathToPassportData = Path.Combine("TestData", "testInput.txt");
            var passportSet = new PassportSet(pathToPassportData);

            var result = passportSet.ValidPassportCount();
                        
            Assert.That(result, Is.EqualTo(2));
        }
    }
}