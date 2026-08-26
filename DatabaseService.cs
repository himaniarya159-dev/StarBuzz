using Microsoft.Data.Sqlite;

namespace StarBuzz;

public static class DatabaseService
{
    private const string ConnectionString = "Data Source=starbuzz.db";

    // Initializes database file and creates the Orders table
    public static void InitializeDatabase()
    {
        using var connection = new SqliteConnection(ConnectionString);
        connection.Open();

        var command = connection.CreateCommand();
        command.CommandText = @"
            CREATE TABLE IF NOT EXISTS Orders (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                BeverageDescription TEXT NOT NULL,
                TotalPrice DECIMAL(10, 2) NOT NULL,
                OrderDate DATETIME DEFAULT CURRENT_TIMESTAMP
            );";
        command.ExecuteNonQuery();
    }

    // Insert order record into SQLite
    public static void SaveOrder(string description, decimal totalPrice)
    {
        using var connection = new SqliteConnection(ConnectionString);
        connection.Open();

        var command = connection.CreateCommand();
        command.CommandText = @"
            INSERT INTO Orders (BeverageDescription, TotalPrice) 
            VALUES ($desc, $price);";
        
        command.Parameters.AddWithValue("$desc", description);
        command.Parameters.AddWithValue("$price", totalPrice);

        command.ExecuteNonQuery();
    }

    // Read and display all stored orders from SQLite
    public static void FetchAndDisplayOrders()
    {
        using var connection = new SqliteConnection(ConnectionString);
        connection.Open();

        var command = connection.CreateCommand();
        command.CommandText = "SELECT Id, BeverageDescription, TotalPrice, OrderDate FROM Orders;";

        using var reader = command.ExecuteReader();

        Console.WriteLine("\n--- DATABASE: SAVED ORDERS ---");
        if (!reader.HasRows)
        {
            Console.WriteLine("No order records found in SQLite database.");
            return;
        }

        while (reader.Read())
        {
            int id = reader.GetInt32(0);
            string desc = reader.GetString(1);
            decimal price = reader.GetDecimal(2);
            string date = reader.GetString(3);

            Console.WriteLine($"[Order #{id} | {date}] {desc} - ${price:F2}");
        }
    }
}