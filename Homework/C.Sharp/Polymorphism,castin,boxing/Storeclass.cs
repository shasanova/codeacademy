using System;
namespace Polymorphism__casting__boxin_unboxing
{
    public class Storeclass
    {
        private Product[] _products = new Product[0];

        public Product[] Products { get=>_products; set=>_products = value; }


        private double _alcoholPercentLimit = 40;
        public double AlcoholPercentLimit { set => _alcoholPercentLimit = value; get => _alcoholPercentLimit; }

        private int _dairyProductCountLimit = 2;
        public int DairyProductCountLimit { set => _dairyProductCountLimit = value; get => _dairyProductCountLimit; }


        public Product GetProductbyPrice(double n, double m)
        {
            double minPrice = 0;
            double maxPrice = 0;
            Console.WriteLine("8: Qiymət aralıgına görə axtarış et ");

            Console.WriteLine("MinPrice daxil edin");
            minPrice = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("MaxPrice daxil edin");
            maxPrice = Convert.ToDouble(Console.ReadLine());

            foreach (Product item in _products)
            {
                if (item.Price >= minPrice && item.Price <= maxPrice)
                {
                    return item;
                }

            }
            throw new ProductNotFoundException();

        }



        public void AddProduct(Product product)
        {
            if (product is Drink)
            {
                try
                {
                    Drink pr = product as Drink;

                    if (pr.AlcoholPercent <= _alcoholPercentLimit)
                    {
                        Array.Resize(ref _products, _products.Length + 1);
                        _products[_products.Length - 1] = product;

                    }
                    throw new OverAlchocolLimitException();


                }
                catch
                {
                    Console.WriteLine("Mehsulun alchocol faizi limitden coxdur:");
                }


            }

            if (product is Dairy)
            {
                int count = 0;

                foreach (var item in _products)
                {
                    if (item is Dairy)
                    {
                        Dairy sud = (Dairy)product;
                        count++;
                    }
                    try
                    {
                        if (count <= _dairyProductCountLimit)
                        {
                            Array.Resize(ref _products, _products.Length + 1);
                            _products[_products.Length - 1] = product;

                        }
                        else
                        {
                            throw new OverDairyProductCountsLimit();
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Mehsul say limitden coxdur.");
                    }

                }

            }




        }



        public void Remove(int no)
        {
            for(int i = 0; i<_products.Length;i++)
            {
                if (_products[i].No == no)
                {
                    _products[i] = _products[_products.Length - 1];
                    Array.Resize(ref _products, _products.Length - 1);
                }
            }
            throw new ProductNotFoundException();
          
        }


        public Product GetProductBuNo(int no)
        {
            foreach (Product item in _products)
            {
                if (item.No == no)
                {
                    return item;
                }
            }
            throw new ProductNotFoundException();
        }




        public bool HasProductByNo(int no)
        {
            foreach (Product item in _products)
            {
                if (item.No == no)
                {
                    return true;
                }
            }
            return false;

        }





        public static Dairy[]  GetDairyProducts(Product[] products)
        {
            Dairy[] dairyProducts = new Dairy[0];
            foreach (var item in products)
            {
                
                if (item is Dairy)
                {
                    Dairy sud = (Dairy)item;
                    Array.Resize(ref dairyProducts, dairyProducts.Length + 1);
                    dairyProducts[dairyProducts.Length - 1] = sud;

                }
            }
            return dairyProducts;
        }


        public static  Drink[] GetDrinkProducts(Product[] products)
        {
            Drink[] drinks = new Drink[0];
            foreach (var item in products)
            {
                if (item is Drink)
                {
                    Drink dr = (Drink)item;
                    Array.Resize(ref drinks, drinks.Length + 1);
                    drinks[drinks.Length - 1] = dr;
                }
            }
            return drinks;
           
        }

        
    }
}

