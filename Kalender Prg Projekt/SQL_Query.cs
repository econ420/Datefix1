using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace Kalender_Prg_Projekt
{
    class SQL_Query
    {
        public static string MySQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=calendar";


        public static void Query_Insert(string abfrage)
        {
            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);

            MySqlCommand commandDatabase = new MySqlCommand(abfrage, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                if (myReader.HasRows)
                {
                }
                else
                {
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Query error " + ex.Message);
            }
        }


        public static string Query_String(string abfrage)
        {
            string dummy = "";

            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);

            MySqlCommand commandDatabase = new MySqlCommand(abfrage, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        dummy = myReader.GetString(0);
                        return dummy;
                    }
                }
                else
                {
                    return dummy;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Query error " + ex.Message);
                return dummy;
            }
            return dummy;
        }

        public static bool Query_Compare(string abfrage)
        {
            bool dummy = false;

            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);

            MySqlCommand commandDatabase = new MySqlCommand(abfrage, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();

                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        dummy = true;
                        return dummy;
                    }
                }
                else
                {
                    return dummy;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Query error " + ex.Message);
                return dummy;
            }
            return dummy;
        }


    }
}
