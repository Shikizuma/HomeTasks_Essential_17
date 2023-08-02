using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
	internal class Calculator
	{
		public static dynamic Add(dynamic x, dynamic y) => x + y;
		public static dynamic Subtract(dynamic x, dynamic y) => x - y;
		public static dynamic Multiple(dynamic x, dynamic y) => x * y;
		public static dynamic Divide(dynamic x, dynamic y) => y != 0 ? x / y : throw new DivideByZeroException();

	}
}
