namespace TypeConversions;

class Program
{
    static void Main(string[] args)
    {
        int baseNumber = 90;
        string baseNumberString = baseNumber.ToString();
        Console.WriteLine("{0} is {1}", baseNumberString, baseNumberString.GetType());
        
        string numberString = "-90";
        int intNumber = Convert.ToInt32(numberString);
        Console.WriteLine("{0} is {1}", intNumber, intNumber.GetType());

        /*
         * For string to number conversion, we do not need to append a letter
         * to determine if what type the variable that will be converting.
         * Always remember that `ToInt64` is `long`, `ToDouble` is for double
         * data type conversion, `ToSingle` is for float conversion, and
         * `ToDecimal` is for decimal conversion.
         */
        string longString = "9000000000";
        long longNumber = Convert.ToInt64(longString);
        Console.WriteLine("{0} is {1}", longNumber, longNumber.GetType());

        string doubleString = "55.2";
        double doubleNumber = Convert.ToDouble(doubleString);
        Console.WriteLine("{0} is {1}", doubleNumber, doubleNumber.GetType());
        
        string floatString = "55.2";
        float floatNumber = Convert.ToSingle(floatString);
        Console.WriteLine("{0} is {1}", floatNumber, floatNumber.GetType());
        
        string decimalString = "55.2";
        decimal decimalNumber = Convert.ToDecimal(decimalString);
        Console.WriteLine("{0} is {1}", decimalNumber, decimalNumber.GetType());

        Console.ReadLine();
    }
}