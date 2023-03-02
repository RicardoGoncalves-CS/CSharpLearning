using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml.Schema;

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

        #region Arrays

        // Arrays 1D
        int[] numsArr = { 1, 2, 3, 10 };
        int[] emptyArr = new int[10];

        foreach(var num in numsArr) Console.Write(num + " ");

        Console.WriteLine();

        Array.Reverse(numsArr);
        foreach (var num in numsArr) Console.Write(num + " ");

        Console.WriteLine();

        // Multidemensional Arrays
        int[,] chessboard = { { 1, 1 }, 
                              { 1, 2 }, 
                              { 1, 3 },
                              { 2, 1 }, 
                              { 2, 2 }, 
                              { 2, 3 },
                              { 3, 1 }, 
                              { 3, 2 }, 
                              { 3, 3 }  };

        foreach (int cell in chessboard) Console.Write(cell + " ");

        Console.WriteLine();

        // for loop
        for (int i = 0; i <= chessboard.GetUpperBound(0); i++)
        {
            for (int j = 0; j <= chessboard.GetUpperBound(1); j++)
            {
                Console.Write(chessboard[i,j] + " ");
            }
        }

        Console.WriteLine();

        int[,,] empty3DArr = new int[2, 3, 4];
        empty3DArr[1, 2, 1] = 55;
        foreach (int cell in empty3DArr) Console.Write(cell + " ");

        Console.WriteLine();

        // jagged Arrays
        int[][] jaggedArr = new int[2][]; // Arrays inside of a jagged array can have different sizes

        jaggedArr[0] = new int[4];
        jaggedArr[1] = new int[3];

        jaggedArr[1][2] = 13;

        string[][] animals =
        {
            new string[] { "Dogs", "Cats", "Birds" },
            new string[] { "Lion", "Bear" },
            new string[] { "Shark", "Dolphin", "Seal", "Eagle" }
        };

        foreach (var animalGroup in animals)
        {
            foreach (var animal in animalGroup) Console.WriteLine(animal);
        }

        // DateTime Object
        var now = DateTime.Now;
        Console.WriteLine(now);
        Console.WriteLine(now.Ticks);

        var tomorrow = now.AddDays(1);

        // Enumerated Types - Enums
        // see file suits.cs
        Cards myCard = Cards.HEARTS;

        if (myCard == Cards.SPADES) Console.WriteLine("My card is something of spades");
        else if (myCard == Cards.HEARTS) Console.WriteLine($"My card is something of {myCard.ToString().ToLower()} which is {(int)Cards.HEARTS} in my Enum suit");

        #endregion
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