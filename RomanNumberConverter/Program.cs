using System;

namespace RomanNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var converter = new RomanConverter();
            
            Console.WriteLine("Please enter a number between 1 and 4999:");
            bool userInputIsNumber = int.TryParse(Console.ReadLine(), out var numberToConvert);
            
            while (!userInputIsNumber | numberToConvert < 1 | numberToConvert > 5000)
            {
                Console.WriteLine("This was not a number between 1 and 4999. Please try again:");
                userInputIsNumber = int.TryParse(Console.ReadLine(), out numberToConvert);
            }
            
            string romanNumber = converter.ConvertNumber(numberToConvert);
            
            Console.WriteLine($"The roman number equivalent to {numberToConvert} is {romanNumber}." );  
        }
    }
}