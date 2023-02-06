using System;

namespace DayTimeGroups
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Group[] groups = new Group[0];
            Group grup = new Group();


            string op;
            do
            {
                Console.WriteLine("1: Yeni qrup yarat");
                Console.WriteLine("2: Qruplara bax");
                Console.WriteLine("3: Type deyerine gore qruplara bax");
                Console.WriteLine("4: Bugunki tarixe qeder başlamış qruplara bax");
                Console.WriteLine("5: Son 2 ayda başlamış qruplara bax");
                Console.WriteLine("6: Bu ayın sonunadək yeni başlayacaq olan qruplara bax");
                Console.WriteLine("7: Verilmiş 2 tarix aralığnda başlamış olan qruplara bax");
                Console.WriteLine("0: Menudan cix");



                Console.WriteLine("\nEmeliyyat daxil edin: ");
                op = Console.ReadLine();

                switch (op)
                {
                    case "1":
                        Console.WriteLine("1: Yeni qrup yarat");

                        Console.WriteLine("No daxil et: ");
                        string noGroup = Console.ReadLine();


                        Console.WriteLine("StartDate daxil edin:");
                        string startdDatestr = Console.ReadLine();
                        DateTime startDate = Convert.ToDateTime(startdDatestr);



                        Console.WriteLine("Type daxil et: ");

                        string typeStr;
                        byte typeByte;
                        do
                        {
                            foreach (var item in Enum.GetValues(typeof(GroupTypes)))
                            {
                                Console.WriteLine($"{(byte)item} - {item}");
                            }
                            typeStr = Console.ReadLine();
                            typeByte = Convert.ToByte(typeStr);

                        } while (!Enum.IsDefined(typeof(GroupTypes), typeByte));

                        GroupTypes typ = (GroupTypes)typeByte;


                        Group newGr = new Group
                        {
                            No = noGroup,
                            Type = typ,
                            StartDate = startDate

                        };

                        Array.Resize(ref groups, groups.Length + 1);
                        groups[groups.Length - 1] = newGr;


                        break;

                    case "2":
                        foreach(var item in groups)
                        {
                            item.ShowInfo();
                        }
                        break;

                    case "3":
                        Console.WriteLine("Type daxil edin: ");


                        foreach (var item in Enum.GetValues(typeof(GroupTypes)))
                        {
                            Console.WriteLine($"{(byte)item} - {item}");
                        }
                        string typestr = Console.ReadLine();
                        byte typebyte = Convert.ToByte(typestr);
                        GroupTypes type = (GroupTypes)typebyte;
                        

                        foreach (var item in groups)
                        {
                            if(item.Type == type)
                            {
                                item.ShowInfo();

                            }
                        }
                            break;

                    case "4":
                        Console.WriteLine("4: Bugunki tarixe qeder bashlamish qruplara bax");
                        foreach(var item in groups)
                        {
                            if(item.StartDate < DateTime.Now)
                            {
                                item.ShowInfo();

                            }
                        }

                        break;

                    case "5":
                        Console.WriteLine("Son 2 ayda başlamış qruplara bax");


                        foreach (var item in groups)
                        {
                            var last2Month = DateTime.Now.AddMonths(-2);
                            if (item.StartDate < DateTime.Now && item.StartDate > last2Month)
                            {
                                item.ShowInfo();

                            }

                        }

                        break;

                    case "6":
                        Console.WriteLine("6: Bu ayın sonunadək yeni başlayacaq olan qruplara bax");

                        foreach(var item in groups)
                        {
                            if (item.StartDate > DateTime.Now && item.StartDate < item.StartDate.AddMonths(1))
                            {
                                item.ShowInfo();
                            }
                        }

                        break;

                    case "7":
                        Console.WriteLine("7: Verilmiş 2 tarix aralığnda başlamış olan qruplara bax");

                        Console.WriteLine("Ilk date elave edin: ");
                        var firstDate = Convert.ToDateTime(Console.ReadLine());

                        Console.WriteLine("Ikinici date elave edin: ");
                        var secondDate = Convert.ToDateTime(Console.ReadLine());

                        foreach(var item  in groups)
                        {
                            if(item.StartDate > firstDate && item.StartDate < secondDate)
                            {
                                item.ShowInfo();
                            }
                        }

                        break;

                    case "0":
                        Console.WriteLine("Eminsinizmi? y/n");
                        string answer = Console.ReadLine();

                        if(answer == "y")
                        {
                            op = "0";
                            Console.WriteLine("Emeliyyat bitdi.");
                        }
                        else
                        {
                            op = "-1";
                        }
                        break;

                    default:
                        Console.WriteLine("Yalnish secim edildi.");
                        break;

                }


            } while (op != "0");


            
                




            

        }
    }
}
