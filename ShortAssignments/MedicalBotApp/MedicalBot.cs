namespace Assignments;

class MedicalBot
{
    private const string BotName = "Bob";

    public static string GetBotName()
    {
        return BotName;
    }

    public void PrescribeMedication(Patient patient)
    {
        switch (patient.SymptomCode?.ToLower())
        {
            case "s1":
                patient.Prescription = "ibuprofen " + GetDosage("ibuprofen", patient);
                break;
            case "s2":
                patient.Prescription = "diphenhydramine " + GetDosage("diphenhydramine", patient);
                break;
            case "s3":
                if (patient.MedicalHistory == "diabetes")
                {
                    patient.Prescription = "metformin " + GetDosage("metformin", patient);
                }
                else
                {
                    patient.Prescription = "dimenhydrinate " + GetDosage("dimenhydrinate", patient);
                }

                break;
        }
    }
    
    
    string GetDosage(string medicineName, Patient patient)
    {
        return medicineName switch
        {
            "ibuprofen" when patient.Age < 18 => "400 mg",
            "ibuprofen" => "800 mg",
            "diphenhydramine" when patient.Age < 18 => "50 mg",
            "diphenhydramine" => "300 mg",
            "dimenhydrinate" when patient.Age < 18 => "50 mg",
            "dimenhydrinate" => "300 mg",
            "metformin" => "500 mg",
            _ => "Unknown"
        };
    }
}