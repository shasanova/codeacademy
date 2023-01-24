
using static System.Runtime.InteropServices.JavaScript.JSType;
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1. Verilmiş a,b,c ədədləri üzərindən ən kiçiyini tapan program
            //int a = 5;
            //int b = 33;
            //int c = 1;

            //if (a < b)
            //{
            //    if (a < c)
            //    {
            //        Console.WriteLine(a);
            //    }
            //    else
            //    {
            //        Console.WriteLine(c);
            //    }
            //}
            //else if (b < c)
            //{
            //    Console.WriteLine(b);
            //}
            //else
            //{
            //    Console.WriteLine(c);
            //}


            // 2. Verilmiş ədədlər siyahısındaki ən böyük ədədi tapan proqram

            //int[] array = { 1, 5, 2, 7, 6, 8, 12 };
            //int max = array[0];

            //for(int i = 1;i < array.Length; i++)
            //{
            //    if (array[i] > max)
            //    {
            //        max = array[i];

            //    }
            //}
            //Console.WriteLine(max);


            //3. Verilmiş ədədlər siyahısındaki 3 - ə bölünən ədədlərin ədədi ortaslnl(ortalamasını) tapan proqram

            //int[] nums = { 1, 5, 2, 7, 6, 8, 12 };
            //int countOfDivisors = 0;
            //int sumOfDivisors = 0;

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] % 3 == 0)
            //    {
            //        sumOfDivisors += nums[i];
            //        countOfDivisors++;
            //    }

            //}
            //if (countOfDivisors == 0)
            //{
            //    Console.WriteLine("3-e bolunen eded yoxdur");
            //}

            //else
            //{
            //    Console.WriteLine(sumOfDivisors / countOfDivisors);
            //}

            //4. Verilmiş ədədlər siyahısında 3 rəqəmli ədəd olub olmadığını tapan alqoritm

            int[] numbers = { 1, 5, 21, 7, 644, 8, 123 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] < 1000 && numbers[i] > 99)
            //    {
            //        Console.WriteLine("3 ededli reqem var");
            //    }
            //    else
            //    {
            //        Console.WriteLine("3 ededli reqem yoxdur");
            //    }
            //}

            int[] numbers = { 1, 5, 21, 7, 644, 8, 123 };

            bool found3Digits = false;
            int remCounter = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int num = numbers[i];
                while (num > 0)
                {
                    num /= 10;
                    remCounter++;
                }
                if (remCounter == 3)
                {
                    found3Digits = true;
                    break;
                }
            }

            if (remCounter == 3)
            {
                Console.WriteLine("3 ededli reqem var");
            }
            else
            {
                Console.WriteLine("3 ededli reqem yoxdur");
            }














































        }
    }
}