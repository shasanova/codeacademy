using System;
using System.Xml.Linq;

namespace Polymorphism__casting__boxin_unboxing
{
	public class Product
	{

        public string Name;
        public double Price;
        public int No;

		private static int _totalNumber;


        public Product()
		{
			_totalNumber++;
			No = _totalNumber;

		}

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}, Price: {Price}");
        }
        



    }
}

