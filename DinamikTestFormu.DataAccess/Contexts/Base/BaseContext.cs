using System.Data.Entity;

namespace DinamikTestFormu.DataAccess.Contexts.Base
{
    public class BaseContext<TContext>: DbContext where TContext: DbContext, new()
    {
        private static string ConnectionString = "";
        public BaseContext(): base(ConnectionString)
        {
            
        }
        public BaseContext(string connectionString): base(connectionString)
        {
            Configuration.LazyLoadingEnabled = false;
            ConnectionString = connectionString;
        }
    }
}