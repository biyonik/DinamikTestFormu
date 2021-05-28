using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using static System.Environment;

namespace DinamikTestFormu.Core.Functions
{
    /// <summary>
    /// Bağlantı cümlesini oluşturan, kontrol eden ve tanımlayan sınıf
    /// </summary>
    public class ConnectionStringProvider
    {
        /// <summary>
        /// Bağlantı cümlesininin dosya yolunu tutan field
        /// </summary>
        private static string FilePath = $"{Environment.GetFolderPath(SpecialFolder.ApplicationData)}\\{Application.CompanyName}\\Connection.dat";

        /// <summary>
        /// Bağlantı cümlesini dosyadan okur
        /// Eğer dosya yok ise null döner
        /// </summary>
        /// <returns></returns>
        public static string Get()
        {
            if (File.Exists(FilePath))
            {
                return File.ReadAllText(FilePath);
            }
            return null;
        }

        /// <summary>
        /// Bağlantı cümlesini dosyaya yazar
        /// Parametre olarak string tipinde bir bağlantı cümlesi bilgisi alır
        /// Eğer klasör yok ise oluşturur. Oluşturma dizinini "users -> AppData -> Romaing" klasörü içinde projenin company name bilgisini de alarak tanımlar
        /// Dizin oluşturulunca veya var ise FilePath field değerindeki dosyaya bağlantı bilgisini yazar
        /// </summary>
        /// <param name="ConnectionString"></param>
        public static void Set(string ConnectionString)
        {
            if (!Directory.Exists($"{GetFolderPath(SpecialFolder.ApplicationData)}\\{Application.CompanyName}"))
            {
                Directory.CreateDirectory($"{GetFolderPath(SpecialFolder.ApplicationData)}\\{Application.CompanyName}");
            }

            File.WriteAllText(FilePath, ConnectionString);
        }

        /// <summary>
        /// Bağlantı cümlesini kontrol eden metod
        /// Parametre olarak string tipinde bir parametre alır
        /// </summary>
        /// <param name="connectionString"></param>
        /// <returns></returns>
        public static bool Check(string connectionString = null)
        {
            // Bağlantı cümlesini oluşturan sınıf. Eğer parametre null ise Get metodundan gelen bağlantı cümlesini alır
            SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder(connectionString ?? Get());
            // InitialCatalog olarak master tanımlanır. SQL Server üzerinde master db varsayılan olarak var olduğu için master seçilmiştir
            connectionStringBuilder.InitialCatalog = "master";
            // oluşturulan bağlantı cümlesi bir SqlConnection aracılığı ile bağlantı kurmak üzere hazırlanıyor
            // eğer bağlantı açılırsa bağlantı başarılı bilgisi için "true" döner, değilse "false" döner
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