using System;
namespace HelloWorld
{
	public class Student_class
	{
        public string Fullname;
		public double Point;
		public string Groupname;



		public bool IsPassed()
		{
			if (Point >= 65)
			{
				return true;
			}
			return false;
		}

		public string GetInfo()
		{
			return $"{Fullname} - Point: {Point} - Graduated - {IsPassed()}"; 
		}

        public Student_class()
		{
			

		}
	}
}

