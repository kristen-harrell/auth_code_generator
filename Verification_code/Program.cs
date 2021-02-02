using System;
using System.Text;

namespace Verification_code
{
    class Program
    {
        static void Main(string[] args)
        {

            int stringLength = 6;
            var stringBuilder = new StringBuilder();

            for (int i = 0; i < stringLength; i++)
            {
                Random random = new Random();
                string num = random.Next(0, 10).ToString();
                char alpha = (char)random.Next('a', 'z'); //if I make the set 'A', 'z' to try to incl. caps and lower, I get special char too
                if (random.Next() % 2 == 0)
                {
                stringBuilder.Append(num);
                }
                else
                {
                stringBuilder.Append(alpha);
                }
            }
            string code = stringBuilder.ToString();
            Console.WriteLine(code);

        }
    }
}
