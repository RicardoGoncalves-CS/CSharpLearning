using System;

namespace MoreTypes_Lib
{
    public enum Suit
    {
        HEARTS, CLUBS, DIAMONDS, SPADES
    }
    public class DateTimeEnumsExercises
    {
        // returns a person's age at a given date, given their birth date.
        public static int AgeAt(DateTime birthDate, DateTime date)
        {
            DateTime dateOfBirth = birthDate;
            DateTime currentDate = date;

            int age = currentDate.Year - dateOfBirth.Year;
            

            return Convert.ToInt32(age); 
        }
        // returns a date formatted in the manner specified by the unit test
        public static string FormatDate(DateTime date)
        {
            return string.Empty;
        }

        // returns the name of the month corresponding to a given date
        public static string GetMonthString(DateTime date)
        {
            return string.Empty;
        }

        // see unit tests for requirements
        public static string Fortune(Suit suit)
        {
            return string.Empty;
        }
    }
}
