using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Newtonsoft.Json;
namespace JSONAssignment{
class GenerateReport
{
    static void Main()
    {
        string connectionString = "your_connection_string_here";
        string query = "SELECT Name, Age, Email FROM Users";

        var users = new List<Dictionary<string, object>>();

        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var user = new Dictionary<string, object>
                        {
                            { "Name", reader["Name"] },
                            { "Age", reader["Age"] },
                            { "Email", reader["Email"] }
                        };
                        users.Add(user);
                    }
                }
            }
        }

        string json = JsonConvert.SerializeObject(users, Formatting.Indented);
        Console.WriteLine(json);
    }
}}

