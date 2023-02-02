namespace  Classwor_01_02_2023

{
    class Program
    {
        static void Main(string[] args)
        {
            Course course1 = new Course();
            course1.StudentsLimit = 3;
       

            Student st1 = new Student
            {
                FullName = "Ali Aliyev",
                GroupNo = "P231",
                Point = 123,
            };
            Student st2 = new Student
            {
                FullName = "Leyla Abbasova",
                GroupNo = "P131",
                Point = 110,
            };
            Student st3 = new Student
            {
                FullName = "Hikmat Amirov",
                GroupNo = "P111",
                Point = 100,
            };

            course1.AddStudent(st1);
            course1.AddStudent(st2);
            course1.AddStudent(st3);

            Console.WriteLine(course1.Students.Length);
            foreach(Student std in course1.Students)
            {
                Console.WriteLine(std.FullName);
            }


            



        }

    }
}
