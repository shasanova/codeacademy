using System;
namespace Homework.Abstraction.Task2
{
	public class Iphone_11:Telefon,IRing
	{
        int _ram= 365;

        public int Ram
        {

            get => _ram;

        }


        double _size = 12;
        public double Size

        {
            get => _size;


        }

        public override void Picksel()
        {
            Console.WriteLine("Iphone_11 Picksel: 8");
        }

        public void Ring()
        {
            Console.WriteLine("melody name: Music1");
        }
    }
}

