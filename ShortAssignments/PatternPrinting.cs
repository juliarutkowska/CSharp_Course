namespace FirstProjectFromCourse.Assignments;

/* Write a C# program to print the following output:

1 2 3 4 7 8 9 10
1 2 3 4 7 8 9 10
1 2 3 4 7 8 9 10
10 9 8 7 6 5 4 3 2 1
10 9 8 7 6 5 4 3 2 1
10 9 8 7 6 5 4 3
10 9 8 7 6 5 4 3 2 1
1 2 3 4 5 6 7 9 10


Each number should be printed by using the loop variable.

Don't print full line at-a-time as string.

For example, don't write statements as:

System.Console.WriteLine("1 2 3 4 7 8 9 10");

Use for loop, break and continue statements to bring the output.
*/

public class PatternPrinting
{
    public static void Main()
    {
        for (var i = 0; i < 3; i++)
        {
            for (var j = 1; j <= 10; j++)
            {
                if (j == 5 || j == 6)
                {
                    continue;
                }
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }

        for (var i = 0; i < 4; i++)
        {
            for (var j = 10; j >= 1 ; j--)
            {
                if (i == 2)
                {
                    if (j == 2 || j == 1)
                    {
                        continue;
                    }
                }
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
        for (var i = 0; i < 1; i++)
        {
            for (var j = 1; j <= 10; j++)
            {
                if (j == 8)
                {
                    continue;
                }
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}