namespace FirstProjectFromCourse.Assignments;

/*
Write a program to find out "category of height" based on the given height of a person (in inches), using "if".
Height categories:
Height is less than 150 cm = "Dwarf"
Height is between 150 cm and 165 cm = "Average height"
Height is between 165 cm and 195 cm = "Tall"
Height is above 195 cm = "Abnormal height"

Note: 1 inch = 2.54 centimeter

Eg:
Input: 75
Output: Tall
*/

public class HeightCategory
{
    public static void GettingHeight()
    {
        Console.WriteLine("Enter your height in inches: ");
        var height = Convert.ToInt32(Console.ReadLine());

        var heightInCm = height * 2.54;

        if (heightInCm < 150)
        {
            Console.WriteLine("Dwarf");
        }
        else if (heightInCm is >= 150 and < 165)
        {
            Console.WriteLine("Average height");
        }
        else if (heightInCm is >= 165 and < 195)
        {
            Console.WriteLine("Tall");
        }
        else
        {
            Console.WriteLine("Abnormal height");
        }
    }
}