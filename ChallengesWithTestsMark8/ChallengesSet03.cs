using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (vals == null)
                return false;

            if (vals.Contains(false))
                return true;

            else return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
                return false;
            var numSum = 0;

            foreach (int num in numbers)
                if (num == 1 || num == 3 || num == -1 || num == -3 && num % 2 != 0)
                    numSum = numbers.Sum();
            if (numSum % 2 != 0 || numSum % -2 != 0)
                return true;
            else
                return false;

        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            
               if (password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit))
                    return true;
                else
                    return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val.ToCharArray()[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val.ToCharArray()[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
                return 0;
            else
                return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

       
        public int[] GetOddsBelow100()
        {
            var odd = Enumerable.Range(1, 100).Where(num => num % 2 != 0);
            return odd.ToArray();
           
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for(var i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
            
        }
    }
}
