using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (vals.Length == 0|| vals == null) 
            { return false; }

            foreach (var val in vals)
            {
                if( val == false) return true;
         
            }
            return false;
            
        }   


        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            return numbers != null && numbers.Where(x => x % 2 != 0).Sum() % 2 != 0;

        }
            
        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool isLower = false;
            bool isDigit = false;
            bool isUpper = false;

            foreach(var letter in password)
            {
                if(char.IsLower(letter))
                {
                    isLower = true;
                }
                if (char.IsUpper(letter))
                {
                    isUpper= true;
                }
                if (char.IsDigit(letter))
                {
                    isDigit = true;
                }
            }
                return isUpper && isLower && isDigit;


        }

        public char GetFirstLetterOfString(string val)
        {
            return  val.First();
        }

        public char GetLastLetterOfString(string val)
        {
            return val.Last();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            return divisor == 0 ? 0 : dividend / divisor;

        }

        public int LastMinusFirst(int[] nums)
        {
            return nums.Last() - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            return Enumerable.Range(1,100).Where(x=> x % 2 != 0).ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
          for (int i = 0; i< words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
          
        }
    }
}
