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
            throw new NotImplementedException();
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            throw new NotImplementedException();
        }

        public bool IsStringANumber(string input)
        {
            throw new NotImplementedException();
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            throw new NotImplementedException();
        }

        public double AverageEvens(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public int Factorial(int number)
        {
            throw new NotImplementedException();
        }
    }
}
