using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach (var item in vals)
            {
                if (item == false)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null) return false;
            
            return numbers.Where(x => x % 2 != 0).Sum() % 2 != 0;

            //var SumofOdd = numbers.Where(x => x % 2 != 0).Sum();
            //if (SumofOdd % 2 != 0)
            //{
            //    return true;
            //}
            //return false;

        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            char[] passwordChars = password.ToCharArray();
            if (passwordChars.Any(char.IsUpper) &&
                passwordChars.Any(char.IsLower) &&
                passwordChars.Any(char.IsDigit))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public char GetFirstLetterOfString(string val)
        {
           char[] charFirst = val.ToCharArray();
            return charFirst[0]; 
        }

        public char GetLastLetterOfString(string val)
        {
            char[] charLast = val.ToCharArray();
            return charLast[charLast.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
           List<int> numOdds = new List<int>();
            for (int i = 0; i < 101; i++)
            {
                if (i %2 != 0)
                {
                    numOdds.Add(i);    
                }
            }

            return numOdds.ToArray(); 
        }


        public void ChangeAllElementsToUppercase(string[] words)
        {


            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }

        }
    }
}
