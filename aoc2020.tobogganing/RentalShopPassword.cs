using System;
using System.Linq;
using System.Security.Cryptography;

namespace aoc2020.tobogganing
{
    public class RentalShopPassword
    {
        public bool IsValid { get; }
        private RentalShopPasswordPolicy Policy { get; }

        public RentalShopPassword(string policyAndPassword)
        {
            Policy = ExtractPolicy(policyAndPassword);
            
            var password = ExtractPassword(policyAndPassword);
            IsValid = Policy.Accepts(password);
        }

        private static RentalShopPasswordPolicy ExtractPolicy(string policyAndPassword)
        {
            var policy = policyAndPassword.Split(':')[0];
            return new RentalShopPasswordPolicy(policy);
        }

        private static string ExtractPassword(string policyAndPassword)
        {
            return policyAndPassword.Split(':')[1].Trim();
        }
    }

    internal class RentalShopPasswordPolicy
    {
        private int MaxOccurrences { get; }
        private int MinOccurrences { get; }
        private char Character { get; }

        public RentalShopPasswordPolicy(string policy)
        {
            Character = GetCharacter(policy);
            MaxOccurrences = GetOccurrences(policy, false);
            MinOccurrences = GetOccurrences(policy, true);
        }

        public bool Accepts(string password)
        {
            var characterOccurrences = password.Count(c => c.Equals(Character));
            return characterOccurrences >= MinOccurrences && characterOccurrences <= MaxOccurrences;
        }
        
        private static char GetCharacter(string policy)
        {
            return char.Parse(policy.Split(' ')[1]);
        }
        
        private static int GetOccurrences(string policy, bool isMin)
        {
            var range = policy.Split(' ')[0];
            return int.Parse(range.Split('-')[isMin ? 0 : 1]);
        }
    }
}