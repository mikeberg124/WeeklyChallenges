using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach (var v in vals)
            {
                if (v == false)
                {
                    return true;

                }


            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null || numbers.Count() == 00)
            {
                return false;
            }

            int sum = 0;
            foreach (var num in numbers)
            {
                if (num % 2 != 0)
                {
                    sum += num;
                }
                if (sum % 2 != 0)
                {
                    return true;

                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool isUpper = false;
            bool isLower = false;
            bool isNumber = false;
            foreach (var ch in password)
            {
                if (char.IsLower(ch) )
                {
                    isLower = true;
                }
                if (char.IsUpper(ch))
                {
                    isUpper = true;
                }
                if (char.IsNumber(ch))
                {
                    isNumber = true;
                }
            }
            if (isLower && isUpper && isNumber)
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
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val [val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            else
            {
                return (dividend / divisor);
            }
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[^1] - nums[0];
            //^1 = last character or number in list( same as .length -1) ^2 would be second last, etc.
        }

        public int[] GetOddsBelow100()
        {
            var list = new List<int>();
            for (int i = 1; i < 100; i++)
            {
                if (i %2 != 0)
                {
                    list.Add(i);
                }
                

            }
            return list.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words. Length; i++)
            {
                words[i] = words[i].ToUpper();

            }
        }
    }
}
