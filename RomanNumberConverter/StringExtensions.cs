using System;

namespace RomanNumbers
{
    public static class StringExtensions
    {
        public static string AddRomanSymbol(this string @value, string romanSymbol, int n = 1)
        {
            for (int i = 0; i < n; i++)
            {
                @value += romanSymbol;
            }

            return @value;
        }
        
        public static string RemoveFirstNumber(this string number) => number.Substring(1);
    }
}