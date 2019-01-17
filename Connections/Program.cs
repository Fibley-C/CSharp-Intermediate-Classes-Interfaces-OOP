namespace Connections
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var sqlConn = new SqlConnection("This is an SQL connection string");
            var oracleConn = new OracleConnection("This is an ORACLE connection string");
            var query = new DbCommand(oracleConn, "ORACLE QUERY");

            query.Execute();
        }
    }
}
