namespace Homework.Abstraction.Task2
{
    class Program
    {
        static void Main(string[] args)
        {

            Iphone14 tel14 = new Iphone14 { };
            tel14.Picksel();

            Samsung_A56 tel2 = new Samsung_A56();
            tel2.Picksel();


            Iphone_11 tel3 = new Iphone_11 { };

          
            Console.WriteLine(tel3.Ram);
            Console.WriteLine(tel3.Size);
            Console.WriteLine(tel14.Size);
            
        }
    }
}