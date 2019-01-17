using System;

namespace Connections
{
    public class DbCommand
    {
        private string _query { get; set; }
        private readonly DbConnection _dbConnection;

        public DbCommand(DbConnection dbConnection, string query)
        {
            if (string.IsNullOrEmpty(query) || string.IsNullOrWhiteSpace(query))
            {
                throw new InvalidOperationException("Query is blank!");
            }
            this._dbConnection = dbConnection;
            this._query = query;
        }

        public void Execute()
        {
            _dbConnection.OpenConnection();
            Console.WriteLine("Query: {0} has been excuted", this._query);
            _dbConnection.CloseConnection();
        }
    }
}