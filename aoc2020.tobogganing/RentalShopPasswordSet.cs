using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace aoc2020.tobogganing
{
    public class RentalShopPasswordSet
    {
        private readonly List<RentalShopPassword> _passwords;
        public RentalShopPasswordSet(IEnumerable<string> policiesAndPasswords)
        {
            _passwords= policiesAndPasswords
                .Select(pap => new RentalShopPassword(pap))
                .ToList();
        }
        
        public RentalShopPasswordSet(string path) : this(GetPoliciesAndPasswordsFromFile(path))
        {
        }
        
        public int GetValidPasswordCount()
        {
            return _passwords.Count(password => password.IsValid);
        }
        
        private static IEnumerable<string> GetPoliciesAndPasswordsFromFile(string path)
        {
            return File.ReadLines(path).Select(expense => expense).ToList();
        }
    }
}