using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using static System.Environment;

namespace DinamikTestFormu.Core.Functions
{
    public class ConnectionStringProvider
    {
        private static string FilePath = $"{Environment.GetFolderPath(SpecialFolder.ApplicationData)}\\{Application.CompanyName}\\Connection.dat";
        public static string Get()
        {
            if (File.Exists(FilePath))
            {
                return File.ReadAllText(FilePath);
            }
            return null;
        }

        public static void Set(string ConnectionString)
        {
            if (!Directory.Exists($"{GetFolderPath(SpecialFolder.ApplicationData)}\\{Application.CompanyName}"))
            {
                Directory.CreateDirectory($"{GetFolderPath(SpecialFolder.ApplicationData)}\\{Application.CompanyName}");
            }

            File.WriteAllText(FilePath, ConnectionString);
        }

        public static bool Check(string connectionString = null)
        {
            SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder(connectionString ?? Get());
            connectionStringBuilder.InitialCatalog = "master";
            using (SqlConnection connection = new SqlConnection(connectionStringBuilder.ConnectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                } catch( Exception e)
                {
                    return false;
                }
            }
        }
    }
}