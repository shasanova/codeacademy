using System.Linq;

namespace Task3.Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[0];

            string op;
            do
            {
                Console.WriteLine("1. Butun tələbələrə bax");
                Console.WriteLine("2. Tələbələr üzrə axtarish et");
                Console.WriteLine("3. Tələbə əlavə et");
                Console.WriteLine("0. Menudan cix");


                Console.WriteLine("Emeliyyat daxil edin.");
                op = Console.ReadLine();

                switch (op)
                {
                    case "1":
                        foreach (var item in students)
                        {
                            Console.WriteLine($"Fullname: {item.Fullname}, GroupNumber: {item.GroupNo}");
                            
                        }
                        break;


                    case "2":
                        {
                            Console.WriteLine("Axtarilan Fullname: ");
                            string wantedFullname = Console.ReadLine();

                            Console.WriteLine("Axtarilan Group number: ");
                            string wantedGroupNumber = Console.ReadLine();

                            foreach (var item in students)
                            {
                                if (item.Fullname.Contains(wantedFullname) || item.GroupNo.Contains(wantedGroupNumber))
                                {
                                    Console.WriteLine($"Fullname: {item.Fullname}, GroupNumber: {item.GroupNo}");

                                }
                            }
                            break;
                        }
                    case "3":
                        {
                            string fullName;

                            do
                            {
                                Console.WriteLine("Enter fullname: ");
                                fullName = Console.ReadLine();
                            } while (hasDigit(fullName));


                            string groupNo;
                            do
                            {
                                Console.WriteLine("Enter group number: ");
                                groupNo = Console.ReadLine();
                            } while (!IsGroup(groupNo));

                            Array.Resize(ref students, students.Length + 1);

                            Student newStudent = new Student
                            {
                                Fullname = fullName,
                                GroupNo = groupNo


                            };
                            students[students.Length - 1] = newStudent;

                            break;
                        }
                    case "0":
                        {
                            op = "-1";
                            Console.WriteLine("Eminmisiniz? Yes/No");
                            string ask = Console.ReadLine();
                            if(ask == "Yes")
                            {
                                op = "0";
                            }
                            break;

                        }
                }

                

            } while (op != "0");

        }


        static bool IsGroup(string word)
            {
                if (char.IsUpper(word[0]) && word.Length == 4)
                {
                    for (int i = 1; i < word.Length; i++)
                    {
                        if (!char.IsDigit(word[i]))
                        {
                            return false;
                        }
                    }
                    return true;
                }
                return false;

            }

            static bool hasDigit(string name)
            {
                for (int i = 0; i < name.Length; i++)
                {
                    if (char.IsDigit(name[i]))
                    {
                        return true;
                    }
                }
                return false;
            }
        }
    }