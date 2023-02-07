using System.Collections;

namespace Non.Generic
{
    class Program
    {
        static void Main(string[] args)
        {

            //ArrayList

            var arrList = new ArrayList();
            arrList.Add(1);
            arrList.Add("Salam");
            arrList.Add("w");
            arrList.Add(3.2);


            var arrList2 = new ArrayList();
            arrList2.Add("Baku");

            var myQueue = new Queue();
            myQueue.Enqueue("Hello");
            myQueue.Enqueue("World");



            arrList.AddRange(arrList2);
            arrList.AddRange(myQueue);


            foreach (var i in arrList)
            {
                Console.WriteLine(i);
            }


            Console.WriteLine(arrList[0]);

            arrList.Insert(0, "Hi");
            foreach (var i in arrList)
            {
                Console.WriteLine(i);
            }

            arrList.RemoveRange(0, 2);

            foreach (var i in arrList)
            {
                Console.WriteLine(i);
            }


            //SortedList
            var sortedList = new SortedList();











        }
    }
}