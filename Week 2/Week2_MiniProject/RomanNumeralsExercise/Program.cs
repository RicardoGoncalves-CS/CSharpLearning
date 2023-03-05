using System.Text;

namespace RomanNumeralsExercise;

public class Program
{
    static void Main()
    {
        Console.WriteLine(RomanNumerals(1515));
    }

    public static string RomanNumerals(int number)
    {
        if (number <= 0 || number > 3999) throw new ArgumentException("Number must be between 1 and 3999.");

        Dictionary<int, string> romanNumeralsConversionTable = new Dictionary<int, string>
        {

            { 1000, "M" },
            { 900, "CM" },
            { 500, "D" },
            { 400, "CD" },
            { 100, "C" },
            { 90, "XC" },
            { 50, "L" },
            { 40, "XL" },
            { 10, "X" },
            { 9, "IX" },
            { 5, "V" },
            { 4, "IV" },
            { 1, "I" }
        };

        StringBuilder result = new StringBuilder();

        foreach(int value in romanNumeralsConversionTable.Keys)
        {
            while(number >= value)
            {
                result.Append(romanNumeralsConversionTable[value]);
                number -= value;
            }
        }

        return result.ToString();
    }
}