using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices.ComTypes;
using System.Web;

namespace CitiesTheGame.Models
{
    public class DataBaseConnector
    {
        private static SqlConnection sqlConnection = new SqlConnection();
        public static DataTable dataTable;
        public static DataRow[] dataRows;
        

        static DataBaseConnector()
        {
            sqlConnection.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\VisualStudioProjects\CitiesTheGame\CitiesTheGame\App_Data\Database1.mdf;Integrated Security=True";
            sqlConnection.Open();
            GetAllData();
            dataRows = dataTable.Select();
        }

        private static void GetAllData()
        {
            string query = "SELECT * FROM dbo.Cities";

            SqlCommand cmd = new SqlCommand(query);
            dataTable = new DataTable();
            SqlDataAdapter READER = new SqlDataAdapter();
            READER.SelectCommand = cmd;
            READER.SelectCommand.Connection = sqlConnection;
            READER.Fill(dataTable);
        }
        public static void CloseConnection()
        {
            sqlConnection.Close();
        }
    }
}