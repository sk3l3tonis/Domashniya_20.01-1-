using DateAndTimeLib;

class Program
{
    static void Main()
    {
        DateTime firstDate = new DateTime(2022, 1, 1);
        DateTime secondDate = new DateTime(2022, 2, 1);
        TimeSpan difference = DateTimeUtils.GetDateDifference(firstDate, secondDate);
        Console.WriteLine($"Разница между {firstDate} и {secondDate}: {difference.TotalDays} дней");

        int year = 2024;
        bool isLeapYear = DateTimeUtils.IsLeapYear(year);
        Console.WriteLine($"{year} это високосный год: {isLeapYear}");

        DateTime time = DateTime.Now;
        string timeOfDay = DateTimeUtils.GetTimeOfDay(time);
        Console.WriteLine($"Время суток в {time}: {timeOfDay}");

        DateTime dateTime = DateTime.Now;
        string formattedDateTime = DateTimeUtils.FormatDateTime(dateTime, "dd.MM.yyyy HH:mm:ss");
        Console.WriteLine($"Отформатированные дата и время: {formattedDateTime}");
    }
}