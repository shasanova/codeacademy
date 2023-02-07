namespace Grouplists
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<>
            var numbers = new List<int>();

            numbers.Add(1);
            numbers.Add(23578);
            numbers.Add(55);
            numbers.Add(1876);

            numbers.Sort();
            numbers.ForEach(num => Console.WriteLine(num));

            Console.WriteLine(numbers.BinarySearch(2));
            numbers.ForEach(num => Console.WriteLine(num));

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(numbers.Count);


            var groups = new List<string>();
            groups.Add("P231");
            groups.Add("M111");
            groups.Add("P541");


            var newGroups = new List<string>();
            newGroups.Add("S112");
            newGroups.Add("G445");


            newGroups.AddRange(groups);

            newGroups.Insert(2, "L111");
            Console.WriteLine(newGroups.Contains("L111"));

            Console.WriteLine(newGroups.BinarySearch("P231"));

            foreach (var item in newGroups)
            {
                Console.WriteLine(item);
            }

            newGroups.Remove("S112");
            newGroups.RemoveAt(4);


            foreach (var item in newGroups)
            {
                Console.WriteLine(item);
            }

            newGroups.RemoveAt(0);



            Console.WriteLine(newGroups[3]);


            foreach (var item in newGroups)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(newGroups.Count);
            Console.WriteLine(groups.Remove("P231"));



            //Dictionary<>
            var students = new Dictionary<string, int>();

            students.Add("Sabina Hasanova", 32);
            students.Add("Narmin Cebiyeva", 22);
            students.Add("Arif Hasanov", 28);

            foreach (var item in students)
            {
                Console.WriteLine("Name: {0}, Age: {1}", item.Key, item.Value);
            }

            Console.WriteLine(students["Arif Hasanov"]);
            Console.WriteLine(students.ContainsKey("Emin Aliyev"));

            students["Sabina Hasanova"] = 44;
            foreach (var item in students)
            {
                Console.WriteLine("Name: {0}, Age: {1}", item.Key, item.Value);
            }

            students.Remove("Arif Hasanov");
            foreach (var item in students)
            {
                Console.WriteLine("Name: {0}, Age: {1}", item.Key, item.Value);
            }



            //SortedList<TKey, TValue>
            var numsNames = new SortedList<int, string>()
            {
                {1, "Samir" },
                {34657, "Nezrin" },
                {32, "Narin" },


            };

            foreach (var item in numsNames)
            {
                Console.WriteLine("key: {0}, value: {1}", item.Key, item.Value);
            }

            Console.WriteLine(numsNames.ContainsKey(9));

            numsNames.Remove(1);

            numsNames.RemoveAt(2);
            foreach (var item in numsNames)
            {
                Console.WriteLine("key: {0}, value: {1}", item.Key, item.Value);
            }



            //Queue<>
            var Ids = new Queue<int>();

            Ids.Enqueue(1);
            Ids.Enqueue(55);
            Ids.Enqueue(2);
            Ids.Enqueue(7);

            foreach (var i in Ids)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(Ids.Peek());
            Console.WriteLine(Ids.Contains(56));



            //Stack<>
            var myStack = new Stack<int>();

            myStack.Push(1);
            myStack.Push(54);
            myStack.Push(654);

            foreach (var s in myStack)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine(myStack.Peek());
            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Contains(23423));



            //HashSet<>


            HashSet<string> myhash1 = new HashSet<string>();

            myhash1.Add("Sam");
            myhash1.Add("Anna");
            myhash1.Add("Elvin");


            HashSet<string> myhash2 = new HashSet<string>();

            myhash2.Add("Elsa");
            myhash2.Add("Sam");
            myhash2.Add("Elvin");
            myhash2.Add("Jack");

            myhash1.UnionWith(myhash2);
            foreach (var ele in myhash1)
            {
                Console.WriteLine(ele);

            }

            myhash1.IntersectWith(myhash2);
            foreach (var i in myhash1)
            {
                Console.WriteLine(i);

            }


            myhash1.ExceptWith(myhash2);
            foreach (var i in myhash1)
            {
                Console.WriteLine(i);

            }





        }

    }
}

