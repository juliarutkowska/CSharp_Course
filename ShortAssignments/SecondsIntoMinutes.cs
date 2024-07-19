namespace FirstProjectFromCourse.Assignments;

/*
Write a C# program to print the number of years, days, hours, minutes, seconds - based on given number of seconds.
Eg:
seconds = 288970
The given number of seconds is equivalent to "3 days, 8 hours, 16 minutes, 10 seconds"
Output: 3 days, 8 hours, 16 minutes, 10 seconds
*/

public class SecondsIntoMinutes
{
    static void Convertion()
    {
        Console.WriteLine("How many seconds?");
        var seconds = Convert.ToInt32(Console.ReadLine());

        var years = seconds / (365 * 24 * 60 * 60);
        seconds %= (365 * 24 * 60 * 60);

        var days = seconds / (24 * 60 * 60);
        seconds %= (24 * 60 * 60);

        var hours = seconds / (60 * 60);
        seconds %= (60 * 60);

        var minutes = seconds / 60;
        seconds %= 60;

        Console.WriteLine($"{years} years, {days} days, {hours} hours, {minutes} minutes, {seconds} seconds");
    }
}