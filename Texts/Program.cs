namespace Texts;

class Program
{
    static void Main(string[] args)
    {
        /*
         * When declaring a string variable, you can only use double quotate " ".
         * Whereas a character variable should be initialized with single quote ' '
         */
        string word = "Hello"; // This is valid
        // string wrongWord = 'word'; // This causes compiler error
        char letter = 'a'; // This is valid
        // char wrongLetter = "b";  // This causes compiler error 
        
        // This will write in the same line in console
        Console.Write("Hello");
        Console.Write("World!");
        
        // Write with breakline
        Console.WriteLine("Hello");
        Console.WriteLine("World!");
        
        Console.ReadKey();
    }
}