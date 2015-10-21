.class public Tutorial01.Program
{
	.method public static int32 Square(int32 number) cil managed
	{
		.maxstack 2		//Stack in case number is 10
		ldarg.0			//    [10]
		dup				//    [10,10]
		mul				//    [100]
		ret				//    []
	}

	.method public static void HelloWorld() cil managed
	{
		.maxstack 1												// []
		ldstr "Hello World"										// ["Hello World"]
		call void [mscorlib]System.Console::WriteLine(string)	// []
		ret														// []
	}
}
