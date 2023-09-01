using Oracle.ManagedDataAccess.Client;

namespace Quiz01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string strConn = "Data Source=(DESCRIPTION=" +
                "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)" +
                "(HOST=localhost)(PORT=1521)))" +
                "(CONNECT_DATA=(SERVER=DEDICATED)" +
                "(SERVICE_NAME=xe)));" +
                "User Id=hr;Password=hr;";

            OracleConnection conn = new OracleConnection(strConn);

            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = "SELECT EMPNO, ENAME, JOB, HIREDATE, SAL, DEPTNO FROM EMP";

            OracleDataReader rdr = cmd.ExecuteReader();

            Console.WriteLine("EMPNO | ENAME | JOB | HIREDATE | MGR | SAL | DEPTNO");
            while (rdr.Read())
            {
                int empno = int.Parse(rdr["EMPNO"].ToString()); //워닝
                string ename = rdr["ENAME"] as string;
                string job = rdr["JOB"] as string;

                DateTime hireDate = rdr.GetDateTime(rdr.GetOrdinal("HIREDATE"));
                string HIREDATE = hireDate.ToString();

                int sal = int.Parse(rdr["SAL"].ToString());
                //int comm = int.Parse(rdr["comm"].ToString());
                
                int deptno = int.Parse(rdr["DEPTNO"].ToString());

                Console.WriteLine($"{empno} | {ename} | {job} | {HIREDATE} | {sal} | {deptno}");
            }

            conn.Close();
        }
    }
}