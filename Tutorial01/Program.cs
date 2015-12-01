using System;
using System.Runtime.CompilerServices;

namespace Tutorial01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Square(10));

            HelloWorld();

            //Exercises
            Exercise01(35);

            Console.WriteLine(Exercise02(2, 1));
            Console.WriteLine(Exercise03(20, 15));

            //Arguments
            Console.WriteLine(MultiplySum(1, 2, 3, 4, 5));
            Console.WriteLine(Add(8, 9));

            Console.ReadKey();
        }
        
        [MethodImpl(MethodImplOptions.ForwardRef)]
        public static extern int Square(int number);

        [MethodImpl(MethodImplOptions.ForwardRef)]
        public static extern void HelloWorld();

        [MethodImpl(MethodImplOptions.ForwardRef)]
        public static extern int MultiplySum(int a, int b, int c, int d, int e);

        [MethodImpl(MethodImplOptions.ForwardRef)]
        public static extern int Add(int a, int b);

        //Exercise 01
        [MethodImpl(MethodImplOptions.ForwardRef)]
        public static extern void Exercise01(int number);

        //Exercise 02
        [MethodImpl(MethodImplOptions.ForwardRef)]
        public static extern int Exercise02(int a, int b);

        //Exercise 03
        [MethodImpl(MethodImplOptions.ForwardRef)]
        public static extern int Exercise03(int a, int b);
    }
}
