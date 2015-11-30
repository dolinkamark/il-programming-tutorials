.class public Tutorial01.Program
{
	.method public static int32 MultiplySum(int32 a, int32 b, int32 c, int32 d, int32 e) 
	{
		.maxstack 2
		ldarg.0     
		ldarg.1
		add
		ldarg.2
		add
		ldarg.3
		add
		ldarg.s e
		add
		ldc.i4 1024
		mul
		ret
	}
}
