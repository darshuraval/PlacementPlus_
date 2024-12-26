using MySql.Data.MySqlClient;
using System;
using System.Data;

public class Database
{
	private string connectionString = "server=localhost;database=PlacementPlus_;user=root;password=;";

	// Executes SQL commands (SELECT or non-SELECT)
	public (bool success, DataTable data, int affectedRows) Execute(string query, params MySqlParameter[] parameters)
	{
		bool success = false;
		DataTable data = null;
		int affectedRows = 0;

		using (MySqlConnection connection = new MySqlConnection(connectionString))
		{
			connection.Open();
			using (MySqlCommand command = new MySqlCommand(query, connection))
			{
				command.Parameters.AddRange(parameters);

				try
				{
					// Execute SELECT query
					if (query.TrimStart().StartsWith("SELECT", StringComparison.OrdinalIgnoreCase))
					{
						using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
						{
							data = new DataTable();
							adapter.Fill(data);
							success = true; // SELECT query executed successfully
						}
					}
					// Execute non-SELECT query (INSERT, UPDATE, DELETE)
					else
					{
						affectedRows = command.ExecuteNonQuery();
						success = affectedRows > 0; // True if any rows affected
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine($"Error executing query: {query}");
					Console.WriteLine($"Exception: {ex.Message}");
				}
			}
		}

		return (success, data, affectedRows);
	}
}
