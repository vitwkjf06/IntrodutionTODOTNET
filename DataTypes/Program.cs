//#define DATA_TYPES
//#define CONSTANTS
#define TYPE_CONVERSIONS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
	internal class Program
	{
		const string delimiter = "\n-------------------------\n";
		static void Main(string[] args)
		{
#if DATA_TYPES
			Console.WriteLine($"bool занимает {sizeof(bool)} Байт памяти, класс обвёртка Boolean;");
			Console.WriteLine(bool.FalseString);
			Console.WriteLine(bool.TrueString);
			Console.WriteLine(typeof(bool));
			Console.WriteLine(delimiter);
			bool rain = true;
			Console.WriteLine($"Дождь идёт? - {rain}");

			Console.WriteLine
				(
				$@"Тип данных char занимает {sizeof(char)} Байт памяти, и принимает значение в диапазоне 
от {(int)char.MinValue} до {(int)char.MaxValue}. Класс-обвертка - {typeof(char)}"
				);
			Console.WriteLine(delimiter);
			Console.WriteLine
				(
				@"Raw-строка - игнорирует все специальные символы и Esc-последовательности \t\n,
т.е.,воспринимается как есть 'as-is"
				);
			Console.WriteLine(delimiter);
			Console.WriteLine
				(
				$@"byte занимает {sizeof(byte)} Байт памяти,
и принимает значения в диапазоне от {byte.MinValue} до {byte.MaxValue}, класс-обвёртка {typeof(byte)}"
				);
			Console.WriteLine
				(
				$@"sbyte занимает {sizeof(sbyte)} Байт памяти,
и принимает значения в диапазоне от {sbyte.MinValue} до {sbyte.MaxValue}, класс-обвёртка {typeof(sbyte)}"
				);
			Console.WriteLine(delimiter);

			Console.WriteLine($@"decimal занимает {sizeof(decimal)} Байт памяти");
			decimal a = 2;
			a /= 3;
			Console.WriteLine(a);
			a *= 3;
			Console.WriteLine(a);
#endif

#if CONSTANCE
			Console.WriteLine("Hello".GetType());
			//Console.WriteLine(typeof("Hello"));
			Console.WriteLine(5.GetType()); 
#endif
#if TYPE_CONVERSIONS
			int n = 5;
			while (n-- > 0)
			{
				Console.WriteLine(n);
			}
			Console.WriteLine(delimiter);
			//ushort b = (ushort)-2;
			//Console.WriteLine(b);
			int a = 2;
			short b = (short)a; 
			Console.WriteLine(b);
			bool rain =bool.Parse("FaLsE");
			//bool rain = Convert.ToBoolean("True");
			Console.WriteLine(rain);
#endif
		}
	}
}
