using System;
using System.IO;
using System.Data;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            string Query = "SELECT [Key],[Value] FROM [UST_OKT_PIAffilicatedOrganization] order by [ID]";
            string ConnectionString = "Data Source=admms60;Initial Catalog=BPMDB;Integrated Security=False;User ID=sa;Password=1qaz6yhn9ol.#$;Connection Timeout=30;MultipleActiveResultSets=True;";

            using (System.Data.SqlClient.SqlConnection Connection = new System.Data.SqlClient.SqlConnection(ConnectionString))
            {
                Connection.Open();

                using (System.Data.SqlClient.SqlCommand Command = new System.Data.SqlClient.SqlCommand(Query, Connection))
                {
                    using (System.Data.SqlClient.SqlDataReader reader = Command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Convert.ToString(reader["Key"]);

                            }
                        }
                    }
                }
            }

            //string sourceFile = @"C:\temp\1.txt";
            //string destFile = @"Y:\temp\2.txt";
            ////try
            ////{
            //    File.Copy(sourceFile, destFile, true);
            ////}
            ////catch (Exception ex)
            ////{
            ////    throw new Exception("Failed to copy");
            ////}
            ////finally
            ////{
            ////    if (!File.Exists(destFile))
            ////        throw new Exception("Copy Failed");
            ////    else
            ////        Console.WriteLine("File copy success");
            ////}
        }

    }
}
