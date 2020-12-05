using NUnit.Framework;

namespace aoc2020.airporttravel.test
{
    public class PassportTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CompletePassportIsValid()
        {
            var passportData = "ecl:gry pid:860033327 eyr:2020 hcl:#fffffd\rbyr:1937 iyr:2017 cid:147 hgt:183cm";
            var passport = new Passport(passportData);

            var result = passport.IsValid();
            
            Assert.IsTrue(result);
        }

        [Test]
        public void PassportMissingCountryIDIsValid()
        {
            var passportData = "ecl:gry pid:860033327 eyr:2020 hcl:#fffffd\rbyr:1937 iyr:2017 hgt:183cm";
            var passport = new Passport(passportData);

            var result = passport.IsValid();
            
            Assert.IsTrue(result);
        }

        [Test]
        public void PassportMissingEyeColourIsInvalid()
        {
            var passportData = "pid:860033327 eyr:2020 hcl:#fffffd\rbyr:1937 iyr:2017 cid:147 hgt:183cm";
            var passport = new Passport(passportData);

            var result = passport.IsValid();
            
            Assert.IsFalse(result);
        }

        [Test]
        public void PassportMissingPassportIDIsInvalid()
        {
            var passportData = "ecl:gry eyr:2020 hcl:#fffffd\rbyr:1937 iyr:2017 cid:147 hgt:183cm";
            var passport = new Passport(passportData);

            var result = passport.IsValid();
            
            Assert.IsFalse(result);
        }

        [Test]
        public void PassportMissingHeightIsInvalid()
        {
            var passportData = "ecl:gry pid:860033327 eyr:2020 hcl:#fffffd\rbyr:1937 iyr:2017 cid:147";
            var passport = new Passport(passportData);

            var result = passport.IsValid();
            
            Assert.IsFalse(result);
        }

        [Test]
        public void PassportMissingHairColourIsInvalid()
        {
            var passportData = "ecl:gry pid:860033327 eyr:2020\rbyr:1937 iyr:2017 cid:147 hgt:183cm";
            var passport = new Passport(passportData);

            var result = passport.IsValid();
            
            Assert.IsFalse(result);
        }

        [Test]
        public void PassportMissingBirthYearIsInvalid()
        {
            var passportData = "ecl:gry pid:860033327 eyr:2020 hcl:#fffffd\riyr:2017 cid:147 hgt:183cm";
            var passport = new Passport(passportData);

            var result = passport.IsValid();
            
            Assert.IsFalse(result);
        }

        [Test]
        public void PassportMissingIssueYearIsInvalid()
        {
            var passportData = "ecl:gry pid:860033327 eyr:2020 hcl:#fffffd\rbyr:1937 cid:147 hgt:183cm";
            var passport = new Passport(passportData);

            var result = passport.IsValid();
            
            Assert.IsFalse(result);
        }

        [Test]
        public void PassportMissingExpirationYearIsInvalid()
        {
            var passportData = "ecl:gry pid:860033327 hcl:#fffffd\rbyr:1937 iyr:2017 cid:147 hgt:183cm";
            var passport = new Passport(passportData);

            var result = passport.IsValid();
            
            Assert.IsFalse(result);
        }
    }
}