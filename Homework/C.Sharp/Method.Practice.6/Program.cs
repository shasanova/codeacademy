using System;
using System.Diagnostics.Metrics;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {


            //Verilmis yazinin ad olub olmadigin goster. Ad ilk herfi boyuk qalanlari kicik olandir.
            var name = "Sabina";
            Console.WriteLine(IsName(name));


            //Verilmis fullname siyahisindan ancaq names olan siyahi qaytar.
            string[] fullnames = { "  Sabina Hasanova ", "Ali Abbasov", "Hasan Aliyev" };
            var res = MakeNames(fullnames);
            foreach (var i in res)
            {
                Console.WriteLine(i);
            }



            ////Verilmis string arrayin icerisindeki tekrarlanmayan deyerlerden ibaret yeni bir array qaytarn metod.
            string[] words = { "alma", "armud", "kivi", "alma", "heyva", "banan", "kivi" };
            var check = MakeUnique(words);
            foreach (var i in check)
            {
                Console.WriteLine(i);
            }



            //Verilmis yazini bas herfi boyuk, digerleri ise kicik adla qaytaran metod.
            Console.WriteLine(Capitalize("hikMet"));



            //Console-dan ad daxil edilmesi istenilir. eger daxil edilen ifade ada uygun deyilse yeniden daxil et,
            //bas herfi boyuk digerleri kicik olmalidir.
            string nameInput;
            do
            {
                Console.WriteLine("Enter your name: ");
                nameInput = Console.ReadLine();

            } while (!IsName(nameInput));



            //emailin domainin gotursun kesib.sonunu
            var email = "asd.sd.@outlook.com";
            var domain = GetDomain(email);
            Console.WriteLine(domain);




            //Verilmiş yazıda rəqəm olub olmadığını tapan metod
            Console.WriteLine(IsDigit("salam1"));




            //Verilmiş yazının fullname olub olmadığını tapan metod
            Console.WriteLine(FullName("   Sabina Hasanova"));



            //Verilmiş ədədlər siyahısından yeni bir array düzəldib qaytaran metod.
            int[] number = { 1, 2, 3, 4, 1, 5, 2 };
            var check = NoDuplicates(number);
            for (int i = 0; i < check.Length; i++)
            {
                Console.WriteLine(check[i]);
            }


            //Verilmiş yazının içindəki cümlələrin sayını tapan metod.
            string sentences = "Salam Baki. Code Academy P231.";
            var result = Count(sentences);
            Console.WriteLine(result);



            //Verilmiş email - lər siyahısından domainlər siyahısı düzəldən metod.Domainlər arrayondə təkrarlanmamlıdır domainlər!
            string[] email = { "sd.dee@gmail.com", "ejd.cj@outlook.com", "ew.cd.@yandex.ru", "sfd.rf@gmail.com" };
            var domainsOnly = Domains(email);
            foreach (var i in domainsOnly)
            {
                Console.WriteLine(i);
            }



        }
        //Verilmiş email-lər siyahısından domainlər siyahısı düzəldən metod.
        static string[] Domains(string[] emails)
        {
            string[] onlyDomains = new string[emails.Length];
            string[] uniquie = new string[0];
            for (int i = 0; i < emails.Length; i++)
            {
                var cut = emails[i].Substring(emails[i].IndexOf('@') + 1);
                onlyDomains[i] = cut;
            }
            for (int i = 0; i < onlyDomains.Length; i++)
            {
                if (Array.IndexOf(uniquie, onlyDomains[i]) == -1)
                {
                    Array.Resize(ref uniquie, uniquie.Length + 1);
                    uniquie[uniquie.Length-1] = onlyDomains[i];
                }
            }
            return uniquie;
                

        }



        //Verilmiş yazının içindəki cümlələrin sayını tapan metod.
        static int Count(string sentence)
        {
            string trimm = sentence.TrimStart();
            string[] splittedStrings = sentence.Split('.');
            return splittedStrings.Length-1;

        }




        //emailin domainin gotursun kesib.sonunu
        static string GetDomain(string email)
        {
            var cut = email.Substring(email.IndexOf('@') + 1);
            return cut;
        }



        //Verilmiş ədədlər siyahısından yeni bir array düzəldib qaytaran metod.
        //Yeni arrayə elementlər təkrarlanmamaq şərti ilə yerləşdirilsin.
        static int[] NoDuplicates(int[] numbers)
        {
            int[] newArr = new int[0];
            for(int i =0; i < numbers.Length; i++)
            {
                if(Array.IndexOf(newArr, numbers[i])== -1)
                {
                    Array.Resize(ref newArr, newArr.Length + 1);
                    newArr[newArr.Length - 1] = numbers[i];
                }
            }
            return newArr;
        }



        //Verilmiş yazının fullname olub olmadığını tapan metod
        //(fullname olması üçün iki sozdən ibarət olmalıdır və hər bir söz böyük hərflə başlayıb kiçik hərflərlə davam etməlidir)
        static bool FullName(string name)
        {
            
            var trimmed = name.TrimStart();
            string[] splitted = trimmed.Split(' ');
            if (splitted.Length == 2)
            {
                for (int i = 0; i < splitted.Length; i++)
                {
                    if (! IsName(splitted[i]))
                    {
                        return false;
                           
                    }
                }

            }
            return true;
            
        }




        //Verilmiş yazıda rəqəm olub olmadığını tapan metod
        static bool IsDigit(string word1)
        {
            for(int i = 0; i < word1.Length; i++)
            {
                if (char.IsDigit(word1[i]))
                {
                    return true;
                }
            }
            return false;
        }










        










        //Verilmis yazini bas herfi boyuk, digerleri ise kicik adla qaytaran metod.
        static string Capitalize(string word)
        {
            return char.ToUpper(word[0]) + word.Substring(1).ToLower();
        }










        //Verilmis string arrayin icerisindeki tekrarlanmayan deyerlerden ibaret yeni bir array qaytarn metod.

        static string[] MakeUnique(string[] fruits)
        {
            string[] uniques = new string[0];
            for (int i = 0; i < fruits.Length; i++)
            {
                if(Array.IndexOf(uniques, fruits[i]) == -1)
                {
                    Array.Resize(ref uniques, uniques.Length + 1);
                    uniques[uniques.Length-1] = fruits[i];


                }


            }
            return uniques;
        }









        //Verilmis fullname siyahisindan ancaq names olan siyahi qaytar.
        static string[] MakeNames(string[] arr)
        {
            string[] names = new string[arr.Length];
            for(int i = 0; i < arr.Length; i++)
            {
                var trimmed = arr[i].TrimStart();
                var name = trimmed.Substring(0,trimmed.IndexOf(' '));
                names[i] = name;
            }
            return names;   
        }







        //Verilmis yazinin ad olub olmadigin goster. Ad ilk herfi boyuk qalanlari kicik olandir.
        static bool IsName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return false;
            }
            if (!char.IsUpper(name[0]))
            {
                return false;
            }
            for (int i = 1; i < name.Length; i++)
            {
                if (! char.IsLower(name[i]) )
                {
                    return false;

                }
            }
            return true;


        }
    }
}   