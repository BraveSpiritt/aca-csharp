namespace Task_15
{
    internal class Program
    {

        struct MyDate
        {
            public int Day;
            public int Month;
            public int Year;

            public MyDate(int day, int month, int year)
            {
                Day = day;
                Month = month;
                Year = year;
            }

            public bool IsValidDate()
            {
                if (Day <= 0 || Month <= 0 || Year <= 0)
                    return false;
                if (Month > 12)
                    return false;
                int daysInMonth = DateTime.DaysInMonth(Year, Month);
                if (Day > daysInMonth)
                    return false;
                return true;
            }
            public MyDate NextDay()
            {
                int daysInMonth = DateTime.DaysInMonth(Year, Month);
                if (Day < daysInMonth)
                {
                    return new MyDate(Day + 1, Month, Year);
                }
                else
                {
                    int nextMonth = Month + 1;
                    int nextYear = Year;
                    if (nextMonth > 12)
                    {
                        nextMonth = 1;
                        nextYear++;
                    }
                    return new MyDate(1, nextMonth, nextYear);
                }
            }
        }

        static void Main(string[] args)
        {
            MyDate date1 = new MyDate(28, 2, 2024);
            MyDate date2 = new MyDate(31, 12, 2023);
            Console.WriteLine($"Date 1 is valid: {date1.IsValidDate()}");
            Console.WriteLine($"Date 2 is valid: {date2.IsValidDate()}");
            MyDate nextDay1 = date1.NextDay();
            MyDate nextDay2 = date2.NextDay();
            Console.WriteLine($"Next day of date 1: {nextDay1.Day}/{nextDay1.Month}/{nextDay1.Year}");
            Console.WriteLine($"Next day of date 2: {nextDay2.Day}/{nextDay2.Month}/{nextDay2.Year}");
        }
    }
}
