namespace  Modulo
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Wpisz liczbę aby dowiedzieć sie czy jest PARZYSTA. Aby wyjść wpisz 'exit'");

			while (true)
			{
				var input = Console.ReadLine();
				if (input == "exit")
				{
					break;
				}

				try
				{
					var parseInout = int.Parse(input);
					if (parseInout % 2 == 0)
					{
						Console.WriteLine($"Liczba {parseInout} jest PARZYSTA");
					}
					else
					{
						Console.WriteLine($"Liczba {parseInout} NIE jest parzysta");
					}
				}
				catch (Exception e)
				{
					Console.WriteLine("Wpisana wartość nie jest liczbą");
				}
			}
		}
	}
}