using System;
using System.Data;
using System.Data.SqlClient;

namespace SqlInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "ConnectionString";

            string input = Console.ReadLine();
            using (var connection = new SqlConnection(connectionString))
            {
                var query1 = "SELECT ITEM,PRICE FROM PRODUCT WHERE ITEM_CATEGORY='" + input + "' ORDER BY PRICE";
                var adapter = new SqlDataAdapter(query1, connection);
                var result = new DataSet();
                adapter.Fill(result);
                Console.WriteLine("Completed");
            }   
        }
    }
}
