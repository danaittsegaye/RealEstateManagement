using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateManagmentSystem
{
    internal class DatabaseCore
    {
        private static SqlConnection connection;
        public static String user;

        public static void closeConnection()
        {
            connection.Close();
        }
        public static SqlConnection connectToDB(string username, string password)
        {
            user = username;
            var serverName = ".";
            String connetionString = $"Data Source ={serverName};" +
                "Initial Catalog =RealEstateManagmentDB;" +
                $"User id ={username};" +
                $"Password={password};";
            connection = new SqlConnection(connetionString);
            connection.Open();
            return connection;
        }

        public void RunStored_Procedure(String procedureName, List<SqlParamater> parameters)
        {
            using (var com = new SqlCommand(procedureName, connection) { CommandType = CommandType.StoredProcedure })
            {
                foreach (var parameter in parameters)
                {
                    com.Parameters.Add(parameter);
                }
                com.ExecuteNonQuery();
                //MessageBox.Show("Execution successfully");

            }
        }
        public SqlDataReader executeCustomQuery(string query)
        {
            if (query == null)
            {
                query = "select * from Client";

            }
            SqlCommand command = new SqlCommand(query, connection);
            //command .parameter.AddWithValue("id",TextBox.text);
            var reader = command.ExecuteReader();
            if (reader.Read())
            {
                return reader;
            }
            else
            {
                throw new Exception();

            }
        }
        public DataSet RunTableFunction(SqlCommand command)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command.CommandText, connection);
            dataAdapter.Fill(ds, "result");
            return ds;
        }
        public string RunScalar(string procedureName, List<SqlParamater> paramaters)
        {
            //define the sqlCommand object
            SqlCommand cmd = new SqlCommand(procedureName, connection);
            foreach (var parameter in paramaters)
            {
                cmd.Parameters.Add(parameter);

            }
            //execute the sql command
            var functionResult = cmd.ExecuteScalar();
            Console.WriteLine(Environment.NewLine + "Reteriving data from database...." + Environment.NewLine);
            Console.WriteLine("Retrived result: ");
            return functionResult.ToString();
        }
    }
}

           
