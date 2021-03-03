using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var evens = numbers.Where(x => x % 2 == 0 || x % -2 == 0);
            var odds = numbers.Where(x => x % 2 != 0 || x % -2 != 0);            
            var result = (evens.Sum()) - (odds.Sum());
            return result;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var words = new List<string>();
            words.Add(str1); words.Add(str2); words.Add(str3); words.Add(str4);
            return words.Min(x => x.Length);         
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var numbers = new List<int>();
            numbers.Add(number1); numbers.Add(number2); numbers.Add(number3); numbers.Add(number4);
            return numbers.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";                                
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return (
                sideLength1 + sideLength2 > sideLength3 &&
                    sideLength1 + sideLength3 > sideLength2 &&
                    sideLength2 + sideLength3 > sideLength1
            );
        }

        public bool IsStringANumber(string input)
        {
            var isNumber = double.TryParse(input, out double number);
            return isNumber;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var amount = objs.Length;
            var majority = (amount / 2) + 1;
            var count = 0;

            foreach (var obj in objs)
            {
                if (obj == null)
                {
                    count++;
                }
            }
            if (count >= majority)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public double AverageEvens(int[] numbers)
        {

            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            var n = numbers.Where(num => num % 2 == 0);
            if (n.Count() == 0)
            {
                return 0;
            }
            else
            {
                return n.Average();
            }

        }
        public int Factorial(int number)
        {            
            if (number == 0)
            {
                return 1;
            }
            return number * Factorial(number - 1);
            
        }
    }
}
