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
        private int[] CharacterIndices { get; }
        private char Character { get; }

        public RentalShopPasswordPolicy(string policy)
        {
            Character = GetCharacter(policy);
            CharacterIndices = GetIndices(policy);
        }

        public bool Accepts(string password)
        {
            var firstIndex = CharacterIndices[0] - 1;
            var secondIndex = CharacterIndices[1] - 1;
            return password[firstIndex].Equals(Character) ^ password[secondIndex].Equals(Character);
        }
        
        private static char GetCharacter(string policy)
        {
            return char.Parse(policy.Split(' ')[1]);
        }

        private static int[] GetIndices(string policy)
        {
            var range = policy.Split(' ')[0];
            return range.Split('-').Select(i => int.Parse(i)).ToArray();
        }
    }
}