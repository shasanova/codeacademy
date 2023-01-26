using System;
namespace HelloWorld
{
	public class Product_class
	{
		public string Name;
		public double Price;
		public double DiscountPrice;




		public Product_class(string name, double price)
		{
			Name = name;
			Price = price;

		}

		public Product_class(string name, double price, double discount)
		{
            Name = name;
            Price = price;
			DiscountPrice = discount;

        }
    }
}

