using System;

namespace Compute_sum_of_two_values
{
    class Program
    {
        static float firstNum;
        static float secondNum;
        static float sumNum;
        static string sumOutput;

        static void Main()
        {
            Console.WriteLine("Type first number:");
            firstNum = float.Parse(Console.ReadLine());

            Console.WriteLine("Type second number:");
            secondNum = float.Parse(Console.ReadLine());

            CalcSum();
        }

        static void CalcSum()
        {
            if (firstNum == secondNum)
            {
                sumNum = (firstNum + secondNum);
                sumOutput = ("The sum of "
                    + firstNum + " & "
                    + secondNum + " is "
                    + sumNum + ", x3 = "
                    + sumNum * 3
                    );

                Console.WriteLine(sumOutput);
            } else
            {
                sumOutput = ("The sum of "
                    + firstNum + " & "
                    + secondNum + " is "
                    + sumNum
                    );

                sumNum = (firstNum + secondNum);
                Console.WriteLine(sumOutput);
            }
        }
    }
}
