.class public Tutorial02.Program
{
    .method public static int32 ToPower(int32 base, int32 exponent)
    {
        .maxstack 2
        .locals init (
            [0] int32 result,
            [1] int32 i
         )

         ldc.i4.1
         stloc.0
         ldc.i4.0
         stloc.1

         //start of the loop
         br.s CheckCondition

         LoopStart:
         ldloc.0
         ldarg.0
         mul
         stloc.0

         ldloc.1
         ldc.i4.1
         add
         stloc.1

         //Checking the loop condition
         CheckCondition:
         ldloc.1
         ldarg.1
         blt.s LoopStart
         //end of the loop

         ldloc.0
         ret
    }
}
