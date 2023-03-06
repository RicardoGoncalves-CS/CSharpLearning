namespace StoreToArrayAndPrint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myValues = ReadValues();
            PrintArray(myValues);
        }

        public static int[] ReadValues()
        {
            List<int> inputList = new List<int>();
            string input = "";
            int counter = 1;

            Console.WriteLine("Enter SAVE to store values and exit");

            while (input != "SAVE")
            {
                Console.WriteLine("Enter an integer to store: ");
                input = Console.ReadLine().ToUpper();

                if(input != "SAVE")
                {
                    try
                    {
                        int number = Convert.ToInt32(input);
                        inputList.Add(number);
                        Console.WriteLine($"Number {counter} successfully added!");
                        counter++;
                    }
                    catch
                    {
                        Console.WriteLine("Input must be of Integer type!");
                    }
                }
            }

            int[] inputArr = new int[inputList.Count];

            for(int i = 0; i < inputArr.Length; i++)
            {
                inputArr[i] = inputList[i];
            }

            return inputArr;
        }

        public static void PrintArray(int[] arr)
        {
            foreach(int num in arr)
            {
                Console.WriteLine(num);
            }
        }
    }
}