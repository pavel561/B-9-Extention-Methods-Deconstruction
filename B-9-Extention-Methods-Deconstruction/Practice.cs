using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Base_Lesson_9.Extentions;

namespace Base_Lesson_9.Practice
{
    public static class Practice
    {
        /// <summary>
        /// L9-P-EX-1/2
        /// Создать структуру Coordinates (трехмерных). 
        /// Добавить экземплярный метод деконструкции значений координат.
        /// Вывести на консоль длину вектора по координатам.
        /// </summary>
        public static void L9_P_EX_1_from_2()
        {
			var coordinate1 = new Coordinates{a = 10, b = 20, c = 30};
			var (_, _, _, result) = coordinate1;
			Console.WriteLine(result);
			Console.ReadLine();
        }
		public struct Coordinates
		{
			public int a, b, c;
			public double lenght;
			public void Deconstruct(out int a, out int b,out int c, out double vector)
			{
				a = this.a;
				b = this.b;
				c = this.c;
				vector = (double)Math.Sqrt(a * a + b * b + c * c);
			}
		}

        /// <summary>
        /// L9-P-EX-2/2. 
        /// Создать деконструктор для обьекта DateTime 
        /// (год, месяц, день, час, минуты, секунды). 
        /// Получить и вывести на консоль текущее время.
        /// Использовать пустые параметры.
        /// </summary>
        public static void L9_P_EX_2_from_2()
        {
			DateTime dTime = new DateTime();
			dTime = DateTime.Now;
			var (year, month, day, hours, minutes, seconds) = dTime;
			Console.WriteLine($"Год - {year}");
			Console.WriteLine($"Месяц - {month}");
			Console.WriteLine($"День - {day}");
			Console.WriteLine($"Час - {hours}");
			Console.WriteLine($"Минуты - {minutes}");
			Console.WriteLine($"Секунды - {seconds}");

			var (_, _, _, hour, min, sec) = dTime;
			Console.WriteLine($"Текущее время - {hour}:{min}:{sec}");

			Console.ReadKey();
		}
		
    }
}
