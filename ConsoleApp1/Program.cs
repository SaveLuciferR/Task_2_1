using System;

namespace Task_2_1
{
	class Programm
	{
		static void Main(string[] agrs)
		{
			try
			{
				int r = 25;
				int x, y;
				Console.Write("Введите x: ");
				x = Convert.ToInt32(Console.ReadLine());

				Console.Write("Введите y: ");
				y = Convert.ToInt32(Console.ReadLine());

				if (y < 0 && (x * x + y * y) < (r * r) && Math.Abs(x) < Math.Abs(y))
				{
					Console.WriteLine("Точка находится внутри фигуры");
				}
				else if (y > 0 || ((x * x + y * y) > (r * r)) || Math.Abs(x) > Math.Abs(y))
				{
					Console.WriteLine("Точка находится вне фигуры");
				}
				else
				{
					Console.WriteLine("Точка находится на границе");
				}
			}
			catch
			{
				Console.WriteLine("X и Y должны быть числом");
			}
		}
	}
}