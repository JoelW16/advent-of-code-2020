using aoc2020.tobogganing.RentalShop;
using NUnit.Framework;

namespace aoc2020.tobogganing.test.RentalShop
{
    public class RentalShopPasswordTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void PasswordIsValidForPolicyWithOneOccurrence()
        {
            const string policyAndPassword = "1-3 a: abcde";
            var rentalShopPassword = new RentalShopPassword(policyAndPassword);

            Assert.IsTrue(rentalShopPassword.IsValid);
        }

         [Test]
        public void PasswordIsInvalidForPolicyWithNoOccurrences()
        {
            const string policyAndPassword = "1-3 b: cdefg";
            var rentalShopPassword = new RentalShopPassword(policyAndPassword);

            Assert.IsFalse(rentalShopPassword.IsValid);
        }
        
        [Test]
        public void PasswordIsInvalidForPolicyWithBothOccurrences()
        {
            const string policyAndPassword = "2-9 c: ccccccccc";
            var rentalShopPassword = new RentalShopPassword(policyAndPassword);

            Assert.IsFalse(rentalShopPassword.IsValid);
        }
    }
}