using System;
using Npgsql;
using System.Data;

namespace HerosDbADO
{
    public class Data
    {
        //Path to DB
        string connectionString = "Host=lallah.db.elephantsql.com;Port=5432;Database=ghdvyrcu;Username=ghdvyrcu;Password=UTE0uByW_hCXRS-xrnjHJbpllPyeiJlg";

        //Create connection
        NpgsqlConnection connection;

        //Fire the query
        NpgsqlCommand command; //Connected Architecture
        NpgsqlDataAdapter dataAdapter; //Disconnected Architecture

        //Get the results
        NpgsqlDataReader reader; //Connected Architecture
        DataSet dataSet; //Disconnected Architecture

        string query = "select * from Superpeople";

        //Using Connected Architecture
        public void GetSuperPersonConnected() {
            try {
            connection = new NpgsqlConnection(connectionString);
            connection.Open();
            command = new NpgsqlCommand(query, connection);
            //Return the results of the query

            //Executeeader reads value, used with select query
            //ExecuteNonQuery used with insert, update, delete
            reader = command.ExecuteReader();

            while(reader.Read()) {
                System.Console.WriteLine($"{reader[0]} {reader[1]}");
            }
            }
            catch(Exception ex) {
                System.Console.WriteLine(ex.Message);
                // Log the exception
            }
            finally{
                connection.Close();
            }
        }


        //Using Disconnected Architecture
        public void GetSuperPersonDisconnected() {
            connection = new NpgsqlConnection(connectionString);

            //DataAdapter fires query, get results when connection is available
            dataAdapter = new NpgsqlDataAdapter(query, connection);

            //Creating an in-memory db
            dataSet = new DataSet();

            int tables = dataAdapter.Fill(dataSet);
            if(tables != 0) {
                foreach(DataRow rows in dataSet.Tables[0].Rows) {
                    Console.WriteLine($" {rows[0]} {rows[1]} ");
                    // Console.WriteLine($"{rows["id"]} {rows["workname"]} {rows["hideout"]}");
                }
            }

            
        }
    }
}
