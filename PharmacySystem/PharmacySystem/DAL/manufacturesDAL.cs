using PhamicySysytem.BLL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PhamicySysytem.DAL
{
    internal class manufacturesDAL
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
                String sql = "SELECT id,name,address,email,mobile,added_date,added_by,updated_date,updated_by FROM tbl_manufactures WHERE status=1";
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
        public bool Insert(manufacturesBLL m)
        {
            bool isSuccess = false;
            try
            {
                string sql = "Insert Into tbl_manufactures (name,address,email,mobile,added_date,added_by,updated_date,updated_by,status) Values (@name,@address,@email,@mobile,@added_date,@added_by,@updated_date,@updated_by,@status)";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@name", m.manufacturerName);
                cmd.Parameters.AddWithValue("@address", m.manufacturerAddress);
                cmd.Parameters.AddWithValue("@email", m.manufacturerEmail);
                cmd.Parameters.AddWithValue("@mobile", m.manufacturerMobile);
                cmd.Parameters.AddWithValue("@added_date", m.added_date);
                cmd.Parameters.AddWithValue("@added_by", m.added_by);
                cmd.Parameters.AddWithValue("@updated_date", m.added_date);
                cmd.Parameters.AddWithValue("@updated_by", m.added_by);
                cmd.Parameters.AddWithValue("@status", m.status);
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
            finally { con.Close(); }

            return isSuccess;
        }
        #endregion

        #region Update data in Database
        public bool Update(manufacturesBLL m)
        {
            bool isSuccess = false;

            try
            {
                string sql = "UPDATE tbl_manufactures SET name=@name,address=@address,email=@email,mobile=@mobile,updated_date=@updated_date,updated_by=@updated_by WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@name", m.manufacturerName);
                cmd.Parameters.AddWithValue("@address", m.manufacturerAddress);
                cmd.Parameters.AddWithValue("@email", m.manufacturerEmail);
                cmd.Parameters.AddWithValue("@mobile", m.manufacturerMobile);
                cmd.Parameters.AddWithValue("@updated_date", m.updated_date);
                cmd.Parameters.AddWithValue("@updated_by", m.updated_by);

                cmd.Parameters.AddWithValue("@id", m.manufacturerID);

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
        public bool Delete(manufacturesBLL m)
        {
            bool isSuccess = false;

            try
            {
                string sql = "UPDATE tbl_manufactures SET status=@status WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@status", m.status);

                cmd.Parameters.AddWithValue("@id", m.manufacturerID);

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
                String sql = "SELECT id,name,address,email,mobile,added_date,added_by,updated_date,updated_by FROM tbl_manufactures WHERE status=1 AND id LIKE '%" + keywords + "%' OR status=1 AND name LIKE '%" + keywords + "%' OR status=1 AND email LIKE '%" + keywords + "%' ";
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

        #region Find Manufacture Name
        public string FindName(string id)
        {
            string name=null;
            try
            {
                con.Open();
                string query_select = "SELECT * FROM tbl_manufactures WHERE status=1 AND id =@id ";
                MySqlCommand cmd = new MySqlCommand(query_select, con);
                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataReader row = cmd.ExecuteReader();
                while (row.Read())
                {
                    name = row[1].ToString();
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
            return name;
        }
        #endregion
    }
}
