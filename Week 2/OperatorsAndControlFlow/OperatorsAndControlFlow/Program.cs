using System.Diagnostics.Contracts;

namespace OperatorsAndControlFlow;

public class Program
{
    static void Main()
    {
        #region Operators Lesson

        // OPERATORS

        int x = 5;
        int y = 5;

        int a = x++; // post increment operator -> x is assigned before increment
        int b = ++y; // pre increment operator -> y is incremented befor assignment

        // Demo
        Console.WriteLine("x = " + x + ", y = " + y);
        Console.WriteLine("a = " + a + ", b = " + b);

        // var is a placeholder for the data type. The compiler evaluates the data types in the operation to infer the var type.
        var c = 10 / 3;
        var d = 9.5 / 4;

        Console.WriteLine("c is of type " + c.GetType());
        Console.WriteLine("d is of type " + d.GetType());

        // Exercise using GetStones() and GetStonesLeft()
        int stones = GetStones(156); // expect stones to be 11
        int poundsLeft = GetPoundsLeft(156); // expect stones to be 2

        Console.WriteLine(stones);
        Console.WriteLine(poundsLeft);

        bool apples = false;
        bool oranges = true;

        // difference between & / && (logical AND). Same reason applies to logical OR
        // Single & always checks both sides of the logical operation.
        // Double && (shortcut) doesn't continue the checks if it identifies that the overall logical operation will evaluate in a certain way.
        // For example false && true -> doesn't evaluate the second part because the first part is false thus will not be able to evaluate to true.
        bool fruit = apples & oranges;

        /* Example
        string luke = "luke";
        string alin = null;

        The following example will evaluate both condition
        bool bothStartWithA = luke.StartsWith('a') & alin.StartsWith('a');

        The following example will not evaluate the second condition because it asserts that the first condition is false thus the overall evaluation defaults to false
        bool bothStartWithA = luke.StartsWith('a') && alin.StartsWith('a');
        */

        #endregion

        // Ternary statement -> a ? b : c
        // bool expression ? executed if true : executed if false
        int mark = 33;
        string grade = mark >= 65 ? "Pass" : "Fail";
        Console.WriteLine(grade);

        // Ternary statements can take more than 2 bool expressions
        // if > 85 then "Distinction"
        int mark2 = 85;
        string betterGrade = mark2 >= 65 ? mark2 >= 85 ? "Distinction" : "Pass" : "Fail";
        Console.WriteLine(betterGrade);

        // Challenge: using a series of ternary operations, write a method that returns
        // "Distinction" if given above 80
        // "Pass" if given above 65
        // "Resit" if given above 35
        // "Fail" otherwise

        // int givenMark = 100;
        // string ternaryChallenge = givenMark >= 35 ? givenMark >= 65 ? givenMark >= 80 ? "Distinction" : "Pass" : "Resit" : "Fail";

        // Switch statements
        string currentCode = Priority(3);
    }

    private static string Priority(int level)
    {
        string priority = "DEFCON: ";

        switch(level)
        {
            case 0:
                priority += "Green";
                break;
            case 1:
                priority += "Amber";
                break;
            case 2:
            case 3:
                priority += "Red";
                break;
            default:
                priority = "Error";
                break;
        }
        return priority;
    }

    // Lesson Ternary Challenge
    public static string GetGrade(int givenMark)
    {
        return givenMark >= 35 ? givenMark >= 65 ? givenMark >= 80 ? "Distinction" : "Pass" : "Resit" : "Fail";
    }

    public static string GetGradeSwitch(int givenMark)
    {
        switch (givenMark)
        {
            case >= 80:
                return "Distinction";
            case >= 65:
                return "Pass";
            case >= 35:
                return "Resit";
            default:
                return "Fail";
        }
    }

    public static int GetStones(int totalPounds)
    {
        return totalPounds / 14;
    }

    public static int GetPoundsLeft(int totalPounds)
    {
        return totalPounds % 14;
    }
}