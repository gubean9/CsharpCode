﻿using Oracle.ManagedDataAccess.Client;

namespace OracleApp_Insert02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string strConn = "Data Source=(DESCRIPTION=" +
                "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)" +
                "(HOST=127.0.0.1)(PORT=1521)))" +
                "(CONNECT_DATA=(SERVER=DEDICATED)" +
                "(SERVICE_NAME=xe)));" +
                "User Id=hr;Password=hr;";

            //1. 연결 객체 만들기
            OracleConnection conn = new OracleConnection(strConn);

            //2. 객체 열기
            conn.Open();

            //3. Query 만들기
            //3-1. Query를 만들기 위한 객체 생성
            OracleCommend cmd = new OracleCommend();
            cmd.Connection = conn;

            //3-2. 쿼리 작성
            string query = "INSERT INTO PHONEBOOK(ID, NAME, HP) " +
                           "VALUES(2, '을지문덕', '010-222-2222')";

            cmd.CommandText = query;

            //3.3 쿼리 출력
            cmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}