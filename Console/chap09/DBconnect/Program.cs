using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;

namespace DBconnect
{
    class DBhelper
    {
        public IDbConnection GetDbConnection()
        {
            IDbConnection dbConn = null;
            string connString = ConfigurationManager.AppSetting["Connection"];
            var DBType = ConfigurationManger.Appsettings["Dbtype"];
            switch (DBType)
            {
                case "SQLServer":
                    dbConn = new SqlConnection(connString);
                    break;
                case "Oracle":
                    dbConn = new OracleConnection(connString);
                    break;
                case "OleDB":
                    dbConn = new OleDBConnection(connString);
                    break;
                default:
                    break;
            }
            return dbConn;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
