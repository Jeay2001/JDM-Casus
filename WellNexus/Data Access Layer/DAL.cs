using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WellNexus
{
    public class Dal
    {

        private string connectionString = "Data Source=.;Initial Catalog=WellNexus;Integrated Security=true";

        public void GetPatientTestResult()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = "SELECT e.* FROM Test t JOIN Exercise e ON t.ExerciseId = e.Id WHERE t.PatientId = 26;";
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                try
                                {
                                    Console.WriteLine("Test number: " + reader["Id"].ToString());
                                    for (int i = 1; i <= 14; i++)
                                    {
                                        int exerciseResult = Convert.ToInt32(reader["Excerise" + i]);
                                        Console.WriteLine("Test result " + i + ": " + exerciseResult);
                                    }
                                    Console.WriteLine();
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"Error processing test result: {ex.Message}");
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }
    }
}
