using System;
using System.Runtime.CompilerServices;

namespace Tutorial02
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Conditions");
			Console.WriteLine("----------");

			if (IsBiggerThan(10, 5))
			{
				Console.WriteLine("Wow, 10 is bigger than 5.");
			}
			
			//Console.WriteLine(ToPower(2, 10));
			Console.WriteLine(AddWithLocal(23, 16));

			Console.WriteLine("Boxing");
			Console.WriteLine("------");
			SayMyAge(25);

			Console.ReadKey();
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		public static extern void SayMyAge(int age);

		[MethodImpl(MethodImplOptions.ForwardRef)]
		public static extern bool IsBiggerThan(int x, int y);

		[MethodImpl(MethodImplOptions.ForwardRef)]
		public static extern void RepeatMe(string text, int count);

		[MethodImpl(MethodImplOptions.ForwardRef)]
		public static extern int ToPower(int num, int pow);

		[MethodImpl(MethodImplOptions.ForwardRef)]
		public static extern int AddWithLocal(int x, int y);
	}
}
