class Student
{
    public void DisplaySubjects(params string[] subjects)
    {
        for (int i = 0; i < subjects.Length; i++)
        {
            Console.WriteLine(subjects[i]);
        }

    }
}

class Program
{
    static void Main()
    {
        var s = new Student();
        s.DisplaySubjects("Computer Networks", "Theory of Computation", "Discrete Mathematics", "Digital System Design");
    }
}