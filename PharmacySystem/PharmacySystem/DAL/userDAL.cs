using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhamicySysytem.BLL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MySql.Data.MySqlClient;
using PharmacySystem.UI;

namespace PhamicySysytem.DAL
{
    internal class userDAL
    {
        #region Connection String
        MySqlConnection con = connectionDAL.connectionDB();
        #endregion

        #region Select Data From Database
        public DataTable Select()
        {
            DataTable dt = new DataTable();
            try
            {
                String sql = "SELECT id,name,dob,email,username,password,gender,mobile,user_type,address,added_date,added_by,updated_date,updated_by FROM tbl_users WHERE status=1";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                con.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return dt;
        }
        #endregion

        #region Insert Data in Database
        public bool Insert(userBLL u)
        {
            bool isSuccess = false;

            try
            {
                String sql = "INSERT INTO tbl_users(name,dob,address,user_type,gender,username,password,email,mobile,added_date,added_by,updated_date,updated_by,status) VALUES(@name,@dob,@address,@user_type,@gender,@username,@password,@email,@mobile,@added_date,@added_by,@updated_date,@updated_by,@status)";
                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@name", u.name);
                cmd.Parameters.AddWithValue("@dob", u.DOB);
                cmd.Parameters.AddWithValue("@email", u.email);
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@password", u.password);
                cmd.Parameters.AddWithValue("@mobile", u.mobile);
                cmd.Parameters.AddWithValue("@address", u.address);
                cmd.Parameters.AddWithValue("@gender", u.gender);
                cmd.Parameters.AddWithValue("@user_type", u.user_type);
                cmd.Parameters.AddWithValue("@added_date", u.added_date);
                cmd.Parameters.AddWithValue("@added_by", u.added_by);
                cmd.Parameters.AddWithValue("@updated_date", u.added_date);
                cmd.Parameters.AddWithValue("@updated_by", u.added_by);
                cmd.Parameters.AddWithValue("@status", u.status);

                con.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
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

        #region Update data in Database
        public bool Update(userBLL u)
        {
            bool isSuccess = false;

            try
            {
                string sql = "UPDATE tbl_users SET name=@name,dob=@dob,address=@address,user_type=@user_type,gender=@gender,username=@username,password=@password,email=@email,mobile=@mobile,updated_date=@updated_date,updated_by=@updated_by WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@name", u.name);
                cmd.Parameters.AddWithValue("@dob", u.DOB);
                cmd.Parameters.AddWithValue("@email", u.email);
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@password", u.password);
                cmd.Parameters.AddWithValue("@mobile", u.mobile);
                cmd.Parameters.AddWithValue("@address", u.address);
                cmd.Parameters.AddWithValue("@gender", u.gender);
                cmd.Parameters.AddWithValue("@user_type", u.user_type);
                cmd.Parameters.AddWithValue("@updated_date", u.updated_date);
                cmd.Parameters.AddWithValue("@updated_by", u.updated_by);
                cmd.Parameters.AddWithValue("@id", u.id);

                con.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

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

        #region Delete data in Database
        public bool Delete(userBLL u)
        {
            bool isSuccess = false;

            try
            {
                string sql = "UPDATE tbl_users SET status=@status WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@status", u.status);
                cmd.Parameters.AddWithValue("@id", u.id);

                con.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

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

        #region Search User on Database using Keywords
        public DataTable Search(string keywords)
        {
            DataTable dt = new DataTable();
            try
            {
                String sql = "SELECT id,name,dob,email,username,password,gender,mobile,user_type,address,added_date,added_by,updated_date,updated_by FROM tbl_users WHERE status=1 AND id LIKE '%" + keywords + "%' OR status=1 AND name LIKE '%" + keywords + "%' OR status=1 AND username LIKE '%" + keywords + "%' ";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                con.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return dt;
        }
        #endregion

        #region Getting user id from username
        public userBLL GetIDFromUsername(string username)
        {
            userBLL u = new userBLL();

            DataTable dt = new DataTable();
            try
            {
                con = connectionDAL.connectionDB();
                string sql = "Select id From tbl_users Where username='" + username + "'";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, con);
                con.Open();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    u.id = int.Parse(dt.Rows[0]["id"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

            return u;
        }
        #endregion

        #region Show user details
        public void DisplayProfile(userBLL u)
        {
            MySqlConnection con = connectionDAL.connectionDB();
            try
            {

                con.Open();
                string query_select = "SELECT * FROM tbl_users WHERE status=1 AND username=@username";
                MySqlCommand cmd = new MySqlCommand(query_select, con);
                cmd.Parameters.AddWithValue("@username", FormLogIn.loggedIn);
                MySqlDataReader row = cmd.ExecuteReader();
                while (row.Read())
                {
                    u.id = int.Parse(row[0].ToString());
                    u.name = row[1].ToString();
                    u.sDOB = row[2].ToString();
                    u.email = row[3].ToString();
                    u.mobile = row[7].ToString();
                    u.address = row[9].ToString();
                    u.gender = row[6].ToString();
                    u.user_type = row[8].ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        #endregion
    }
}
