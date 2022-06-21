//unsigned integer means positive whole number or 0

public static class numberManipulation
{
    // unsigned integer means positive whole number or 0
    static uint naturalNumber = 23;
    //integer means negative or positive whole number or 0
    static int integerNumber = -23;

    //float means single-precision floating point
    // F suffix makes it a float literal
    static float realNumber = 2.3F;

    //double means double-precision floating point
    static double anotherRealNumber = 2.3;  //double literal

    static int million = 1_000_000; // to enhance readability

    public static void checkNotationEquality()
    {
        int decimalNotation = 2_000_000;
        int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
        int hexadecimalNotation = 0x_001e_8480;

        // check the three variables have the ame value
        // both statements output true

        Console.WriteLine($"{decimalNotation == binaryNotation}");
        Console.WriteLine($"{decimalNotation == hexadecimalNotation}");
    }

    public static void DisplayNumberSizes()
    {
        Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue:N0} to {int.MaxValue:N0}");
        Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range {double.MinValue:N0} to {double.MaxValue:N0}");
        Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range {decimal.MinValue:N0} to {decimal.MaxValue:N0}");
        Console.WriteLine($"long uses {sizeof(long)} bytes and can store numbers in the range {long.MinValue:N0} to {long.MaxValue:N0}");
    }

    public static void DisplayEnteredkey()
    {
        Console.Write("Press any key combination: ");

        ConsoleKeyInfo key = Console.ReadKey();

        Console.WriteLine("key : {0}, char: {1}, Modifiers: {2}",
         arg0: key.Key,
         arg1: key.KeyChar,
         arg2: key.Modifiers);
    }
}