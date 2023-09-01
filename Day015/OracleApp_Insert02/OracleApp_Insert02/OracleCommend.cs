using Oracle.ManagedDataAccess.Client;

namespace OracleApp_Insert02
{
    internal class OracleCommend
    {
        public OracleCommend()
        {
        }

        public OracleConnection Connection { get; internal set; }
        public string CommandText { get; internal set; }

        internal void ExecuteNonQuery()
        {
            throw new NotImplementedException();
        }
    }
}