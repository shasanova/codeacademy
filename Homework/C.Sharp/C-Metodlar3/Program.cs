using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Security.Cryptography;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reverse a string
            var result = ReverseString("Salam");
            Console.WriteLine(result);




            //Verilmiş yazıda rəqəm olub olmadığını tapan metod

            var check = hasDigit("salam");
            Console.WriteLine(check);



            //Verilmiş ədədlər siyahısındaki ədədlərdən ən kiçiyini tapan metod

            int[] list = { 33, 5, 3, 1, 34, 7 };
            var findMin = FindMin(list);
            Console.WriteLine(findMin);




            //Verilmiş yazıda verilmiş chardan neçə ədəd olduğunu tapan metod

            var findChar = FindCountOfChars("salamlar", 'a');
            Console.WriteLine(findChar);



            //Indexi tap
            int[] numberList = { 33, 5, 3, 1, 34, 7 };
            var res = FindIndex(numberList, 0);
            Console.WriteLine(res);



        }



        //Indexi tap
        static int FindIndex(int[] numberList, int num)
        {

            for (int i = 0; i < numberList.Length; i++)
            {

                if (num == numberList[i])
                {
                    return i;
                }
            }
            return -1;
        }





        //Verilmiş yazıda verilmiş chardan neçə ədəd olduğunu tapan metod


        static int FindCountOfChars(string word1, char ch)
        {
            int count = 0;

            for (int i = 1; i < word1.Length; i++)
            {
                if (word1[i] == ch)
                {
                    count++;
                }
            }

            return count;

        }





        //Verilmiş ədədlər siyahısındaki ədədlərdən ən kiçiyini tapan metod

        static int FindMin(int[] list)
        {
            int min = list[0];
            for (int i = 1; i < list.Length; i++)
            {
                if (list[i] < min)
                {
                    min = list[i];
                }
            }
            return min;
        }





        //Verilmiş yazıda rəqəm olub olmadığını tapan metod

        static bool hasDigit(string str)
        {


            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '0' || str[i] == '1' || str[i] == '2' || str[i] == '3' || str[i] == '4' || str[i] == '5' || str[i] == '6' || str[i] == '7' || str[i] == '8' || str[i] == '9')
                {
                    return true;
                }
            }
            return false;

        }



        //Reverse a string
        static string ReverseString(string word)
        {

            string newWord = "";

            for (int i = word.Length - 1; i >= 0; i--)
            {
                newWord += word[i];
            }
            return newWord;
        }

        









    }


}