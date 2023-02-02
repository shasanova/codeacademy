using System;
namespace Classwor_01_02_2023
{
	public class Course
	{

		public int StudentsLimit;
		public Student[] Students = new Student[0];


		//yaradilan yeni telebeleri arraya add ele.
		//ancaq unique, artiq arrayda movcud olani add eleme.
		 public void AddStudent(Student std)
		 {
			
			if(Students.Length < StudentsLimit)
			{
                if (!HasStdInCourse(std.No))
				{
                    Array.Resize(ref Students, Students.Length + 1);
                    Students[Students.Length - 1] = std;

                }
            }
			
		 }

         //Verilmish nomreli telebenin kursda olub olmadigin gosteren method
		 public bool HasStdInCourse(int no)
		{
			for(int i = 0; i < Students.Length; i++)
			{
				if (Students[i].No == no)
				{
					return true;
				}
			}
			return false;
		}











	}
}

