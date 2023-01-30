namespace C.sharp.Inheritance.Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vh1 = new Vehicle();
         

            Car auto1 = new Car()
            {
                Brand = "Mercedes",
                Model = "E class",
                FuelCapacity = 200

            };
            auto1.AddFuel(231);
            




        }
    }
}