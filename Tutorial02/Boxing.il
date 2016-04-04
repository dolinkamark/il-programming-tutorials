.class public Tutorial02.Program
{
	.method public static void SayMyAge(int32)
	{
		.maxstack 2

		ldstr "Say my age: {0}"
		ldarg.0
		box [mscorlib]System.Int32
		call void [mscorlib]System.Console::WriteLine(string, object)

		ret
	}

	.method public static void Unboxing(object)
	{
		.maxstack 2



		ret
	}
}
