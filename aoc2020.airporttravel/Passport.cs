using System;

namespace aoc2020.airporttravel
{
    public class Passport
    {
        private string _passportData;
        private string[] _mandatoryAttributes = {"ecl:", "pid:", "hgt:", "hcl:", "byr:", "iyr:", "eyr:"};
        public Passport(string passportData)
        {
            _passportData = passportData.Replace("\r", " ");
        }

        public bool IsValid() {
            foreach (var attribute in _mandatoryAttributes)
            {
                if (!_passportData.Contains(attribute)) return false;
            }
            return true;
        }
    }
}
