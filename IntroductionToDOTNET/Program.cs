//#define CONSOLE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToDOTNET
{
	class Program
	{
		static void Main(string[] args)
		{
#if CONSOLE
            Console.WriteLine("Hello World!");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Hello .NET\t");
            Console.WriteLine();
            Console.Title = "Intorduction to .NET";
            Console.Beep(37, 2000);
            Console.CursorLeft = 25;
            Console.CursorTop = 5;
            Console.WriteLine("SetConsoleCursorPosition");
            Console.SetCursorPosition(22, 8);
            Console.WriteLine("Another position");
            Console.ResetColor();
            Console.Clear(); 
#endif

			Console.Write("Введите Ваше имя:");
			string firstName = Console.ReadLine();

			Console.Write("Введите Вашу фамилию:");
			string lastName = Console.ReadLine();

			Console.Write("Введите Ваш возраст: ");
			int age = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine(lastName + " " + firstName + " " + age);
			Console.WriteLine(String.Format("{0} {1} {2}", lastName, firstName, age));
            Console.WriteLine($"{lastName} {firstName} {age}");

        }
	}
}
