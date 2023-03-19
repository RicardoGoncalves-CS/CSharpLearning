namespace JurassicPark.Management;

internal class ValidateDate
{
    public static bool IsValidDate(string date)
    {
        DateOnly tempObject;
        return DateOnly.TryParse(date, out tempObject);
    }

    public static bool isValidYear(int year)
    {
        int currentYear = DateTime.Now.Year;

        if (year <= currentYear - 18 && year >= currentYear - 80) return true;
        else return false;
    }

    public static bool isValidMonth(int month)
    {
        if (month <= 12 && month >= 1) return true;
        else return false;
    }
}
