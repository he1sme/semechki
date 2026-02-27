using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    internal class DatabaseController
    {
        string connectionString = @"Server=localhost;Database=eda;Trusted_Connection=True;TrustServerCertificate=True;";
        SqlConnection conn;

        public DatabaseController()
        {

            //using var cmd = new SqlCommand("SELECT Coins FROM Player WHERE Name=@n", con);
            //cmd.Parameters.AddWithValue("@n", playerName);

            //var result = cmd.ExecuteScalar();
            //return result == null ? 0 : Convert.ToInt32(result);
        }

        public List<CardItem> GetAllDishes()
        {
            var conn = new SqlConnection(this.connectionString);
            conn.Open();
            using var cmd = new SqlCommand("SELECT * FROM dbo.food;", conn);
            var result = cmd.ExecuteScalar();

            var arr = new List<CardItem>();

            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                CardItem card = new CardItem(reader.GetString(1), reader.GetInt32(2), reader.GetString(3));
                arr.Add(card);
            }

            return arr;
        }
    }
}
