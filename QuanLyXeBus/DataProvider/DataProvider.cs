using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class DataProvider
{
    private static DataProvider instance;
    private string connectionStr = "";

    public static DataProvider Instance { get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; } 
                                            private set => instance = value; }
    DataProvider() { }
    public void SetConnectionString(string connectionStr)
    {
        this.connectionStr = connectionStr;
    }
    public DataTable ExecuteQuery(string query)
    {
        DataTable data = new DataTable();
        SqlConnection connection = new SqlConnection(connectionStr);
        connection.Open();
        SqlCommand command = new SqlCommand(query, connection);
        SqlDataAdapter adapter = new SqlDataAdapter(command);
        adapter.Fill(data);
        connection.Close();
        return data;
    }
}
