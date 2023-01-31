using System;
namespace Homework.Abstraction.Task2
{
	public class Iphone14:Telefon,IRing
	{
        int _ram;

        public int Ram
        {

            get => _ram;

        }


        double _size =89;
        public double Size

        {
            get => _size;


        }

        public override void Picksel()
        {
            Console.WriteLine("Iphone_14 Picksel: 18");
        }

        void IRing.Ring()
        {
             Console.WriteLine("Iphone_14 Melody");
        }
    }
}

