namespace FB
{
    public class FizzBuzz
    {
        public static string solution(int i)
        {
            if (i < 1 || i > 100)
            {
                return "The number is not supported";
            }

            if (i % 15 == 0)
            {
                return "FizzBuzz";
            }

            if (i % 5 == 0)
            {
                return "Buzz";
            }

            if (i % 3 == 0)
            {
                return "Fizz";
            }

            return i.ToString();
        }
    }
  }
