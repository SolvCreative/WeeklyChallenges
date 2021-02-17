using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            
            if (char.IsLetter(c) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals == null)
                return true;

            if (vals.Count() == 2 || vals.Count() % 2 == 0)
            {
                return true;
            }
            else if (vals.Count() == 1)
            {
                return false;
            }
            else
            {
                return false;
            }

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
            if(numbers != null && numbers.Count() > 0)
            {
                return numbers.Min() + numbers.Max();
            }
            else
            {
                return 0;
            }
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return (str1.Length < str2.Length) ? str1.Length : str2.Length;
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

            if (numbers == null)
            {
                return false;
            }
            else if (numbers != null && numbers.Sum() % 2 != 0)
            {
                return true;
            }
            else if (numbers != null && numbers.Sum() % -2 != 0)
            {
                return true;
            }
            else if (numbers.Sum() == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
                
                         
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number <= 1)
            {
                return 0;
            }
            if (number > 1 && number <= 3)
            {
                return 1;
            }
            if(number > 3 && number <= 5)
            {
                return 2;
            }
            if (number > 5)
            {
               var oddNumbers = (number / 2);
                return oddNumbers;
                                              
            }
            return 0;
        }
    }
}
