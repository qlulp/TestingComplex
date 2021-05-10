using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestingComplex.Classes.Entities;

namespace TestingComplex.Classes
{
    public static class DBManager
    {
        public static readonly string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DataBase\TestingComplex.accdb";
        private static OleDbConnection Connection = new OleDbConnection(ConnectionString);

        public static DataTable GetTableByName(string tableName)
        {
            if (!(tableName.Contains("[") && !tableName.Contains("]")))
                tableName = $"[{tableName}]";

            var resultTable = new DataTable(tableName);
            try
            {
                using (Connection)
                {
                    string query = $"SELECT * FROM {tableName}";
                    var command = new OleDbCommand(query, Connection);
                    var adapter = new OleDbDataAdapter(command);
                    adapter.Fill(resultTable);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return resultTable;
        }

        public static List<TestBlock> GetTestBlocks()
        {
            return Parser.ToTestBlocks(GetTableByName("Тестовые блоки"));
        }
    }
}
