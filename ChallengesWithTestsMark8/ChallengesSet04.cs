using System;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {

            //return numbers.Where( n => n % 2 == 0). Sum() - numbers.Where( n => n % 2 !=0).sum();

            int sum = 0;
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    sum += number;
                }
                else
                {
                    sum -= number;
                }
            }
            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var strings = new string[] { str1, str2, str3, str4 };
            return strings.Min(strings => strings.Length);
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            return new int[] {number1, number2, number3, number4}.Min();
            //return Math.Min(number 1, Math.Min(number 2, Math.Min(number 3, number 4)));
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return sideLength1 + sideLength2 > sideLength3
                && sideLength1 + sideLength3 > sideLength2
                && sideLength2 + sideLength3 > sideLength1;

        }

        public bool IsStringANumber(string input)
        {
            return double.TryParse(input, out var throwaway);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            bool isMajority = false;
            int isNull = 0;
            int notNull = 0;
            foreach (var obj in objs)
            {
                if (obj is null)
                {
                    isNull++;
                }
                else
                {
                    notNull++;
                }
            }
            isMajority = isNull > notNull;
            return isMajority;

            // return objs.Where( x => x == null).ToArray().Length > objs.Where(x => x != null).ToArray().Length;

        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) ;


            double sum = 0;
            double num = 0;
            foreach (var number in numbers)
            {
                if (number%2 ==0)
                {
                    sum += number;
                    num++;
                }
                

            }
            if (num == 0) return 0;

            return sum / num;
        }
        

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (number == 0)
            {
                return 1;
            }
            int ans = 1;
            for (int i = 1; i <= number; i++)
            {
                ans *= i;
            }
            return ans;
        }
    }
}
