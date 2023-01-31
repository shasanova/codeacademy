using System;
namespace Homework.Abstraction.Task2
{
	public class Samsung_A56:Telefon, IRing
	{
        int _ram;

        public int Ram
        {

          get => _ram;
          
        }


        double _size;
        public double Size

        {
            get => _size;

            
        }

        public override void Picksel()
        {
            Console.WriteLine("Samsung_A56 Picksel: 16");
        }

        void IRing.Ring()
        {
           Console.WriteLine("Samsung Melody");
        }
    }
}

