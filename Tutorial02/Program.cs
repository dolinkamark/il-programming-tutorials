using System;
using System.Runtime.CompilerServices;

namespace Tutorial02
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Conditions");

			if (IsBiggerThan(10, 5))
			{
				Console.WriteLine("Wow, 10 is bigger than 5.");
			}

			Console.WriteLine();

			Console.ReadKey();
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		public static extern void SayMyAge(int age);

		[MethodImpl(MethodImplOptions.ForwardRef)]
		public static extern bool IsBiggerThan(int x, int y);

		[MethodImpl(MethodImplOptions.ForwardRef)]
		public static extern void RepeatMe(string text, int count);

		[MethodImpl(MethodImplOptions.ForwardRef)]
		public static extern void Swap(object a, object b);
	}
}
