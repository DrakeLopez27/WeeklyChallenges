using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Markup;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            if(char.IsLetter(c))
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
            if (vals.Length % 2 == 0) 
            {
                return true;
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
            if (num % 2 !=0)
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
            return numbers == null || numbers.Count() == 0 ? 0 : numbers.Min() + numbers.Max();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length > str2.Length)
            {
                return str2.Length;
            }
            else
            {
                return str1.Length;
            }
        }

        public int Sum(int[] numbers)
        {
            if(numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            else
            {
                int sum = numbers.Sum();
                return sum;

            }

        }

        public int SumEvens(int[] numbers)
        {
            var evenSum = 0;
            

            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                int number = numbers[i];
                if (IsNumberEven(number))
                {
                    evenSum += number;
                }
            }
                 return evenSum;
           
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if(numbers == null)
            {
                return false;
            }


            int sum = numbers.Sum();
          
            if(sum % 2 != 0)
            {
                return true;
            }
            else if(sum % 2 == 0)
            {
                return false;
            }
            else
            {
                return false;
            }

            
            

        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            var count = 0;

            for(var i = 0; i < number; i++)
            {
                if(i % 2 != 0)
                {
                    count++;
                }

            }
             return count;
        }
    }
}
