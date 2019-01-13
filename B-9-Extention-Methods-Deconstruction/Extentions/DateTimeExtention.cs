using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Base_Lesson_9;


namespace Base_Lesson_9.Extentions
{
	public static class DateTimeExtention
	{
		//string year;
		//string month;
		//string day;
		//string hours;
		//string minutes;
		//string seconds;
		public static void Deconstruct(this DateTime dayTime, out string year, out string month, out string day, out string hours, out string minuts, out string seconds)
		{
			year = dayTime.Year.ToString(); //
			month = dayTime.Month.ToString();
			day = dayTime.Day.ToString();
			hours = dayTime.Hour.ToString();
			minuts = dayTime.Minute.ToString();
			seconds = dayTime.Second.ToString();
		}

	}
}
