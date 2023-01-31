namespace Abstraction.Task2.Vehicle
{
    class Program
    {
        static void Main(string[] atgs)
        {
            Car auto1 = new Car();

            auto1.FuelForkm = 1;
            auto1.CurrentFuel = 30;
            auto1.Drive(24);

            Console.WriteLine(auto1.Milage);
            Console.WriteLine(auto1.CurrentFuel);


        }
    }
}
