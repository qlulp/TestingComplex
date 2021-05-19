using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using TestingComplex.Classes.Entities;

namespace TestingComplex.Classes
{
    public static class DBManager
    {
        public static string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DataBase\TestingComplex.accdb";
        private static OleDbConnection Connection = new OleDbConnection(ConnectionString);

        public static DataTable GetTableByName(string tableName)
        {
            if (!(tableName.Contains("[") && !tableName.Contains("]")))
                tableName = $"[{tableName}]";

            var resultTable = new DataTable(tableName);
            try
            {
                Connection = new OleDbConnection(ConnectionString);
                using (Connection)
                {
                    Connection.Open();
                    string query = $"SELECT * FROM {tableName}";
                    var command = new OleDbCommand(query, Connection);
                    var adapter = new OleDbDataAdapter(command);
                    adapter.Fill(resultTable);
                    Connection.Close();
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
            return Parser.ToTestBlocksList(GetTableByName("Тестовые блоки"));
        }

        public static int GetCountOfQuestions(int blockID)
        {
            string tableName = "Вопросы";
            var table = new DataTable(tableName);
            int result = 0;
            try
            {
                Connection = new OleDbConnection(ConnectionString);
                using (Connection)
                {
                    Connection.Open();
                    string query = $"SELECT COUNT(*) FROM {tableName} WHERE [Код блока] LIKE {blockID}";
                    var command = new OleDbCommand(query, Connection);
                    var adapter = new OleDbDataAdapter(command);
                    adapter.Fill(table);
                    Connection.Close();
                }

                result = table.Rows[0].Field<int>(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return result;
        }

        public static DataTable GetQuestions(int blockID)
        {
            string tableName = "Вопросы";
            var result = new DataTable(tableName);
            try
            {
                Connection = new OleDbConnection(ConnectionString);
                using (Connection)
                {
                    Connection.Open();
                    // string query = $"SELECT * FROM {tableName} WHERE [Код блока] LIKE {blockID}";
                    string query = $"SELECT * FROM Вопросы WHERE [Код блока] LIKE {blockID}";
                    var command = new OleDbCommand(query, Connection);
                    var adapter = new OleDbDataAdapter(command);
                    adapter.Fill(result);
                    Connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return result;
        }

        public static void CommitResult(TestResult result)
        {
            try
            {
                Connection = new OleDbConnection(ConnectionString);
                using (Connection)
                {
                    Connection.Open();
                    DateTimePicker picker = new DateTimePicker();
                    picker.Value = result.Date;
                    string query = $"INSERT INTO [Результаты тестирования] ([Логин пользователя], [Код блока], [Всего вопросов], [Верных ответов], [Дата тестирования], [Времени затрачено с])" +
                       $" VALUES ('{result.Login}', {result.BlockID}, {result.CountOfQuestions}, {result.CountOfCorrectAnswers}, '{result.Date.ToString("dd-MM-yyyy HH:mm:ss")}', {result.SecondsElapsed})";
                    // string query = $"insert into [Результаты тестирования] ([Логин пользователя]) values ('admin')";
                    var command = new OleDbCommand(query, Connection);
                    command.ExecuteNonQuery();
                    Connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void AddTestBlock(string blockName)
        {
            try
            {
                using (Connection = new OleDbConnection(ConnectionString))
                {
                    Connection.Open();
                    string query = $"INSERT INTO [Тестовые блоки] (Название) VALUES ('{blockName}')";
                    var command = new OleDbCommand(query, Connection);
                    command.ExecuteNonQuery();
                    Connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void DeleteTestBlock(int id)
        {
            try
            {
                using (Connection = new OleDbConnection(ConnectionString))
                {
                    Connection.Open();
                    string query = $"DELETE FROM [Тестовые блоки] WHERE [Код блока] LIKE {id}";
                    var command = new OleDbCommand(query, Connection);
                    command.ExecuteNonQuery();
                    Connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void DeleteQuestions(int blockID)
        {
            try
            {
                using (Connection = new OleDbConnection(ConnectionString))
                {
                    Connection.Open();
                    string query = $"DELETE FROM Вопросы WHERE [Код блока] LIKE {blockID}";
                    var command = new OleDbCommand(query, Connection);
                    command.ExecuteNonQuery();
                    Connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        internal static void UpdateQuestion(Question question)
        {
            try
            {
                using (Connection = new OleDbConnection(ConnectionString))
                {
                    Connection.Open();
                    string query = $"UPDATE Вопросы SET Вопрос = '{question.QuestionStr}', [Неверный ответ 1] = '{question.WrongAnswer1}', [Неверный ответ 2] = '{question.WrongAnswer2}', [Неверный ответ 3] = '{question.WrongAnswer3}', [Верный ответ] = '{question.CorrectAnswer}' WHERE [Код вопроса] LIKE {question.ID}";
                    var command = new OleDbCommand(query, Connection);
                    command.ExecuteNonQuery();
                    Connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void RenameBlock(int id, string newBlockName)
        {
            try
            {
                using (Connection = new OleDbConnection(ConnectionString))
                {
                    Connection.Open();
                    string query = $"UPDATE [Тестовые блоки] SET Название = '{newBlockName}' WHERE [Код блока] LIKE {id}";
                    var command = new OleDbCommand(query, Connection);
                    command.ExecuteNonQuery();
                    Connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void AddQuestion(Question question)
        {
            try
            {
                using (Connection = new OleDbConnection(ConnectionString))
                {
                    Connection.Open();
                    string query = $"INSERT INTO Вопросы ([Код блока], Вопрос, [Неверный ответ 1], [Неверный ответ 2], [Неверный ответ 3], [Верный ответ]) VALUES ({question.BlockID}, '{question.QuestionStr}', '{question.WrongAnswer1}', '{question.WrongAnswer2}', '{question.WrongAnswer3}', '{question.CorrectAnswer}')";
                    var command = new OleDbCommand(query, Connection);
                    command.ExecuteNonQuery();
                    Connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void DeleteQuestion(int questionID)
        {
            try
            {
                using (Connection = new OleDbConnection(ConnectionString))
                {
                    Connection.Open();
                    string query = $"DELETE FROM Вопросы WHERE [Код вопроса] LIKE {questionID}";
                    var command = new OleDbCommand(query, Connection);
                    command.ExecuteNonQuery();
                    Connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
