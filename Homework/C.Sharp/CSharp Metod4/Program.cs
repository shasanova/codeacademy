using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Find a given string in the given array
            string[] words = { "Ali", "Sabina", "Gul", "Sarah" };
            var check = FindWord(words, "Gul");
            Console.WriteLine(check);



            //Find a given num  in the given array
            int[] numbers = { 1, 2, 55, 3, 6, 5, 7, 544, 76, 7898 };
            var findNum = FindNum(numbers, 6);
            Console.WriteLine(findNum);


            ////Find a num
            int[] numList = { 1, 2, 55, 3, 6, 5, 7, 544, 76, 7898 };
            int[] secondList = { 12, 44, 35, 3 };
            var res = Find(numList, secondList);
            Console.WriteLine(res);


            ////Is a given char a digit  
            var charCheck = IsDigit('i');
            Console.WriteLine(charCheck);


            ////Is there a digit in a given string
            var result = CharInString("sa3lam");
            Console.WriteLine(result);


            ////check the index of a given char in the given string
            var check1 = CheckIndex("Hello", 'm');
            Console.WriteLine(check1);



            ////Cut  the string till the given index
            var substringg = SubString("Salam World", 5);
            Console.WriteLine(substringg);



            //Layihe ise dusdukce Console-dan email deyeri daxil etmeyinizi istesin.
            //Eger email-da @ simvolu yoxdursa yeniden daxil etmeynizi istesin.

            string email = "";
            do
            {
                Console.WriteLine("Email daxil edin: ");
                email = Console.ReadLine();
            } while (CheckIndex(email, '@') == -1);


            ////Verilmiş string dəyərindəki ilk sözü tapan metod(ilk söz ilk boşluğa qədərki ifadədir)
            var checkk = FirstWord("Hello World");
            Console.WriteLine(checkk);


            ////Verilmiş string dəyərindəki sözlərin sayını tapan metod.
            var check2 = CountOfString("Hello World it is me");
            Console.WriteLine(check2);


            ////Verilmiş yazılar siyahısında neçə yazıda rəqəm olduğunu qaytaran metod
            string[] names = { "Ali", "Sabina", "1Gul", "Sarah3" };
            var digits = Digits(names);
            Console.WriteLine(digits);


            ////Verilmiş yazını sol tərəfində boşluq olmayan vəziyyətdə qaytaran metod
            var result1 = NoSpaceInString("     Sabina Hasanova ");
            Console.WriteLine(result1);


            //Verilmiş yazıdaki ilk boşluq olmayan index-i qaytaran metod.
            //Misalçun "  Salam" yazısında S ilk boşluq olmayan char-dır.
            var ress = FirstChar("  Hello");
            Console.WriteLine(ress);

        }




        ////Verilmiş yazını sol tərəfində boşluq olmayan vəziyyətdə qaytaran metod
        static string NoSpaceInString(string word)
        {

            string updated = "";
            bool foundspace = false;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] != ' ')
                {
                    foundspace = true;
                    updated += word[i];
                }
                if (foundspace && word[i] == ' ')
                {
                    updated += word[i];
                }
            }
            return updated;


        }




        //Verilmiş yazıdaki ilk boşluq olmayan index-i qaytaran metod.
        //Misalçun "  Salam" yazısında S ilk boşluq olmayan char-dır.

        static char FirstChar(string stri)
        {
            for (int i = 0; i < stri.Length; i++)
            {
                if (stri[i] != ' ')
                {
                    return stri[i];
                }

            }
            return ' ';

        }



        //Verilmiş yazılar siyahısında neçə yazıda rəqəm olduğunu qaytaran metod
        static int Digits(string[] arr)
        {
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (CharInString(arr[i]))
                {
                    counter++;
                }
            }
            return counter;

        }



        //Verilmiş string dəyərindəki sözlərin sayını tapan metod.
        //boşluqlarla ayrılan bütün ifadələri söz kimi nəzərə alın
        static int CountOfString(string gword)
        {
            int count = 1;
            int i = 0;
            ; while (i <= gword.Length - 1)
            {
                if (gword[i] == ' ')
                {
                    count++;

                }
                i++;
            }
            return count;

        }


        //Verilmiş string dəyərindəki ilk sözü tapan metod(ilk söz ilk boşluğa qədərki ifadədir)

        static string FirstWord(string givenWord)
        {
            string first = "";
            for (int i = 0; i < givenWord.Length; i++)
            {
                if (givenWord[i] != ' ')
                {
                    first += givenWord[i];

                }
                else
                {
                    break;
                };
            }
            return first;
        }




        //Cut  the string till the given index
        static string SubString(string word1, int indx)
        {
            string newString = "";
            for (int i = 0; i < indx; i++)
            {
                newString += word1[i];

            }
            return newString;
        }



        //check the index of a given char in the given string
        static int CheckIndex(string word, char cr)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (cr == word[i])
                {
                    return i;
                }
            }
            return -1;

        }




        //Is there a digit in a given string
        static bool CharInString(string str)
        {
            //char[] digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            for (int i = 0; i < str.Length; i++)
            {
                if (IsDigit(str[i]))
                {
                    return true;
                }

            }
            return false;
        }




        //Is a given char a digit  
        static bool IsDigit(char ch)
        {

            char[] digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            for (int i = 0; i < digits.Length; i++)
            {
                if (ch == digits[i])
                {
                    return true;
                }
            }
            return false;

        }



        ////Find a num of one list in another one
        static bool Find(int[] numList, int[] secondList)
        {
            for (int i = 0; i < numList.Length; i++)
            {
             
                if (FindNum(numList, secondList[i]))
                {
                    return true;
                }
            }
            return false;

        }



        //////Find a given num  in the given array
        static bool FindNum(int[] numbers, int num)
        {

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == num)
                {
                    return true;
                }
            }
            return false;

        }



        //////Find a given string in the given array
        static bool FindWord(string[] words, string word)
        {

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == word)
                {
                    return true;
                }
            }
            return false;

        }
















    }


}