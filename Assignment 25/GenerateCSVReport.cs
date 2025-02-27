using System;
using System.Data.SqlClient;
using System.IO;

namespace CSVDataHandlingAssignment
{
    class GenerateCSVReport
    {
        static void Main()
        {
            string connectionString = "your_connection_string_here"; // Replace with your DB connection string
            string outputFile = "employee_report.csv";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT EmployeeID, Name, Department, Salary FROM Employees";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    using (StreamWriter writer = new StreamWriter(outputFile))
                    {
                        writer.WriteLine("Employee ID,Name,Department,Salary"); // CSV header

                        while (reader.Read()) // Read database records
                        {
                            string employeeID = reader["EmployeeID"].ToString();
                            string name = reader["Name"].ToString();
                            string department = reader["Department"].ToString();
                            string salary = reader["Salary"].ToString();

                            writer.WriteLine($"{employeeID},{name},{department},{salary}"); // Write to CSV
                        }
                    }
                }

                Console.WriteLine("CSV Report Generated Successfully: employee_report.csv");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
