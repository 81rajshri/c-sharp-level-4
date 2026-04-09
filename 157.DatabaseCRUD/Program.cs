
using System;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        string connectionString = "your_connection_string";

        using (SqlConnection con = new SqlConnection(connectionString))
        {
            con.Open();

            // INSERT
            SqlCommand insert = new SqlCommand(
                "INSERT INTO Students(Name) VALUES('Amit')", con);
            insert.ExecuteNonQuery();

            // READ
            SqlCommand cmd = new SqlCommand("SELECT * FROM Students", con);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine(reader["Id"] + " " + reader["Name"]);
            }
        }
    }
}