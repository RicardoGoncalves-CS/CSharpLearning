namespace Week2_MiniProject;

public class PairProgramming_MoneyProblem
{
    static void Main()
    {
        foreach (var i in MoneyProblem(60.78))
        {
            Console.WriteLine(i);
        };
    }

    public static List<string> MoneyProblem(double amount)
    {
        List<string> output = new List<string>();
        string[] currency = { "£50", "£20", "£10", "£5", "£2", "£1", "50p", "20p", "10p", "5p", "2p", "1p" };
        int[] amountCurrency = { 5000, 2000, 1000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };
        int[] record = new int[12];
        amount *= 100;
        int remainder = (int)amount;
        for (int i = 0; i < amountCurrency.Length; i++)
        {
            while (remainder >= amountCurrency[i])
            {
                remainder -= amountCurrency[i];
                record[i]++;
            }
        }
        for (int i = 0; i < currency.Length; i++)
        {
            if (amountCurrency[i] != 0)
            {
                string s = $"{record[i]}: {currency[i]}";
                output.Add(s);
            }
        }
        return output;
    }
}