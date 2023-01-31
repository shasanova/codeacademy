using System;
namespace Abstraction.Task2.Vehicle
{
	public class Bike:Vehicle
	{
        public override void Drive(double km)
        {
            Milage += km;
        }


    }
}

