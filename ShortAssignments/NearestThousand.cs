namespace FirstProjectFromCourse.Assignments;

/*
Write a C# program to get nearest thousand of given integer number.
Here, let name the input value as "number".

If the number's last three digits are greater than or equal to 500; it should "round up" the number.
If the number's last three digits are less than 500; it should "round down" the number.
If the number is less than 500; it should round up to 1000.

Eg:
Input: 499  Output: 1000
Input: 500  Output: 1000
Input: 999  Output: 1000
Input: 1000 Output: 1000
Input: 1499 Output: 1000
Input: 1500 Output: 2000

Note: Don't use any predefined math functions.
*/


public class NearestThousand
{
    static void Nearest()
    {
        Console.WriteLine("What's your number?");
        var number = Convert.ToInt32(Console.ReadLine());

        var lastThreeDigits = number % 1000;
        var roundUp = (1000 + number) - lastThreeDigits;
        var roundDown = number - lastThreeDigits;


        if (number < 500)
        {
            Console.WriteLine(1000);
        }
        else if (lastThreeDigits >= 500)
        {
            Console.WriteLine(roundUp);
        }
        else
        {
            Console.WriteLine(roundDown);
        }
    }
}