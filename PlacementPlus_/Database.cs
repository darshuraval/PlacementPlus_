using MySql.Data.MySqlClient;
using System;
using System.Data;

public class Database
{
	private string connectionString = "server=localhost;database=PlacementPlus_;user=root;password=;";

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
					if (query.TrimStart().StartsWith("SELECT", StringComparison.OrdinalIgnoreCase))
					{
						using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
						{
							data = new DataTable();
							adapter.Fill(data);
							success = true; // SELECT was successful
						}
					}
					else
					{
						affectedRows = command.ExecuteNonQuery();
						success = affectedRows > 0; // True if any rows affected
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine($"Error: {ex.Message}");
				}
			}
		}

		return (success, data, affectedRows);
	}
}
