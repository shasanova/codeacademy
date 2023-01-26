namespace HelloWorld
{
    internal class Human
    {
        public string  Name;
        public string Surname;
        public int Age;



        public string GetFullname()
        {
            return Name + ' ' + Surname;
        }


    }




    class Program
    {
        static void Main(string[] args)
        {
            //Human class
            Human h1 = new Human()
            {
                Name = "Sabina",
                Surname = "Hasanova",
                Age = 32

            };
            var fullname = h1.GetFullname();
            Console.WriteLine(fullname);



            //Student_class
            Student_class st = new Student_class()
            {
                Fullname = "Ali Hasan",
                Point = 56,
                Groupname = "P231"

            };
            Student_class st2 = new Student_class()
            {
                Fullname = "Aliye Hasanli",
                Point = 90,
                Groupname = "P231"
            };

            Console.WriteLine(st.IsPassed());
            Console.WriteLine(st2.IsPassed());
            Console.WriteLine(st.GetInfo());



            //Car_class
            Car_class car1 = new Car_class(2011)
            {
                Year = 2012,
                Brand = "Mercedes",
                Model = "E class"
            };
            Car_class car2 = new Car_class(2009)
            {

            };

            Console.WriteLine(car1.Year);
            Console.WriteLine(car2.Year);


            //Product_class
            Product_class product1 = new Product_class("Milla", 10);
            product1.DiscountPrice = 20;


            Product_class[] products = new Product_class[2];
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine("Mehsulun adi: ");
                string name = Console.ReadLine();

                Console.WriteLine("Mehsulun qiymeti: ");
                string pricestr = Console.ReadLine();
                double price = Convert.ToDouble(pricestr);

                Console.WriteLine("Mehsulun endirimi: ");
                string endirimstr = Console.ReadLine();
                double discount = Convert.ToDouble(endirimstr);

                Product_class newProduct = new Product_class(name, price, discount);
                products[i] = newProduct;

            }




            //Notebook class
            Notebook notebook1 = new Notebook("Apple", "D34")
            {
                Brand = "Ipad",
                Model = "S2",
                Price = 122

            };
            Notebook notebook2 = new Notebook("Samsung", "l1")
            {
                Price = 44
            };
            Notebook notebook3 = new Notebook("Samg", "k3")
            {
                Price = 23
            };
            Notebook notebook4 = new Notebook("Sung", "b3")
            {
                Price = 56
            };


            Notebook[] notebooks = new Notebook[] { notebook1, notebook2, notebook3, notebook4};
            int count = 0;
            double sum = 0;
            for (int i = 0; i < notebooks.Length; i++)
            {
                sum += notebooks[i].Price;
                count++;
            }
            Console.WriteLine(sum / count);
            Console.WriteLine(notebook1.ShowInfo());



           













        }



    }
 
}















    

