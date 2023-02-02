using System;
namespace Homework_Try_Catch___Exception_handling
{
	public class Store
	{

		public Product[] products = new Product[0];

		public void AddProduct(Product prd)
		{
			Array.Resize(ref products, products.Length + 1);
			products[products.Length - 1] = prd;

		}

		public bool HasProductByNo(int no)
		{
			for (int i = 0; i < products.Length; i++)
			{
				if (products[i].No == no)
				{
					return true;
				}
			}
			return false;
		}


		public Product GetProductByNo(int no)
		{
			
				for (int i = 0; i < products.Length; i++)
				{
					if (products[i].No == no)
					{
						return products[i];
					}
				}
			throw new ProductNotFoundException();
		
		}












	}
}

