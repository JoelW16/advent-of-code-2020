using System;
using System.Collections.Generic;
using System.IO;
using NUnit.Framework;

namespace aoc2020.tobogganing.test
{
    public class RentalShopPasswordSetTest
    {
        [Test]
        public void Has2ValidPasswords()
        {
            var policiesAndPasswords = new List<string>()
            {
                "1-3 a: abcde",
                "1-3 b: cdefg",
                "2-9 c: ccccccccc"
            };
            var rentalShopPasswordSet = new RentalShopPasswordSet(policiesAndPasswords);
            var result = rentalShopPasswordSet.GetValidPasswordCount();
            
            Assert.That(result, Is.EqualTo(1));
        }
        
        [Test]
        public void HasXValidPasswordsInFile()
        {
            var path = Path.Combine("TestData", "input.txt");
            var rentalShopPasswordSet = new RentalShopPasswordSet(path);
            var result = rentalShopPasswordSet.GetValidPasswordCount();
            
            Console.WriteLine(result);
            Assert.That(result, Is.EqualTo(502));
        }
    }
}