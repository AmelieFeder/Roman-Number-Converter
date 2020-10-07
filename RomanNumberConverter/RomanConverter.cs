using System;

namespace RomanNumbers
{
    public class RomanConverter
    {
        public string ConvertNumber(int arabicNumber)
        {
            (string numberToConvert, string conversionResult) = ConvertThousands(arabicNumber.ToString());
            (numberToConvert, conversionResult) = ConvertHundreds(numberToConvert, conversionResult);
            (numberToConvert, conversionResult) = ConvertTens(numberToConvert, conversionResult);
            (numberToConvert, conversionResult) = ConvertOnes(numberToConvert, conversionResult);
            
            return conversionResult;
        }

        private (string, string) ConvertThousands(string numberToConvert)
        {
            string conversionResult = string.Empty;
            
            if (numberToConvert.Length > 3)
            {
                int thousands = int.Parse(numberToConvert[0].ToString());

                conversionResult = conversionResult.AddRomanSymbol("M", thousands);

                numberToConvert = numberToConvert.RemoveFirstNumber();
            }
            
            return (numberToConvert, conversionResult);
        }

        private (string, string) ConvertHundreds(string numberToConvert, string conversionResult)
        {
            if (numberToConvert.Length > 2)
            {
                int hundreds = Int32.Parse(numberToConvert[0].ToString());

                if (hundreds < 5)
                {
                    conversionResult = conversionResult.AddRomanSymbol("C", hundreds);
                }
                else
                {
                    hundreds = hundreds - 5;
                    conversionResult += "D";
                    conversionResult = conversionResult.AddRomanSymbol("C", hundreds);
                }

                numberToConvert = numberToConvert.RemoveFirstNumber();
            }

            return (numberToConvert, conversionResult);
        }
        private (string,string) ConvertTens(string numberToConvert, string conversionResult)
        {
            if (numberToConvert.Length > 1)
            {
                int tens = Int32.Parse(numberToConvert[0].ToString());

                if (tens < 5)
                {
                    conversionResult = conversionResult.AddRomanSymbol("X", tens);
                }
                else
                {
                    tens = tens - 5;
                    conversionResult = conversionResult.AddRomanSymbol("L");
                    conversionResult = conversionResult.AddRomanSymbol("X", tens);
                }
                numberToConvert = numberToConvert.RemoveFirstNumber();
            }

            return (numberToConvert, conversionResult);
        }
        private (string, string) ConvertOnes(string numberToConvert, string conversionResult)
        {
            int ones = Int32.Parse(numberToConvert[0].ToString());

            if (ones  < 5)
            {
                conversionResult = conversionResult.AddRomanSymbol("I", ones); 
            }
            else
            {
                ones = ones - 5;
                conversionResult += "V";
                conversionResult = conversionResult.AddRomanSymbol("I", ones);
            }
            return (numberToConvert, conversionResult);
        }
    }
}