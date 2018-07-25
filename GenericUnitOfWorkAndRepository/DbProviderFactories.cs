using System;
using  System.Data.SQLite;

namespace GenericUnitOfWorkAndRepository
{
    public abstract class DbProviderFactory
    {
        public virtual System.Data.Common.DbConnection CreateConnection() { throw null; }
    } 

    public class SqliteDbProviderFactory: DbProviderFactory
    {
        public override System.Data.Common.DbConnection CreateConnection() 
		{
			return new SQLiteConnection();
		}
    }    
   

    public static class DbProviderFactories
    {    
        public static DbProviderFactory GetFactory(string providerName)
        {
            var pn = providerName.ToLower();

            if (pn == "system.data.sqlite" || pn == "microsoft.data.sqlite")
                return new SqliteDbProviderFactory();

            // if (pn == "system.data.sqlclient")
            // if (pn == "mysql.data.mysqlclient" || pn == "mysql.data")
            // if (pn == "npgsql")

            throw new NotSupportedException(string.Format("UnsupportedProviderFactory {0}",providerName));
        }	
    }
}
