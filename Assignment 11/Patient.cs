using System;
using System.Collections.Generic;

namespace ObjectModelAssignment
{
    class Patient
    {
        private string patientName;
        private int patientID;
        private List<Doctor> consultedDoctors; 
        // Constructor to initialize patient details
        public Patient(string patientName, int patientID)
        {
            this.patientName = patientName;
            this.patientID = patientID;
            this.consultedDoctors = new List<Doctor>();
        }

        // Getter method for patient name
        public string GetPatientName()
        {
            return patientName;
        }

        // Method to consult a doctor
        public void ConsultDoctor(Doctor doctor)
        {
            if (!consultedDoctors.Contains(doctor))
            {
                consultedDoctors.Add(doctor);
                doctor.Consult(this); 
            }
        }

        // Method to display consulted doctors
        public void DisplayConsultedDoctors()
        {
            Console.WriteLine($"{patientName} has consulted:");
            foreach (Doctor doctor in consultedDoctors)
            {
                Console.WriteLine($"- Dr. {doctor.GetDoctorName()} ({doctor.GetSpecialization()})");
            }
            Console.WriteLine();
        }
    }

    // Doctor class representing a medical professional
    class Doctor
    {
        private string doctorName;
        private string specialization;
        private List<Patient> patients; 

        // Constructor to initialize doctor details
        public Doctor(string doctorName, string specialization)
        {
            this.doctorName = doctorName;
            this.specialization = specialization;
            this.patients = new List<Patient>();
        }

        // Getter method for doctor name
        public string GetDoctorName()
        {
            return doctorName;
        }

        // Getter method for specialization
        public string GetSpecialization()
        {
            return specialization;
        }

        // Method to consult a patient (communication)
        public void Consult(Patient patient)
        {
            if (!patients.Contains(patient))
            {
                patients.Add(patient);
            }
            Console.WriteLine($"Dr. {doctorName} ({specialization}) is consulting {patient.GetPatientName()}.");
        }

        // Method to display patients seen by the doctor
        public void DisplayPatients()
        {
            Console.WriteLine($"Dr. {doctorName} has consulted:");
            foreach (Patient patient in patients)
            {
                Console.WriteLine($"- {patient.GetPatientName()}");
            }
            Console.WriteLine();
        }
    }

    // Hospital class representing a medical institution
    class Hospital
    {
        private string hospitalName;
        private List<Doctor> doctors; 
        private List<Patient> patients; 

        // Constructor 
        public Hospital(string hospitalName)
        {
            this.hospitalName = hospitalName;
            this.doctors = new List<Doctor>();
            this.patients = new List<Patient>();
        }

        // Method to add a doctor to the hospital
        public void AddDoctor(Doctor doctor)
        {
            doctors.Add(doctor);
        }

        // Method to add a patient to the hospital
        public void AddPatient(Patient patient)
        {
            patients.Add(patient);
        }

        // Method to display hospital details
        public void DisplayHospital()
        {
            Console.WriteLine($"Hospital: {hospitalName}");

            Console.WriteLine("\nDoctors:");
            foreach (Doctor doctor in doctors)
            {
                Console.WriteLine($"- Dr. {doctor.GetDoctorName()} ({doctor.GetSpecialization()})");
            }

            Console.WriteLine("\nPatients:");
            foreach (Patient patient in patients)
            {
                Console.WriteLine($"- {patient.GetPatientName()}");
            }
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main()
        {
            // Creating a hospital object
            Hospital hospital = new Hospital("City Health Care");

            // Creating doctor objects
            Doctor doctor1 = new Doctor("Smith", "Cardiology");
            Doctor doctor2 = new Doctor("Johnson", "Neurology");

            // Creating patient objects
            Patient patient1 = new Patient("Alice", 101);
            Patient patient2 = new Patient("Bob", 102);
            Patient patient3 = new Patient("Charlie", 103);

            // Adding doctors and patients to the hospital
            hospital.AddDoctor(doctor1);
            hospital.AddDoctor(doctor2);

            hospital.AddPatient(patient1);
            hospital.AddPatient(patient2);
            hospital.AddPatient(patient3);

            // Patients consulting doctors
            patient1.ConsultDoctor(doctor1);
            patient1.ConsultDoctor(doctor2);

            patient2.ConsultDoctor(doctor1);

            patient3.ConsultDoctor(doctor2);

            // Displaying hospital details
            hospital.DisplayHospital();

            // Displaying consultations
            doctor1.DisplayPatients();
            doctor2.DisplayPatients();

            patient1.DisplayConsultedDoctors();
            patient2.DisplayConsultedDoctors();
            patient3.DisplayConsultedDoctors();
        }
    }
}
