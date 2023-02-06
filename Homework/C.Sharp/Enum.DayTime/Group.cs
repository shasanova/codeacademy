using System;
namespace DayTimeGroups
{
	public class Group
	{


        public string No;
		public GroupTypes Type;
		public DateTime StartDate;


		public void ShowInfo()
		{
            Console.WriteLine($" Grup No: {No}, Type: {Type}, StartDate: {StartDate.ToString("dd-MMMM-yyyy")}");

        }







    }
}

