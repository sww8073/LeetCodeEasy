using System.Collections.Generic;

namespace LeetCodeEasy
{
    public class fizzBuzz
    {
        public IList<string> FizzBuzz(int n)
        {
            IList<string> fizzList = new List<string>();
            var counter = 1;
            while (counter <= n)
            {
                if (counter % 3 == 0 & counter % 5 == 0)
                {
                    fizzList.Add("FizzBuzz");
                }
                else if (counter % 3 == 0 & counter % 5 != 0)
                {
                    fizzList.Add("Fizz");
                }
                else if (counter % 3 != 0 & counter % 5 == 0)
                {
                    fizzList.Add("Buzz");
                }
                else
                {
                    fizzList.Add(counter.ToString());
                }

                counter++;
            }

            return fizzList;
        }
    }
}