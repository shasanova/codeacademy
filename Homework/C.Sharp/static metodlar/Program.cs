using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {












            //Task 1:
            var check = SumOfDigits(131232);
            Console.WriteLine(check);


            //Task 2:
            var cem = Average(10, 100);
            Console.WriteLine(cem);



            //Task 3:
            var find = hasA("sabina");
            Console.WriteLine(find);




        }

        //Task 1 - Verilmiş N tam ədədinin rəqəmləri cəmini tapan metod
        static int SumOfDigits(int n)
        {
            int sum = 0;
            int reminder = 0;
            while (n > 0)
            {
                reminder = n % 10;
                n /= 10;
                sum += reminder;
            }
            return sum;



        }


        //Task 2 - Verilmiş M dəyərindən verilmiş N dəyərinədək 21-ə bölünən ədədlərin ədədi ortasını tapan metod
        static int Average(int a, int b)
        {

            int summ = 0;
            int count = 0;

            while (a < b)
            {
                if (a % 21 == 0)
                {
                    summ += a;
                    count++;

                }
                a++;
            }
            return summ / count;

        }



        //Task 3 - Verilmis yazıda a herfi olub olmadigini tapan metod

        static string hasA (string word)
        {
            bool found = false;
            char target = 'a';

            for(int i =0; i < word.Length; i++)
            {
                if (word[i]== target)
                {
                    found = true;
                    break;
                }

            }

            if (found == true)
            {
                return "a herfi movcuddur";
            }
            else
            {
                return "a movcud deyil";
            }
        }
    }


}