.class public Tutorial02.Program
{
	.method public static void Boxing(int32)
    {
        .maxstack 2

        ldstr "The boxed value is: {0}"
        ldarg.0
        box [mscorlib]System.Int32
        call void [mscorlib]System.Console::WriteLine(string, object)

        ret
    }

	.method public static int32 UnboxInt(object)
	{
		.maxstack 1

		ldarg.0
		unbox.any [mscorlib]System.Int32

		ret
	}
}
