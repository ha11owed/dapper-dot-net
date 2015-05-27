using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Dapper.Contrib.Tests
{
    class WrapperDbConnection : IDbConnection
    {
        private readonly IDbConnection wrapped;

        public WrapperDbConnection(IDbConnection connection)
        {
            this.wrapped = connection;
        }

        public IDbTransaction BeginTransaction(IsolationLevel il)
        {
            return wrapped.BeginTransaction(il);
        }

        public IDbTransaction BeginTransaction()
        {
            return wrapped.BeginTransaction();
        }

        public void ChangeDatabase(string databaseName)
        {
            wrapped.ChangeDatabase(databaseName);
        }

        public void Close()
        {
            wrapped.Close();
        }

        public string ConnectionString
        {
            get { return wrapped.ConnectionString; }
            set { wrapped.ConnectionString = value; }
        }

        public int ConnectionTimeout
        {
            get { return wrapped.ConnectionTimeout; }
        }

        public IDbCommand CreateCommand()
        {
            return wrapped.CreateCommand();
        }

        public string Database
        {
            get { return wrapped.Database; }
        }

        public void Open()
        {
            wrapped.Open();
        }

        public ConnectionState State
        {
            get { return wrapped.State; }
        }

        public void Dispose()
        {
            wrapped.Dispose();
        }
    }
}
