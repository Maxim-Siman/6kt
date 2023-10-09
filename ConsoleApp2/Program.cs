using System;

public enum DayOfWeekInRussian
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

public class Program
{
    public static void Main()
    {
        DayOfWeekInRussian day1 = DayOfWeekInRussian.Monday;
        DayOfWeekInRussian day2 = DayOfWeekInRussian.Tuesday;
        DayOfWeekInRussian day3 = DayOfWeekInRussian.Wednesday;
        DayOfWeekInRussian day4 = DayOfWeekInRussian.Thursday;
        DayOfWeekInRussian day5 = DayOfWeekInRussian.Friday;
        DayOfWeekInRussian day6 = DayOfWeekInRussian.Saturday;
        DayOfWeekInRussian day7 = DayOfWeekInRussian.Sunday;
        PrintDayOfWeekInRussian(day1);
        PrintDayOfWeekInRussian(day2);
        PrintDayOfWeekInRussian(day3);
        PrintDayOfWeekInRussian(day4);
        PrintDayOfWeekInRussian(day5);
        PrintDayOfWeekInRussian(day6);
        PrintDayOfWeekInRussian(day7);
    }

    public static void PrintDayOfWeekInRussian(DayOfWeekInRussian day)
    {
        switch (day)
        {
            case DayOfWeekInRussian.Monday:
                Console.WriteLine("Понедельник");
                break;
            case DayOfWeekInRussian.Tuesday:
                Console.WriteLine("Вторник");
                break;
            case DayOfWeekInRussian.Wednesday:
                Console.WriteLine("Среда");
                break;
            case DayOfWeekInRussian.Thursday:
                Console.WriteLine("Четверг");
                break;
            case DayOfWeekInRussian.Friday:
                Console.WriteLine("Пятница");
                break;
            case DayOfWeekInRussian.Saturday:
                Console.WriteLine("Суббота");
                break;
            case DayOfWeekInRussian.Sunday:
                Console.WriteLine("Воскресенье");
                break;
            default:
                Console.WriteLine("Недопустимый день недели");
                break;
        }
    }
}
