.class public Tutorial02.Program
{
	.method public static void SwapWithRefParameter( int32& a, int32& b)
    {
        .locals init(
            [0] int32 temp
        )

        ldarg.0
        ldind.i4
        stloc.0
              
        ldarg.0
        ldarg.1
        ldind.i4
        stind.i4
              
        ldarg.1
        ldloc.0
        stind.i4

        ret
    }

	.method public static bool TryParse( string s, [out] int32& result)
    {
        ldarg.1
        ldc.i4.0
        stind.i4

        ldc.i4.1
        ret
    }

}
