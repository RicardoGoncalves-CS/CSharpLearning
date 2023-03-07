namespace PairProgrammingTDD.Tests;

public class Tests
{
    // OBJECTIVE - Resturn the sum of even numbers in a fibanacci sequence (starting with 1 and 2)

    /*
    [Ignore("Step 1")]
    [TestCase(1)]
    public void FibonacciProblem_WhenGivenInput1_Returns1(int input)
    {
        Assert.That(Fibonacci.FibonacciProblem(input), Is.EqualTo(1));
    }

    [Ignore("Step 2")]
    [TestCase(2, 2)]
    [TestCase(3, 3)]
    public void FibonacciProblem_WhenGivenInputNumber_ReturnsSameNumber(int input, int expected)
    {
        Assert.That(Fibonacci.FibonacciProblem(input), Is.EqualTo(expected));
    }

    [Ignore("Step 3")]
    [TestCase(4, 5)]
    public void FibonacciProblem_WhenGivenInput4_Returns5(int input, int expected)
    {
        Assert.That(Fibonacci.FibonacciProblem(input), Is.EqualTo(expected));
    }

    [Ignore("Step 4")]
    [TestCase(5, 8)]
    public void FibonacciProblem_WhenGivenInput5_Returns8(int input, int expected)
    {
        Assert.That(Fibonacci.FibonacciProblem(input), Is.EqualTo(expected));
    }

    [Ignore("Step 5")]
    [TestCase(6, 13)]
    public void FibonacciProblem_WhenGivenInput6_Returns13(int input, int expected)
    {
        Assert.That(Fibonacci.FibonacciProblem(input), Is.EqualTo(expected));
    }

    [Ignore("Step 6")]
    [TestCase(2, 3)]
    [TestCase(3, 6)]
    [TestCase(4, 11)]
    [TestCase(5, 19)]
    public void FibonacciProblem_WhenGivenInput_ReturnsSumOfNumbersInFibonacciSequence(int input, int expected)
    {
        Assert.That(Fibonacci.FibonacciProblem(input), Is.EqualTo(expected));
    }

    [Ignore("Step 7")]
    [TestCase(1, 0)]
    [TestCase(2, 2)]
    [TestCase(3, 2)]
    [TestCase(4, 2)]
    [TestCase(5, 10)]
    [TestCase(6, 10)]
    [TestCase(7, 10)]
    [TestCase(8, 44)]
    [TestCase(8, 44)]
    public void FibonacciProblem_WhenGivenInput_ReturnsSumOfEvenNumbersInFibonacciSequence(int input, int expected)
    {
        Assert.That(Fibonacci.FibonacciProblem(input), Is.EqualTo(expected));
    }
    */

    [TestCase(10)]
    public void FibonacciProblem8_UpToValue8_Returns10(int expected)
    {
        Assert.That(Fibonacci.FibonacciProblem8(), Is.EqualTo(expected));
    }

    [TestCase(44)]
    public void FibonacciProblem34_UpTo34thNumber_Returns44(int expected)
    {
        Assert.That(Fibonacci.FibonacciProblem34(), Is.EqualTo(expected));
    }

    [TestCase(4613732)]
    public void FibonacciProblem_ReturnsExpected(int expected)
    {
        Assert.That(Fibonacci.FibonacciProblem(), Is.EqualTo(expected));
    }
}