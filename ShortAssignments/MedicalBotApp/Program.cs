namespace Assignments;

public class Program
{
    public static void Main(string[] args)
    {
        var bot = new MedicalBot();

        Console.WriteLine($"Hi, I'm {MedicalBot.GetBotName()}. I'm here to help you in your medication.");

        Console.WriteLine("\nEnter your (patient) details:");

        Console.Write("Enter Patient Name: ");
        var patientName = Console.ReadLine();

        Console.Write("Enter Patient Age: ");
        var patientAge = int.Parse(Console.ReadLine());

        Console.Write("Enter Patient Gender: ");
        var patientGender = Console.ReadLine();

        Console.Write("Enter Medical History. Eg: Diabetes. Press Enter for None: ");
        var patientMedicalHistory = Console.ReadLine();

        Console.WriteLine($"\nWelcome, {patientName}, {patientAge}.");

        Console.WriteLine("Which of the following symptoms do you have:\n" +
                          "S1. Headache\n" +
                          "S2. Skin rashes\n" +
                          "S3. Dizziness");

        Console.Write("Enter the symptom code from above list (S1, S2 or S3): ");
        var symptomCode = Console.ReadLine();

        var patient = new Patient(patientName, patientAge, patientGender, symptomCode)
        {
            MedicalHistory = patientMedicalHistory
        };

        // Call PrescribeMedication method
        bot.PrescribeMedication(patient);

        Console.WriteLine("Your prescription based on your age, symptoms and medical history:");
        Console.WriteLine(patient.Prescription);

        Console.WriteLine("Thank you for coming.");
    }
}