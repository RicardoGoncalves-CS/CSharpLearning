using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace StringsAndArrays;

public class Program
{
    static void Main()
    {
        string mySuperSecretPassword = "SuperSecretPassword!".ToLower();
        char grade = 'A';

        char firstLetter = mySuperSecretPassword[0];

        foreach (char c in mySuperSecretPassword) Console.WriteLine(c);

        mySuperSecretPassword = mySuperSecretPassword.ToUpper();
        Console.WriteLine(mySuperSecretPassword);

        // Exercise
        // Trim off any leading or trailing spaces from myString
        // Turn all the characters to Upper Case
        // Replace all occurances of the letters 'L' and 'T' with '*'
        // Find the index of the letter 'N', and delete all the characters after it
        // Return the result
        var myString = "          C# list fundamentals ";
        Console.WriteLine(StringExercise(myString));

        // String Builder
        Console.WriteLine(StringBuilderExercise(myString));

        // String Interpolation
        string firstName = "James";
        string lastName = "Bond";

        Console.WriteLine($"My name is {lastName},\n{firstName} {lastName}!");  // \n : new line

        // We can use @ instead of $ if we want to print every character literally including special characters
        Console.WriteLine(@"My name is {lastName},\n{firstName} {lastName}!");

        Console.WriteLine($"That will be {5M / 3:C} please");   // :C format as currency

        // Parsing Strings
        string input = Console.ReadLine();

        // int numApples = Int32.Parse(input);
        var tryParseOutput = Int32.TryParse(input, out int numApples);

        if (tryParseOutput) Console.WriteLine(numApples);
        else Console.WriteLine("Not an Integer!");
    }

    public static string StringExercise(string s)
    {
        string myString = s.Substring(0, s.IndexOf('n') + 1).Trim().ToUpper().Replace('L', '*').Replace('T', '*');
        return myString;
    }

    public static string StringBuilderExercise(string s)
    {
        string trimmed = s.Trim();
        string upper = trimmed.ToUpper();
        int indexOfN = upper.IndexOf('N');

        StringBuilder strBuilder = new StringBuilder(upper);

        strBuilder.Replace('L', '*').Replace('T', '*').Remove(indexOfN + 1, strBuilder.Length - indexOfN - 1);

        return strBuilder.ToString();
    }
}