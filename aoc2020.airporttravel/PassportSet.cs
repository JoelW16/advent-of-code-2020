using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace aoc2020.airporttravel
{
    public class PassportSet
    {  
        private Passport[] _passports;
        public PassportSet(string pathToPassportData)
        {            
            _passports = GetPassportsFromFile(pathToPassportData);
        }

        public int ValidPassportCount() {
            var countOfValidPassports = 0;
            foreach (var passport in _passports)
            {
                if (passport.IsValid()) countOfValidPassports ++;
            }
            return countOfValidPassports;
        }

        private static Passport[] GetPassportsFromFile(string path)
        {
            var  rawPassortData = File.ReadAllText(path);
            return Regex.Split(rawPassortData, "\n\n|\r\n\r").Select(p => new Passport(p)).ToArray();
        }
    }
}
