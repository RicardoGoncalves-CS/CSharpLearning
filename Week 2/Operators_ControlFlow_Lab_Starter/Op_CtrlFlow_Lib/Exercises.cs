using System.Collections.Generic;

namespace Op_CtrlFlow
{
    public class Exercises
    {
        // MyMethod verifies if 2 given numbers are different and the remainder of their division is 0
        public static bool MyMethod(int num1, int num2)
        {
            return num1 == num2 ? false : (num1 % num2) == 0;
        }

        // returns the average of the array nums
        public static double Average(List<int> nums)
        {
            double total = 0;
            if (nums.Count == 0) return 0;
            else
            {
                foreach (int num in nums) total += num;
                return total / nums.Count;
            }
        }

        // returns the type of ticket a customer is eligible for based on their age
        // "Standard" if they are between 18 and 59 inclusive
        // "OAP" if they are 60 or over
        // "Student" if they are 13-17 inclusive
        // "Child" if they are 5-12
        // "Free" if they are under 5
        public static string TicketType(int age)
        {
            //string ticketType = string.Empty;

            if (age >= 60) return "OAP";
            else if (age >= 18) return "Standard";
            else if (age >= 13) return "Student";
            else if (age >= 5) return "Child";
            else return "Free";
            
            //return ticketType;
        }

        public static string Grade(int mark)
        {
            if (mark >= 75) return "Pass with Distinction";
            else if (mark >= 60) return "Pass with Merit";
            else if (mark >= 40) return "Pass";
            else return "Fail";
        }

        public static int GetScottishMaxWeddingNumbers(int covidLevel)
        {
            switch (covidLevel)
            {
                case 0:
                    return 200;
                case 1:
                    return 100;
                case 2:
                case 3:
                    return 50;
                case 4:
                    return 20;
                default:
                    return -1;
            }
        }
    }
}
