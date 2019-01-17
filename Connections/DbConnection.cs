using System;

namespace Connections
{
    public abstract class DbConnection
    {
        private string _connectionString { get; set; }
        private TimeSpan _timeout { get; set; }

        protected DbConnection(string connectionString)
        {
            if (String.IsNullOrWhiteSpace(connectionString) || String.IsNullOrEmpty(connectionString))
            {
                throw new InvalidOperationException("Connection string is blank!");
            }
            this._connectionString = connectionString;
        }

        public abstract void OpenConnection();

        public abstract void CloseConnection();
    }
}