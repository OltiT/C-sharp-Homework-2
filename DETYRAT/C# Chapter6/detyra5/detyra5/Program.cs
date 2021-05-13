using System;

namespace detyra5
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstN = 0, secondN = 1, thirdN = 0;

            Console.Write("Enter N: ");
            int length = Int32.Parse(Console.ReadLine());

            Console.Write("0, 1,");

            for (int i = 2; i < length; i++)
            {
                thirdN = firstN + secondN;
                Console.Write(" {0},", thirdN);
                firstN = secondN;
                secondN = thirdN;
            }
        }
    }
}
