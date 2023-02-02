namespace Homework_Try_Catch___Exception_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store1 = new Store ();
            
            Product mascara = new Product
            {
                No = 123,
                Category = "kosmetika",
                Price = 2,
            };

            Product sabun = new Product
            {
                No = 1,
                Category = "temizlik",
                Price = 0.99,
            };

            Product tava = new Product
            {
                No = 20,
                Category = "metbex levazimatlari",
                Price = 30,
            };

            //store1.AddProduct(tava);
            //store1.AddProduct(sabun);
            //store1.AddProduct(mascara);






            string op;
            do
            {
                Console.WriteLine("1. Product elave et:");
                Console.WriteLine("2. Butun productlara bax:");
                Console.WriteLine("3. Verilmis nomreli producta bax:");
                Console.WriteLine("0. Menyudan cix:");

                Console.WriteLine("Emeliyyat daxil edin: ");
                op = Console.ReadLine();

                if( op == "1")
                {
                    Console.WriteLine("No daxil et: ");

                    Console.WriteLine("Price daxil et: ");
                    Console.WriteLine("Category daxil et: ");

                    Product pr1 = new Product();
                    
                }
               











            } while (op != "0");
            





















            //Console.WriteLine(store1.HasProductByNo(1));

            //Console.WriteLine(store1.products.Length);




            //try
            //{
            //    Console.WriteLine(store1.GetProductByNo(200));

            //}
            //catch (ProductNotFoundException)
            //{
            //    Console.WriteLine("Tapilmadi");

            //}


        }
    }
}
