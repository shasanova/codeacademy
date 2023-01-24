
using System;
using System.Diagnostics.Metrics;
using System.Linq;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {




            string name = "Ali";
            Console.WriteLine(name.ToLower());
            Console.WriteLine(name);


            ////C# Char Methods
            string name1;
            do
            {
                Console.WriteLine("Enter your name: ");
                name1 = Console.ReadLine();
            } while (!char.IsUpper(name1[0]));


            Console.WriteLine(char.IsDigit('1'));
            Console.WriteLine(char.IsUpper('s'));
            Console.WriteLine(char.IsLetterOrDigit('1'));
            Console.WriteLine(char.ToLower('H'));




            //C# String Methods
            String a = "World";
            String b = (string)a.Clone();
            Console.WriteLine(b);
            Console.WriteLine(a.Equals(b));

            string name = "sabina";
            string surname = "hasanova";
            Console.WriteLine(name.CompareTo(surname));
            Console.WriteLine(name.Contains("nina"));
            Console.WriteLine(surname.EndsWith("a"));
            Console.WriteLine(name.Equals(surname));
            Console.WriteLine(surname.IndexOf('s'));
            Console.WriteLine(name.ToUpper());

            string word = "Code Academy";
            Console.WriteLine(word.Insert(12, "s"));
            Console.WriteLine(word.LastIndexOf('C'));
            Console.WriteLine(word.Replace('d', 'a'));


            string word1 = "HEllo World";
            var wrd = word1.Substring(2, 2);
            Console.WriteLine(wrd);
            string n = "World";
            Console.WriteLine(n.Remove(2));

            //Ilk bosluga kimi kes.
            string world = "Hello World again";
            Console.WriteLine(world.Substring(0, world.IndexOf(' ')));
            //ilk bolsuqdan axira kimi olani kes.
            Console.WriteLine(world.Substring(world.IndexOf(' ') + 1));

            string m = "   Code Academy P231   ";
            Console.WriteLine(m.TrimStart());
            Console.WriteLine(m.TrimEnd());
            Console.WriteLine(m.Trim());
            Console.WriteLine(m.ToCharArray());
            Console.WriteLine(m.Insert(0, "A"));
            Console.WriteLine(m.Replace('C', 'B'));

            string s = "salam";
            string f = "Baku";
            Console.WriteLine(string.Concat(s, f));
            Console.WriteLine(f.StartsWith("Bak"));
            Console.WriteLine(s.EndsWith("lam"));

            string sentence = "Code Academy Course";
            string[] splited = sentence.Split(" ");
            foreach (var i in splited)
            {
                Console.WriteLine(i);
            }

            string counts = "One, Two, Three, Four";
            var splited1 = counts.Split(",");
            var joined = String.Join(" + ", splited1);
            Console.WriteLine(joined);




            ////C# Array Methods
            int[] numbers = { 1, 2, 5, 48, 4 };
            var indx = Array.IndexOf(numbers, 4);
            Console.WriteLine(indx);
            Array.Sort(numbers);
            Array.Reverse(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }


            int[] nums = { 1, 23, 34 };
            Array.Clear(nums, 0, 2);
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }


            ////REFERANCE ve OUT ile METHOD.

            ////Verilmis ededi 10 vahid artiran metod.
            int numb = 60;
            AddTen(ref numb);
            Console.WriteLine(numb);


            ////Gonderilmis deyer menfidirse 0, 100-den coxdursa 100 versin.
            ////0-100 araligindadirsa oldugu kimi qalsin.
            var numm = 33;
            CorrectPoint(ref numm);
            Console.WriteLine(numm);


            //////Verilen ededler siyahisini ancaq cut ededler qalan yeni arraye cevir.
            var arr = new int[] { 1, 33, 22, 9, 66, 3, 11, 46 };
            MakeEven(ref arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }






            //////Verilmiş int array-ə verilmiş int dəyəri əlavə edən metod
            var arr1 = new int[] { 1, 33, 22, 11 };
            var num = 5;
            AddNum(ref arr1, ref num);

            foreach (var item in arr1)
            {
                Console.WriteLine(item);
            }




            ////Verilmiş int array-ə verilmiş int dəyəri əlavə edən metod
            int[] numss = { 1, 2, 3};
            int num1 = 5;

                UpdateArray(ref numss, ref num1);

                foreach (var item in numss)
                    Console.WriteLine(item);
            

            
        }
        ////Verilmiş int array-ə verilmiş int dəyəri əlavə edən metod
        public static void UpdateArray(ref int[] arr, ref int num)
        {
            int l = arr.Length;
            int[] newArr = new int[l+1];
            
            for (int i = 0; i<arr.Length; i++)
            {

                newArr[i] = arr[i];
                
            }
            newArr[l] = num;
            arr = newArr;


        }



        ////Verilmiş int array-ə verilmiş int dəyəri əlavə edən metod
        static void AddNum(ref int[] arr, ref int num)
        {
            arr = arr.Append(num).ToArray();

        }





        ////Verilen ededler siyahisini ancaq cut ededler qalan yeni arraye cevir.
        static void MakeEven(ref int[] arr)
        {
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    count++;
                }
            }
            int[] newArr = new int[count];
            int j = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    newArr[j] = arr[i];
                    j++;
                }
            }
            arr = newArr;
        }






        //// //Gonderilmis deyer menfidirse 0, 100-den coxdursa 100 versin.
        //// //0-100 araligindadirsa oldugu kimi qalsin
        static void CorrectPoint(ref int point)
        {
            if (point < 0)
            {
                point = 0;
            }
            else if (point > 100)
            {
                point = 100;
            }

        }

        //////Verilmis ededi 10 vahid artiran metod
        static void AddTen(ref int num)
        {
            num += 10;
        }




















    }
}
