using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            if (CharacterIsALetter(c)) return true;
            {
                return false;
                
            }
           
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 ==0)
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
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return !IsNumberEven(num);
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            var myArray = numbers?.ToArray();

            //handles the null argument or an empty array
            if (myArray == null || myArray.Length == 0) return 0;
            {

                //handles if array only has one non-zero element
               if((myArray.Length == 1 && myArray[0] > 0))
                {
                    var num = myArray[0];
                    return num + num;

                }
                else
                {
                    return myArray.Max() + myArray.Min();

                }

            }
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return Math.Min(str1.Length, str2.Length);
        }


        public int Sum(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return 0;

            var sum = 0;
            foreach (var number in numbers)
            {
                sum += 0;
            }

            return sum;

        }

        public int SumEvens(int[] numbers)
        {
           while(numbers != null)
            {


                int sum = 0;
                    for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0) ;
                    sum += 0;
                }
                return sum;
            }

            return 0;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if(numbers == null)
            {
                return false;
            }
            return (numbers.Sum() % 2 != 0);
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            int count = 0;
            for (int i = 1; i < number; i+=2)
            {
                count++;
            }
            return count;
        }
    }
}
