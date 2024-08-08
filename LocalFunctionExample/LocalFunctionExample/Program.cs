class Student
{
    public void DisplayMarks(int mark1, int mark2, int mark3)
    {
        Console.WriteLine("Mark 1: " + mark1);
        Console.WriteLine("Mark 2: " + mark2);
        Console.WriteLine("Mark 3: " + mark3);
        Console.WriteLine("Average: " + getAverageMark());

        double getAverageMark()
        {
            var avg = (double)(mark1 + mark2 + mark3) / 3;

            return avg;
        }
    }

    class Program
    {
        static void Main()
        {
            var s = new Student();
            s.DisplayMarks(80, 45, 71);
        }
    }
}