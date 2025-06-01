namespace Exercise1;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Exercise 1: Store user data
         * Simple exercise to store a data into a variable.
         * The user data includes the following:
         * 1. Name
         * 2. Phone Number
         * 3. Age
         *
         * Extra: use `var` for defining the variable
         */
        
        // Declare default user data
        var name = "John Doe";
        var phoneNumber = "0123456789";
        var age = 25;
        
        Console.Write("Enter your name: ");
        string? ioInput = Console.ReadLine();
        Console.Write("Enter your phone number: ");
        string? ioInput2 = Console.ReadLine();
        Console.Write("Enter your age: ");
        string? ioInput3 = Console.ReadLine();
        if (!string.IsNullOrEmpty(ioInput)) { name = ioInput; }
        if (!string.IsNullOrEmpty(ioInput2)) { phoneNumber = ioInput2; }
        if (!string.IsNullOrEmpty(ioInput3)) { age = int.TryParse(ioInput3,  out age) ? age : 25; }
        
        Console.WriteLine("User Data:" +
                          "\nName: {0}" +
                          "\nPhone Number: {1}" +
                          "\nAge: {2}", name, phoneNumber, age);
    }
}