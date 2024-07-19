namespace FirstProjectFromCourse.Assignments;

/*
 Write a C# program convert a person's height (in feet and inches) to centimeters.
 Eg:
 feet = 5
 inches = 7

 output: 170.18 cm

 Formula:
 1 inch = 2.54 cm
 1 feet = 12 inches
 */
public class FeetToCentimeters
{
    static void Convert()
    {
        var inch = 2.54;
        var givenInches = 7;
        var givenFeet = 5;

        var feetInInches = 12 * givenFeet;
        var totalInches = feetInInches + givenInches;

        var centimeters = totalInches * inch;

        Console.WriteLine(centimeters);
    }
}