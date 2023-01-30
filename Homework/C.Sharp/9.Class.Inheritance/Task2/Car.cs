using System;
namespace C.sharp.Inheritance.Homework
{
	public class Car:Vehicle
	{
		public double FuelCapacity;
        public double CurrentFuel;


		public void AddFuel(double fuel)
		{
			do
			{
				AddFuel(fuel);

			} while (fuel <= FuelCapacity);

		}
    }
}

