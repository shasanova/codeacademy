using System;
using System.Text.RegularExpressions;

namespace Static.Homework.Task3
{
	public class Student
	{
        //Tələbənin No dəyəri o neçənci yaranan tələbədirsə o olur.
        private static int TotalCount;

		public Student()
		{
			TotalCount++;
			No = TotalCount;

		}

		public int No;
		public string Name;

        public string GroupNo;
        public Student(string groupno)
        {
            if (CheckGroupNo(groupno))
                GroupNo = groupno;
        }



        public   bool CheckGroupNo(string str)
        {
            if (str.Length == 4 && char.IsUpper(str[0]))
            {
                    for (int i = 1; i < str.Length; i++)
                    {
                        if (!char.IsNumber(str[i]))
                        {
                             return false;
                        }
                    }
                    return true;

            }
            return false;

        }




        //GroupNo dəyəri codeacademydəki qup nömrə adlarına uyğun olur
        //mesele: bir hərf və 3 rəqəm P231
        //public string GroupNo
        //{
        //    set
        //    {
        //        if (value.Length == 4 && char.IsUpper(value[0]))
        //            for (int i = 1; i < value.Length; i++)
        //            {
        //                if (char.IsNumber(value[i]))
        //                {
        //                    _groupNo = value;
        //                }

        //            }
        //    }

        //    get
        //    {
        //        return _groupNo;
        //    }
        //}



        //CheckGroupNo metodu ona göndərilən dəyərin bir groupNo olub ola bilməyəcəyini bildirir.
        //      public void CheckGroupNo(string str)
        //{
        //	if(str.)

        //}





    }
}

