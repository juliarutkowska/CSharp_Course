class Sample
{
    public double Factorial(int number)
    {
        if (number == 0)
        {
            return 1;
        }

        return number * Factorial(number - 1);
    }
}

class Program
{
    static void Main()
    {
        //read number from keyboard
        Console.WriteLine("Enter a number: ");
        var n = int.Parse(System.Console.ReadLine());

        //create object
        var s = new Sample();

        //call Factorial method
        var fact = s.Factorial(n);
        Console.WriteLine("Factorial of " + n + " is " + fact);
        Console.ReadKey();

        //n = 5
        //Factorial(5) = 5 * Factorial(4)
        //Factorial(4) = 4 * Factorial(3)
        //Factorial(3) = 3 * Factorial(2)
        //Factorial(2) = 2 * Factorial(1)
        //Factorial(1) = 1 * Factorial(0)
        //Factorial(0) = 1
    }
}