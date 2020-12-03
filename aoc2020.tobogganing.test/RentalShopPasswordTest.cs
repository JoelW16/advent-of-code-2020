using NUnit.Framework;

namespace aoc2020.tobogganing.test
{
    public class RentalShopPasswordTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void PasswordIsValidForPolicy()
        {
            const string policyAndPassword = "1-3 a: abcde";
            var rentalShopPassword = new RentalShopPassword(policyAndPassword);

            Assert.IsTrue(rentalShopPassword.IsValid);
        }
        
        [Test]
        public void PasswordIsInvalidForPolicy()
        {
            const string policyAndPassword = "1-3 b: cdefg";
            var rentalShopPassword = new RentalShopPassword(policyAndPassword);

            Assert.IsFalse(rentalShopPassword.IsValid);
        }
    }
}