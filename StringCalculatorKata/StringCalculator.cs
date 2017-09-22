using System;
using System.Linq;

namespace StringCalculatorKata
{
    public class StringCalculator
    {
        public int Add(string input)
        {
            if(string.IsNullOrEmpty(input))
                return 0 ;

            string[] numbers;
            if (input.StartsWith("//"))
            {
                var delim = input[2];
                numbers = input.Substring(4).Split(delim);
                foreach (var num in numbers)
                {
                    if (int.Parse(num) < 0)
                        throw new ArgumentOutOfRangeException();
                }
            }
            else
            {
                numbers = input.Split(',', '|', '.');
                foreach (var num in numbers)
                {
                    if (int.Parse(num) < 0)
                        throw new ArgumentOutOfRangeException();
                }
            }

            return numbers.Sum(int.Parse);
        }
    }
}