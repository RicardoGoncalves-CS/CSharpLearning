using System.Drawing;
using System.Text;

namespace JurassicPark.Management
{
    internal class MenuGenerator
    {
        private static void GenerateHeader()
        {
            Console.Clear();
            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(">>> Menu");
            Console.ResetColor();

            Console.WriteLine($"\nUse 🔼 and 🔽 to navigate and \u001b[32mEnter/Return\u001b[0m key to select");
            Console.WriteLine();
        }
        
        public static string GenerateMenu(List<string> menuOption)
        {
            GenerateHeader();

            List<string> options = menuOption;

            int option = 1;
            bool isSelected = false;
            string color = "✅  \u001b[32m";
            string endColor = "\u001b[0m";
            ConsoleKeyInfo key;
            (int left, int top) = Console.GetCursorPosition();

            Console.CursorVisible = false;

            while (!isSelected)
            {
                Console.SetCursorPosition(left, top);

                for (int i = 0; i < options.Count; i++)
                {
                    Console.WriteLine($"{(option == i + 1 ? color : "    ")}{options[i]}{endColor}");
                }

                key = Console.ReadKey(true);

                switch (key.Key)
                {
                    case ConsoleKey.DownArrow:
                        option = (option == options.Count ? option = 1 : option + 1);
                        break;
                    case ConsoleKey.UpArrow:
                        option = (option == 1 ? option = options.Count : option - 1);
                        break;
                    case ConsoleKey.Enter:
                        isSelected = true;
                        break;
                }
            }

            return options[option - 1];
        }

    }
}
