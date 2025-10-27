//#define CALC_IF
//#define CALC_SWITCH
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите арифметическое выражение: ");
			string expression = "22 + 33 - 44 / 2 + 8 * 3";
			//string expression = Console.ReadLine();
			expression = expression.Replace(",",".");
			expression = expression.Replace(" "," ");
			Console.WriteLine(expression);

			char[] operators = new char[] { '+', '-', '*', '/' };
			string[] operands = expression.Split(operators);
			double[] values = new double[operands.Length];
			for(int i = 0;i<operands.Length;i++)
			{
				values[i] = Convert.ToDouble(operands[i]);
				Console.WriteLine($"{values[i]}\t");
			}
			Console.WriteLine();

			char[] digits = "0123456789.".ToCharArray();
			for(int i =0;i<digits.Length;i++)
			{
				Console.Write($"{digits[i]}\t");
			}
			Console.WriteLine();

			string[] operations = expression.Split(digits);
			operations = operations.Where(operation => operation != "").ToArray();
			for(int i = 0;i<operations.Length;i++)
			{
				Console.Write($"{operations[i]}\t");
			}
			Console.WriteLine();
#if CALC_IF
			if (expression.Contains("+"))
				Console.WriteLine($"{values[0]}+{values[1]}={values[0] + values[1]}");
			else if (expression.Contains("-"))
				Console.WriteLine($"{values[0]}-{values[1]}={values[0] - values[1]}");
			else if (expression.Contains("*"))
				Console.WriteLine($"{values[0]}*{values[1]}={values[0] * values[1]}");
			else if (expression.Contains("/"))
				Console.WriteLine($"{values[0]}/{values[1]}={values[0] / values[1]}");
			else Console.WriteLine("Error: No operation"); 
#endif
#if CALC_SWITCH

			switch (expression[expression.IndexOfAny(operators)])
			{
				case '+': Console.WriteLine($"{values[0]} + {values[1]} = {values[0] + values[1]}"); break;
				case '-': Console.WriteLine($"{values[0]} - {values[1]} = {values[0] - values[1]}"); break;
				case '*': Console.WriteLine($"{values[0]} * {values[1]} = {values[0] * values[1]}"); break;
				case '/': Console.WriteLine($"{values[0]} / {values[1]} = {values[0] / values[1]}"); break; 
#endif
		}
		
	}
}
