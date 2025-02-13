using System;
public abstract class Patient
{
    // Fields
    public int PatientId { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    // Abstract Method
    public abstract decimal CalculateBill(); 

    // Concrete Method
    public string GetPatientDetails()
    {
        return $"Patient ID: {PatientId}, Name: {Name}, Age: {Age}";
    }
}

public class InPatient : Patient
{
    public string RoomType { get; set; }
    public int NumberOfDays { get; set; }

    // Implementing CalculateBill for InPatient
    public override decimal CalculateBill()
    {
        decimal roomRate = RoomType == "VIP" ? 500 : 200;
        return NumberOfDays * roomRate;
    }
}

public class OutPatient : Patient
{
    public decimal ConsultationFee { get; set; }
    public bool IsSurgeryRequired { get; set; }

    // Implementing CalculateBill for OutPatient
    public override decimal CalculateBill()
    {
        decimal bill = ConsultationFee;
        if (IsSurgeryRequired)
        {
            bill += 1000; // Surgery fee
        }
        return bill;
    }
}

public interface IMedicalRecord
{
    void AddRecord(string record);
    void ViewRecords();
}

public class InPatientMedicalRecord : InPatient, IMedicalRecord
{
    private List<string> records = new List<string>();

    public void AddRecord(string record)
    {
        records.Add(record);
    }

    public void ViewRecords()
    {
        foreach (var record in records)
        {
            Console.WriteLine(record);
        }
    }
}

public class OutPatientMedicalRecord : OutPatient, IMedicalRecord
{
    private List<string> records = new List<string>();

    public void AddRecord(string record)
    {
        records.Add(record);
    }

    public void ViewRecords()
    {
        foreach (var record in records)
        {
            Console.WriteLine(record);
        }
    }
}

public class InPatient : Patient
{
    private string _diagnosis;
    private string _medicalHistory;

    public string Diagnosis
    {
        get { return "Diagnosis is confidential"; }
        set { _diagnosis = value; }
    }

    public string MedicalHistory
    {
        get { return "Medical history is confidential"; }
        set { _medicalHistory = value; }
    }

    public override decimal CalculateBill()
    {
        // Calculate bill logic
        return 0;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Patient inPatient = new InPatient
        {
            PatientId = 101,
            Name = "John Doe",
            Age = 45,
            RoomType = "VIP",
            NumberOfDays = 5
        };

        Patient outPatient = new OutPatient
        {
            PatientId = 102,
            Name = "Jane Smith",
            Age = 30,
            ConsultationFee = 200,
            IsSurgeryRequired = true
        };

        Console.WriteLine($"In-Patient Billing: ${inPatient.CalculateBill()}");
        Console.WriteLine($"Out-Patient Billing: ${outPatient.CalculateBill()}");
    }
}

