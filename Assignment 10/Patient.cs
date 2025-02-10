using System;
namespace KeywordAssignment
{
    class Patient
    {
        private static string hospitalName = "City Hospital"; 
        private static int totalPatients = 0; 
        private readonly int patientID; 
        private string name;
        private int age;
        private string ailment;

        public Patient(string name, int age, string ailment, int patientID)
        {
            this.name = name;
            this.age = age;
            this.ailment = ailment;
            this.patientID = patientID;
            totalPatients++;
        }

        public static int GetTotalPatients()
        {
            return totalPatients;
        }

        public void DisplayPatientDetails()
        {
            if (this is Patient) 
            {
                Console.WriteLine($"Hospital: {hospitalName}");
                Console.WriteLine($"Patient Name: {name}");
                Console.WriteLine($"Age: {age}");
                Console.WriteLine($"Ailment: {ailment}");
                Console.WriteLine($"Patient ID: {patientID}");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Patient patient1 = new Patient("Jane Doe", 45, "Flu", 1001);
            patient1.DisplayPatientDetails();
            Console.WriteLine($"Total Patients: {Patient.GetTotalPatients()}");
        }
    }
}

