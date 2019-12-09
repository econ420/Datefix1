using System;

using MySql.Data.MySqlClient;
using System.Data;

namespace Kalender_Prg_Projekt
{
    public static class SqlQuery
    {
        private const int DefaultCommandTimeout = 60;
        public static string MySqlConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=calendar;Convert Zero Datetime=True;Allow Zero Datetime=True";


        public static void insert(string query)
        {
            using (MySqlConnection databaseConnection = new MySqlConnection(MySqlConnectionString))
            {
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = DefaultCommandTimeout;

                try
                {
                    databaseConnection.Open();
                    MySqlDataReader myReader = commandDatabase.ExecuteReader();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Query error " + ex.Message);
                }
            }
        }


        public static string getString(string query)
        {
            using (MySqlConnection databaseConnection = new MySqlConnection(MySqlConnectionString))
            {
                MySqlCommand command = new MySqlCommand(query, databaseConnection);
                command.CommandTimeout = DefaultCommandTimeout;

                try
                {
                    databaseConnection.Open();
                    MySqlDataReader myReader = command.ExecuteReader();

                    if (myReader.HasRows)
                    {
                        while (myReader.Read())
                        {
                            return myReader.GetString(0);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Query error " + ex.Message);
                }

                return string.Empty;
            }
        }

        public static DateTime getDateTime(string query)
        {
            using (MySqlConnection databaseConnection = new MySqlConnection(MySqlConnectionString))
            {
                MySqlCommand command = new MySqlCommand(query, databaseConnection);
                command.CommandTimeout = DefaultCommandTimeout;

                try
                {
                    databaseConnection.Open();
                    MySqlDataReader myReader = command.ExecuteReader();

                    if (myReader.HasRows)
                    {
                        while (myReader.Read())
                        {
                            return DateTime.Parse(myReader.GetString(0));
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Query error " + ex.Message);
                }

                return default;
            }
        }

        public static bool exists(string query)
        {

            using (MySqlConnection databaseConnection = new MySqlConnection(MySqlConnectionString))
            {
                MySqlCommand command = new MySqlCommand(query, databaseConnection);
                command.CommandTimeout = DefaultCommandTimeout;

                try
                {
                    databaseConnection.Open();
                    MySqlDataReader myReader = command.ExecuteReader();

                    if (myReader.HasRows)
                    {
                        while (myReader.Read())
                        {
                            return true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Query error " + ex.Message);
                }

                return false;
            }
        }

        public static int getInt(string query)
        {
            using (MySqlConnection databaseConnection = new MySqlConnection(MySqlConnectionString))
            {
                MySqlCommand command = new MySqlCommand(query, databaseConnection);
                command.CommandTimeout = DefaultCommandTimeout;

                try
                {
                    databaseConnection.Open();
                    MySqlDataReader myReader = command.ExecuteReader();

                    if (myReader.HasRows)
                    {
                        while (myReader.Read())
                        {
                            if (int.TryParse(myReader.GetString(0), out int result))
                            {
                                return result;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Query error " + ex.Message);
                }

                return 0;
            }
        }

        //Automatische Erstellung aus der Datenbank in die DataGirdView
        public static DataTable getDataSource(string query)
        {
            using (MySqlConnection databaseConnection = new MySqlConnection(MySqlConnectionString))
            {
                MySqlCommand command = new MySqlCommand(query, databaseConnection);
                command.CommandTimeout = DefaultCommandTimeout;

                try
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = command;

                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    return table;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Query error " + ex.Message);
                }

                return null;
            }
        }
    }
}
