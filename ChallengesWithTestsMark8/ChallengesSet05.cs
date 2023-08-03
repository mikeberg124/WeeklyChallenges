using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            startNumber++;
            while (startNumber % n != 0) ;
            {
                startNumber++;
            }
            return startNumber;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (var business in businesses)
            {
                if (business.TotalRevenue == 0)
                {
                    business.Name = "Closed";
                }

            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if(numbers == null || numbers.Length == 0)
            {
                return false;
            }
            var numOrdered = numbers.OrderBy(x => x).ToArray();
            return (numOrdered.SequenceEqual(numbers));
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            int sum = 0;
            if (numbers == null)
            {
                return 0;
            }
            for (int i = 0; i< numbers.Length -1; i++)
            {
                if (numbers[1] %2 == 0)
                {
                    sum += numbers[i + 1];
                }

            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null) return "";

            var realWords = words.Where(word => word != "" && word != " ").ToArray();

            if (realWords.Length == 0) return "";

            return realWords.Aggregate((sentence, next) => sentence.Trim() + " " +
            next.Trim()) +".";
            
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            List<double> list = new List<double>();
            if (elements == null || elements.Count == 0)
            {
                return list.ToArray();
            }
            for (int i = 0; i < elements.Count; i+= 4)
            {
                list.Add(elements[i]);
            }
            return list.ToArray();

        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int x = 0; x < nums.Length; x++)
                {
                    if (nums[i] + nums[x] == targetNumber)
                    {
                        return true;
                    }
                }

            }
            return false;
        }
    }
}
