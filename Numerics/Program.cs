namespace Numerics;

class Program
{
    static void Main(string[] args)
    {
        int intNumber = 1;
        Console.WriteLine("Declared int: {0}", intNumber);
        Console.WriteLine("int Max Stored Value: {0}", int.MaxValue);
        Console.WriteLine("int Min Stored Value {0}", int.MinValue);
        /*
         * Line 12 will give you an output of 4. Why is that?
         * The number four (4) represents the byte/s or the size of the variable.
         * For every byte, it contains an 8 bit which is why the `int` is a 32-bit
         * signed integer since it can store 4 bytes of data.
         */
        Console.WriteLine("Data type size (bytes): {0}", System.Runtime.InteropServices.Marshal.SizeOf(intNumber));

        // Aside from static typing, you must declare a variable with `L` to be long
        long longNumber = 900000000000L; // w/o `L`, this will be treated as 32-bit
        Console.WriteLine("Declared long: {0}", longNumber);
        Console.WriteLine("long Max Stored Value: {0}", long.MaxValue);
        Console.WriteLine("long Min Stored Value: {0}", long.MinValue);
        // Will output 8 bytes (64 bits)
        Console.WriteLine("Data type size (bytes): {0}", System.Runtime.InteropServices.Marshal.SizeOf(longNumber));
        
        /*
         * The `double` is a double-precision floating point number. When we say double
         * precision floating-point, this occupies 64 bits of memory. The precision for
         * this data type is 15-17 decimal digits.
         */
        double negativeNumber = -55.2D; // will be treated as a double w or w/o D/d
        Console.WriteLine("Decalred double {0}", negativeNumber);
        Console.WriteLine("double Max Stored Value {0}", double.MaxValue);
        Console.WriteLine("double Min Stored Value {0}", double.MinValue);
        // Will output 8 bytes (64 bits)
        Console.WriteLine("Data type size (bytes): {0}", System.Runtime.InteropServices.Marshal.SizeOf(negativeNumber));
        
        /*
         * `float` on the other hand takes up 32 bits of memory making it a
         * single-precision floating-point number. This precision of the float
         * is 7 decimal digits.
         */
        float floatNumber = 0.1F; // will throw a compiler error w/o appending the F/f
        Console.WriteLine("Decalred float: {0}", floatNumber);
        Console.WriteLine("float Max Stored Value: {0}", float.MaxValue);
        Console.WriteLine("float Min Stored Value {0}", float.MinValue);
        // Will output 4 bytes (32 bits)
        Console.WriteLine("Data type size (bytes): {0}", System.Runtime.InteropServices.Marshal.SizeOf(floatNumber));

        /*
         * `decimal` consumes 128 bits of memory which makes it suitable for financial
         * or monetary applications where rounding errors from binary floating types are
         * unacceptable. It has a precision of 28-29 decimal places.
         */
        decimal money = 40.99M; // will throw a compiler error w/o appending the M/m
        Console.WriteLine("Declared decimal: {0}", money);
        Console.WriteLine("decimal Max Stored Value: {0}", decimal.MaxValue);
        Console.WriteLine("decimal Max Stored Value: {0}", decimal.MinValue);
        // Will output 16 bytes (128 bits)
        Console.WriteLine("Data type size (bytes): {0}", System.Runtime.InteropServices.Marshal.SizeOf(money));

        Console.ReadLine();
    }
}