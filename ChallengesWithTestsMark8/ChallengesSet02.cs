using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            throw new NotImplementedException();
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            throw new NotImplementedException();
        }

        public bool IsNumberEven(int number)
        {
            if(number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            throw new NotImplementedException();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            throw new NotImplementedException();
        }

        public int Sum(int[] numbers)
        {
            int sum = 0;
            if (numbers == null)
                return 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers.Length >= 0)
                   sum += numbers[i];

                else
                   sum = 0;            
            }
            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            int sum = 0;
                        
            if (numbers == null)
                return 0;
            
            foreach (int i in numbers)
            {
                if (i % 2 == 0)
                sum += i;
            }   
                return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            throw new NotImplementedException();
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            throw new NotImplementedException();
        }
    }
}
