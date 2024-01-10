using PhamicySysytem.BLL;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace PhamicySysytem.DAL
{
    internal class loginDAL
    {
        #region Connection String
        MySqlConnection con = connectionDAL.connectionDB();
        #endregion

        #region login info check
        public bool loginCheck(loginBLL l)
        {
            bool isSuccess = false; con = connectionDAL.connectionDB();
            con.Open();
            string count = "SELECT COUNT(status) FROM tbl_users WHERE status=1";
            MySqlCommand cmdcount = new MySqlCommand(count, con);
            int c = 0;
            c = int.Parse(cmdcount.ExecuteScalar().ToString());
            if (c == 0)
            {

                if (l.username == "admin" && l.password == "admin")
                {
                    l.user_type = "Admin";
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            else
            {
               
                string sql = "SELECT user_type FROM tbl_users WHERE username=@username AND password=@password AND status=1";

                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@username", l.username);
                cmd.Parameters.AddWithValue("@password", l.password);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    isSuccess = true;
                    l.user_type = dt.Rows[0]["user_type"].ToString();
                }
                else
                {
                    isSuccess = false;
                }
            }
            try
            {
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return isSuccess;
        }
        #endregion

    }
}
