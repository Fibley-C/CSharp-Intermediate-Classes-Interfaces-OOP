using System;

namespace Connections
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Oracle connection open");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Oracle connection is closed");
        }
    }
}