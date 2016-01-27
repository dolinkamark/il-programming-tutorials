.class public Tutorial02.Program
{
	.method public static bool IsBiggerThan(int32, int32)
	{
		.maxstack 2
		ldarg.0
		ldarg.1
		bgt.s Bigger
		
		ldc.i4.0
		ret
		
		Bigger: 
		ldc.i4.1
		ret
	}
}
