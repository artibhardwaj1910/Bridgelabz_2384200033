using System;
namespace GenericsAssignment{
public abstract class JobRole
{
    public string Name { get; set; }
    public string Skills { get; set; }

    public abstract bool IsValid();
}

public class SoftwareEngineer : JobRole
{
    public SoftwareEngineer(string name, string skills)
    {
        Name = name;
        Skills = skills;
    }

    public override bool IsValid()
    {
        return Skills.Contains("C#") || Skills.Contains("Java");
    }
}

public class DataScientist : JobRole
{
    public DataScientist(string name, string skills)
    {
        Name = name;
        Skills = skills;
    }

    public override bool IsValid()
    {
        return Skills.Contains("Python") || Skills.Contains("R");
    }
}

public class Resume<T> where T : JobRole
{
    public T JobRole { get; set; }
    public string CandidateName { get; set; }

    public Resume(T jobRole, string candidateName)
    {
        JobRole = jobRole;
        CandidateName = candidateName;
    }

    public bool IsValidResume()
    {
        return JobRole.IsValid();
    }
}

public class ResumeScreeningSystem
{
    public Resume<JobRole>[] Resumes { get; set; }
    private int currentIndex = 0;

    public ResumeScreeningSystem(int size)
    {
        Resumes = new Resume<JobRole>[size];
    }

    public void AddResume(Resume<JobRole> resume)
    {
        if (currentIndex < Resumes.Length)
        {
            Resumes[currentIndex] = resume;
            currentIndex++;
        }
        else
        {
            Console.WriteLine("Resume array is full!");
        }
    }

    public void ProcessResumes()
    {
        foreach (var resume in Resumes)
        {
            if (resume != null)
            {
                Console.WriteLine($"Processing resume for {resume.CandidateName}...");

                if (resume.IsValidResume())
                {
                    Console.WriteLine($"{resume.CandidateName}'s resume is valid for the {resume.JobRole.GetType().Name} role.");
                }
                else
                {
                    Console.WriteLine($"{resume.CandidateName}'s resume is not valid for the {resume.JobRole.GetType().Name} role.");
                }
            }
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        SoftwareEngineer se1 = new SoftwareEngineer("Arti", "C#, SQL, Java");
        SoftwareEngineer se2 = new SoftwareEngineer("Divyansh", "JavaScript, HTML, CSS");

        DataScientist ds1 = new DataScientist("Bhoomika", "Python, R, Machine Learning");
        DataScientist ds2 = new DataScientist("Ankit", "Java, SQL");

        Resume<SoftwareEngineer> resumeSE1 = new Resume<SoftwareEngineer>(se1, "Arti");
        Resume<SoftwareEngineer> resumeSE2 = new Resume<SoftwareEngineer>(se2, "Divyansh");

        Resume<DataScientist> resumeDS1 = new Resume<DataScientist>(ds1, "Bhoomika");
        Resume<DataScientist> resumeDS2 = new Resume<DataScientist>(ds2, "Ankit");

        ResumeScreeningSystem screeningSystem = new ResumeScreeningSystem(4);

        screeningSystem.AddResume(resumeSE1);
        screeningSystem.AddResume(resumeSE2);
        screeningSystem.AddResume(resumeDS1);
        screeningSystem.AddResume(resumeDS2);

        screeningSystem.ProcessResumes();
    }
}

}