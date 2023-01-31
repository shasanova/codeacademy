using System;
namespace Abstraction.Task2.Vehicle
{
	public class Car:Vehicle
	{

        public override void Drive(double km)
        {
            Milage += km;
            CurrentFuel -= km *FuelForkm;

        }

        public double CurrentFuel;
		public double FuelForkm;




	}
}

