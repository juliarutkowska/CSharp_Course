namespace Assignments;

public class Patient
{
    public string Name { get; }
    public int Age { get; }
    public string Gender { get; }
    public string SymptomCode { get; }
    public string MedicalHistory { get; set; }
    public string Prescription { get; set; }

    public Patient(string name, int age, string gender, string symptomCode)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Patient name can't be blank");
        }

        if (name.Length == 1)
        {
            throw new ArgumentException("Patient name should contain at least two or more characters");
        }

        if (age < 0)
        {
            throw new ArgumentOutOfRangeException("Patient age can't be negative");
        }

        if (age > 100)
        {
            throw new ArgumentOutOfRangeException("Patient age can't be greater than 100");
        }

        var lowerCaseGender = gender?.ToLower();
        if (lowerCaseGender != "male" && lowerCaseGender != "female" && lowerCaseGender != "woman" && lowerCaseGender != "other")
        {
            throw new ArgumentException("Patient gender should be either Male, Female, Woman or Other");
        }

        var lowerCaseCode = symptomCode?.ToLower();
        if (lowerCaseCode != "s1" && lowerCaseCode != "s2" && lowerCaseCode != "s3")
        {
            throw new ArgumentException("Invalid symptom code. Symptom Code should be S1, S2 or S3.");
        }

        Name = name;
        Age = age;
        Gender = gender;
        SymptomCode = symptomCode;
    }
}