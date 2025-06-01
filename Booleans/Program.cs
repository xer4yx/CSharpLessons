namespace Booleans;

class Program
{
    static void Main(string[] args)
    {
        bool isTrue = true;
        bool isFalse = false;
        
        Console.WriteLine(isTrue);
        Console.WriteLine(isFalse);
        
        // This returns False since ! is a negation converting True -> False
        Console.WriteLine(!isTrue);
        // This returns True since ! is a negation converting False -> True
        Console.WriteLine(!isFalse);
    }
}