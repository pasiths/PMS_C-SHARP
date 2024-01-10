using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PhamicySysytem.DAL
{
    internal class connectionDAL
    {
        #region SqlConnection
        public static MySqlConnection connectionDB()
        {
            String connection_string;
            connection_string = "server=127.0.0.1;uid=root;pwd=@Pasith#2002;database=pharmacy";
            MySqlConnection con = new MySqlConnection(connection_string);
            return con;
        }
        #endregion
    }
}
