.class public Tutorial02.Program
{
	.method public static int32 AddWithLocal(int32 x, int32 y)
	{
		.maxstack 2
		.locals init(
			[0] int32 temp
		)

		ldarg.0
		stloc.0

		ldloc.0
		ldarg.1
		add
		stloc.0

		ldloc.0
		ret
	}
}
