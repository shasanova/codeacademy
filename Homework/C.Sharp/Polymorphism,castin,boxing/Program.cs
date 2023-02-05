using System;

namespace Polymorphism__casting__boxin_unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            Storeclass market1 = new Storeclass();

            string opt;
            do
            {

                Console.WriteLine("1: Drink product əlavə et");
                Console.WriteLine("2: Dairy product əlavə et");
                Console.WriteLine("3: Butun productlara bax");
                Console.WriteLine("4: Verilmis nomreli producta bax");
                Console.WriteLine("5: Drink productlara bax");
                Console.WriteLine("6: Dairy productlara bax");
                Console.WriteLine("7: Daxile edilen ada görə axtarış et");
                //console - dan minPrice və maxPrice qəbul edib price dəyəri bu iki dəyər aralığında olan productları göstərin
                Console.WriteLine("8: Qiymət aralıgına görə axtarış et ");
                Console.WriteLine("9: Daxil edilmish nomreli mehsulu siyahıdan sil ");


                Console.WriteLine("\nEmeliyyat sec");
                opt = Console.ReadLine();
                switch (opt)
                {
                    case "1":

                        var newAddedDrinkProduct = CreateDrinks();
                        market1.AddProduct(newAddedDrinkProduct);
                        break;

                    case "2":
                        var newAddedDairyProduct = CreateDairyProducts();
                        market1.AddProduct(newAddedDairyProduct);

                        break;

                    case "3":

                        foreach (Product item in market1.Products)
                        {
                            item.ShowInfo();
                        }

                        break;

                    case "4":
                        Console.WriteLine("Axtardiginiz Mehsulun nomresini elave edin: ");
                        int searchedNo = Convert.ToInt32(Console.ReadLine());
                        try
                        {
                            var finded = market1.GetProductBuNo(searchedNo);
                            finded.ShowInfo();
                        }
                        catch(ProductNotFoundException)
                        {
                            Console.WriteLine("Axtardiginiz nomreli mehsul siyahida movcud deyil.");
                        }
                        

                        break;

                    case "5":

                        Console.WriteLine("Drink productlara bax");
                        var  onlyDrinks = market1.GetDrinkProducts();
                        onlyDrinks.ShowInfo();
                        break;

                    case "6":

                        Console.WriteLine("Dairy produktlara bax: ");
                        var onlyDairy = market1.GetDairyProducts();
                        onlyDairy.ShowInfo();
                        break;

                    case "7":

                        Console.WriteLine("Axtarilan Adi daxil edin");
                        string wantedName = Console.ReadLine();

                        try
                        {
                            bool found = false;
                            foreach (var item in market1.Products)
                            {
                                if (item.Name == wantedName)
                                {
                                    found = true;
                                    item.ShowInfo();
                                }
                            }
                            if (!found)
                            {
                                throw new ProductNotFoundException();
                            }
                        }
                        catch (Exception )
                        {
                            Console.WriteLine("Mehsul siyahida movcud deyil.");


                        }
                        break;

                    case "8":
                        Console.WriteLine("8: Qiymət aralıgına gorə axtarısh et ");
                        try
                        {
                            var prd1 = market1.GetProductbyPrice(5, 30);
                            prd1.ShowInfo();
                        }
                        catch (ProductNotFoundException)
                        {
                            Console.WriteLine("Daxil edilen qiymet araliginda  mehsul siyahida movcud deyil.");
                        }
                        break;

                    case "9":

                        Console.WriteLine("Silmek istediyiniz mehsulun nomresini daxil edin: ");
                        try
                        {
                            int deleteNo = Convert.ToInt32(Console.ReadLine());
                            market1.Remove(deleteNo);
                        }
                        catch (ProductNotFoundException)
                        {
                            Console.WriteLine("Silmek istediyiniz nomreli mehsul siyahida movcud deyil.");
                        }

                        break;


                    case "0":
                        Console.WriteLine("Eminsiniz?: y/n");
                        string answer = Console.ReadLine();

                        if (answer == "y")
                        {
                            opt = "0";
                            Console.WriteLine("Son!");
                        }
                        else
                        {
                            opt = "-1";
                        }

                        break;

                    default:
                        Console.WriteLine("Yalnish daxil etdiniz.");
                        break;



                }


            } while (opt != "0");

            static Product CreateDrinks()
            {
                //DrinProducts
                Console.WriteLine("1: Drink product əlavə et");
                Console.WriteLine("Drink adi elave et: ");
                string drinkName = Console.ReadLine();


                Console.WriteLine("Drink Qiymeti elave et: ");

                double drinkPrice = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine("Drink Alchocol faizi elave et: ");
                double alchocolPercent = Convert.ToDouble(Console.ReadLine());

                Drink newDrinkProduct = new Drink
                {
                    Name = drinkName,
                    Price = drinkPrice,
                    AlcoholPercent = 22

                };
                return newDrinkProduct;

            }

            static Product CreateDairyProducts()
            {
                //DrinProducts
                Console.WriteLine("1: Dairy product əlavə et");
                Console.WriteLine("Dairy adi elave et: ");
                string dairyName = Console.ReadLine();


                Console.WriteLine("Dairy Qiymeti elave et: ");
                double dairyPrice = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine("Dairy yagliliq faizi elave et: ");
                double fatPercent = Convert.ToDouble(Console.ReadLine());

                Dairy newDairyProduct = new Dairy
                {
                    Name = dairyName,
                    Price = dairyPrice,
                    FatPercent = fatPercent

                };
                return newDairyProduct;
            }
        }
    }
 }    