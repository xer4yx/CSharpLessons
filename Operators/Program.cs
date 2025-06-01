namespace Operators;

class Program
{
    static void Main(string[] args)
    {
        /* 
         * Types of operators:
         * 1. Arithmetics Operators
         * 2. Assignment Operators
         * 3. Comparison Operators
         * 4. Logical Operators
         *
         * Source: https://www.w3schools.com/cs/cs_operators.php
         */
        
        // Arithmetic Operators
        int x = 15,
            y = 20;
        
        Console.WriteLine("Addition: {0} + {1} = {2}", x, y, x + y);
        Console.WriteLine("Subtraction: {0} - {1} = {2}", x, y, x - y);
        Console.WriteLine("Multiplication: {0} * {1} = {2}", x, y, x * y);
        Console.WriteLine("Division: {0} / {1} = {2}", y, x, y / x);
        // x will increment after reading the value since its post-increment
        Console.WriteLine("Pre-Increment: {0}++ = {1}", x, x++);
        // y will increment before reading the value since its pre-increment
        Console.WriteLine("Post-Increment: ++{0} = {1}", y, ++y);
        Console.WriteLine("Pre-Decrement: --{0} = {1}", y, --y);
        Console.WriteLine("Post-Decrement: {0}-- = {1}", x, x--);
        // modulo operator is a diivsion that returns the remainder instead of quotient
        Console.WriteLine("Modulo: {0} % {1} = {2}", y, x, y % x);
        
        // Assignment Operators
        int number = 5;
        number += 5;
        Console.WriteLine("Addition assignment: {0}", number);
        number -= 1;
        Console.WriteLine("Subtraction assignment: {0}", number);
        number *= 5;
        Console.WriteLine("Multiplication assignment: {0}", number);
        number /= 2;
        Console.WriteLine("Division assignment: {0}", number);
        number %= 6;
        Console.WriteLine("Modulo assignment: {0}", number);
        number = 5;
        number &= 3;
        Console.WriteLine("Bitwise AND assignment: {0}", number);
        number = 5;
        number |= 3;
        Console.WriteLine("Bitwise OR assignment: {0}", number);
        number = 5;
        number ^= 3;
        Console.WriteLine("Bitwise XOR assignment: {0}", number);
        number = 5;
        number >>= 3;
        Console.WriteLine("Bitwise shift right assignment: {0}", number);
        number = 5;
        number <<= 3;
        Console.WriteLine("Bitwise shift left assignment: {0}", number);
        
        // Comparison Operators
        int a = 5,
            b = 6;
        Console.WriteLine(a < b);
        Console.WriteLine(a > b);
        Console.WriteLine(a <= b);
        Console.WriteLine(a >= b);
        Console.WriteLine(a == b);
        Console.WriteLine(a != b);
        
        // Logical Operators
        x = 3;
        Console.WriteLine("Using Logical AND: {0}", x < 5 && x < 10);
        Console.WriteLine("Using Logical OR: {0}", x <= 5 || x >= 10);
        Console.WriteLine("Using Logical NOT: {0}", !(x >= 5 || x <= 10));
    }
}