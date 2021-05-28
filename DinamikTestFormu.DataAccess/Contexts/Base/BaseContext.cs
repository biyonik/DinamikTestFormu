using System.Data.Entity;

namespace DinamikTestFormu.DataAccess.Contexts.Base
{
    /// <summary>
    /// BaseContext sınıfı jenerik bir TContext parametresi alır ki 
    /// bu TContext bir DbContext sınıfından kalıtılmalı ve örneği alınabilmelidir
    /// </summary>
    /// <typeparam name="TContext"></typeparam>
    public class BaseContext<TContext>: DbContext where TContext: DbContext, new()
    {
        /// <summary>
        /// statik, string bir bağlantı cümlesini tutan parametre
        /// </summary>
        private static string ConnectionString = "";
        
        /// <summary>
        /// Yapıcı metot
        /// ConnectionString değişkenini bir üst sınıfa gönderir
        /// </summary>
        public BaseContext(): base(ConnectionString)
        {
            
        }

        /// <summary>
        /// Yapıcı metot
        /// Bir string parametre alır ve dependency injection yöntemi ile bu değişken ConnectionString değişkenine atanır, ayrıca üst sınıfa da gönderilir
        /// </summary>
        /// <param name="connectionString"></param>
        public BaseContext(string connectionString): base(connectionString)
        {
            // lazy loading (tembel yükleme, nesnenin ihtiyac olduğunda başlatılması) özelliğine false değeri atanıyor
            Configuration.LazyLoadingEnabled = false;
            ConnectionString = connectionString;
        }
    }
}