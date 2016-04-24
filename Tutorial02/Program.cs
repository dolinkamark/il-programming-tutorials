using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Tutorial02
{
	class Program
	{
		static void Main(string[] args)
		{
			WriteTitle("Conditions", false);
			if (IsBiggerThan(10, 5))
			{
				Console.WriteLine("Wow, 10 is bigger than 5.");
			}
			
			WriteTitle("Local variables");
			Console.WriteLine(AddWithLocal(23, 16));
			
			WriteTitle("Loops");
			Console.WriteLine(ToPower(2, 10));

			WriteTitle("Boxing & Unboxing");
			Boxing(25);

			object boxedInt = (object)225;
			Console.WriteLine(UnboxInt(boxedInt));

			WriteTitle("Ref & out parameter modifiers");
			int x = 10;
			int y = 35;

			SwapWithRefParameter(ref x, ref y);

			Console.WriteLine("x value: {0}", x);
			Console.WriteLine("y value: {0}", y);

			Console.ReadKey();
		}

		private static void WriteTitle(string title, bool newLineBefore = true)
		{
			if (newLineBefore)
			{
				Console.WriteLine();
			}
			Console.WriteLine(title);
			for(var i=0; i<title.Length; ++i)
			{
				Console.Write("-");
			}

			Console.WriteLine();
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		public static extern bool IsBiggerThan(int x, int y);
		
		[MethodImpl(MethodImplOptions.ForwardRef)]
		public static extern int AddWithLocal(int x, int y);

		[MethodImpl(MethodImplOptions.ForwardRef)]
		public static extern int ToPower(int num, int pow);

		[MethodImpl(MethodImplOptions.ForwardRef)]
		public static extern void Boxing(int age);

		[MethodImpl(MethodImplOptions.ForwardRef)]
		public static extern int UnboxInt(object toUnbox);

		[MethodImpl(MethodImplOptions.ForwardRef)]
		public static extern void SwapWithRefParameter(ref int x, ref int y);
	}
}
