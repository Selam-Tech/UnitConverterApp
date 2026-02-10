using System;
using System.Data.SQLite;
using System.IO;

namespace UnityUniversityApp
{
	public static class DatabaseHelper
	{
		private static string dbPath = "Database/unity.db";

		// Initialize database and table
		public static void InitializeDatabase()
		{
			if (!Directory.Exists("Database"))
				Directory.CreateDirectory("Database");

			if (!File.Exists(dbPath))
				SQLiteConnection.CreateFile(dbPath);

			using (var con = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
			{
				con.Open();
				var cmd = new SQLiteCommand(
					@"CREATE TABLE IF NOT EXISTS Users(
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        FirstName TEXT NOT NULL,
                        MiddleName TEXT,
                        LastName TEXT NOT NULL,
                        Password TEXT NOT NULL
                    );", con);
				cmd.ExecuteNonQuery();
			}
		}

		// Get SQLite connection
		public static SQLiteConnection GetConnection()
		{
			return new SQLiteConnection($"Data Source={dbPath};Version=3;");
		}

		// ✅ Check if a user exists by first and last name
		public static bool IsUserRegistered(string firstName, string lastName)
		{
			using (var con = GetConnection())
			{
				con.Open();
				var cmd = new SQLiteCommand(
					"SELECT COUNT(*) FROM Users WHERE LOWER(FirstName)=LOWER(@f) AND LOWER(LastName)=LOWER(@l)", con);
				cmd.Parameters.AddWithValue("@f", firstName.Trim());
				cmd.Parameters.AddWithValue("@l", lastName.Trim());
				int count = Convert.ToInt32(cmd.ExecuteScalar());
				return count > 0;
			}
		}

		// ✅ Optional: check login credentials
		public static bool IsLoginValid(string firstName, string lastName, string password)
		{
			using (var con = GetConnection())
			{
				con.Open();
				var cmd = new SQLiteCommand(
					"SELECT COUNT(*) FROM Users WHERE LOWER(FirstName)=LOWER(@f) AND LOWER(LastName)=LOWER(@l) AND Password=@p", con);
				cmd.Parameters.AddWithValue("@f", firstName.Trim());
				cmd.Parameters.AddWithValue("@l", lastName.Trim());
				cmd.Parameters.AddWithValue("@p", password.Trim());
				int count = Convert.ToInt32(cmd.ExecuteScalar());
				return count > 0;
			}
		}
	}
}
