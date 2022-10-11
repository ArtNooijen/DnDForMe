using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNDForMeAPIData
{
    public static class DbConnectDal
    {
        public static MySqlConnection DBConnect()
        {
            string connStr = "server=localhost;user=root;database=dndforme;port=3306;password='';SslMode=none";
            MySqlConnection conn = new(connStr);
            return conn;
        }
    }
}
