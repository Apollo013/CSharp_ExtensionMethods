using System;

namespace CSharpExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5, num2 = 8;
            string str1 = "4", str2 = "12";

            int numresult = 0;
            string stringResult = "";

            Console.WriteLine($"Numeric Result: {numresult.Add(num1, num2)}");
            Console.WriteLine($"Numeric Result: {stringResult.Add(str1, str2)}");
        }
    }
}
