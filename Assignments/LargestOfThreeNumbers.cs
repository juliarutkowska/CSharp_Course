namespace Assignments;

/*
Write a C//program to find out largest number among three numbers, using "if".
Eg:
num1 = 60
num2 = 45
num3 = 123
Output: 123
*/

public class LargestOfThreeNumbers
{
    public static int FindLargestNumber(int num1, int num2, int num3)
    {
        var largestNumber = num1;
        if (num2 > largestNumber)
        {
            largestNumber = num2;
        }

        if (num3 > largestNumber)
        {
            largestNumber = num3;
        }

        return largestNumber;
    }
}