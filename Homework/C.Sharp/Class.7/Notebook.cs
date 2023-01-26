using System;
namespace HelloWorld

{
	public class Notebook
	{
		public string Brand;
		public string Model;
		public double Price;

		public string ShowInfo()
		{
			return $"Brand: {Brand}, Model: {Model}, Price: {Price}.";

		}


		public Notebook(string brand, string model)
		{
			Brand = brand;
			Model = model;
		}             
	}
}

