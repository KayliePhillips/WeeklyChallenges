using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            if (Char.IsLetter(c) == true)
                return true;
            else
                return false;
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            int[] totalElements = new int[vals.Length];
            
            if (vals.Length %2 == 0)
                return true;
            else
                return false;
        }

        public bool IsNumberEven(int number)
        {
            if(number%2 ==0)
                return true;
            else
                return false;
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
                return true;
            else
                return false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null)
                return 0;
            
            double[] numArray = numbers.ToArray();
            Array.Sort(numArray);

            if (numArray.Length == 0)
                return 0;

            double sum;
            sum = numArray[0] + numArray[numArray.Length - 1];
            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length > str2.Length)
                return str2.Length;
            else
                return str1.Length;
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            return 0;

            int sum = 0;
            foreach (var num in numbers)
            {
                sum += num;
            }
            return sum;

        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
                return 0;

            var evenOnly = new List<int>();

            foreach (var num in numbers)
            {
                if(num % 2 == 0)
                    evenOnly.Add(num);
            }
            return evenOnly.Sum();
                       
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
                return false;

            int sum = 0;
            foreach (var num in numbers)
            {
                sum += num;
            }

            if (sum % 2 != 0)
                return true;
            else
                return false;

        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number == null)
                return 0;

            List<int> odd = new List<int>();
            
            
            for (int i = 0; i < number; i++)
            {
                if (i % 2 != 0) 
                    odd.Add(i);
                
            }
            return odd.Count; 

        }


        
    }
}

