using MySql.Data.MySqlClient;
using PhamicySysytem.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhamicySysytem.DAL
{
    internal class categoriesDAL
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
                String sql = "SELECT id,title,description,added_date,added_by,updated_date,updated_by FROM tbl_categories WHERE status=1";
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
        public bool Insert(categoriesBLL c)
        {
            bool isSuccess = false;
            try
            {
                string sql = "Insert Into tbl_categories (title,description,added_date,added_by,updated_date,updated_by,status) Values (@title,@description,@added_date,@added_by,@updated_date,@updated_by,@status)";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@title", c.title);
                cmd.Parameters.AddWithValue("@description", c.description);
                cmd.Parameters.AddWithValue("@added_date", c.added_date);
                cmd.Parameters.AddWithValue("@added_by", c.added_by);
                cmd.Parameters.AddWithValue("@updated_date", c.added_date);
                cmd.Parameters.AddWithValue("@updated_by", c.added_by);
                cmd.Parameters.AddWithValue("@status", c.status);
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

        #region Update data in database
        public bool Update(categoriesBLL c)
        {
            bool isSuccess = false;
            try
            {
                string query = "Update tbl_categories Set title=@title,description=@description,updated_date=@updated_date,updated_by=@updated_by Where id=@id";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@title", c.title);
                cmd.Parameters.AddWithValue("@description", c.description);
                cmd.Parameters.AddWithValue("@updated_date", c.updated_date);
                cmd.Parameters.AddWithValue("@updated_by", c.updated_by);
                cmd.Parameters.AddWithValue("@id", c.id);

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

        #region Delete Data in Database
        public bool Delete(categoriesBLL c)
        {
            bool isSuccess = false;
            try
            {
                string sql = "UPDATE tbl_categories SET status=@status WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@status", c.status);
                cmd.Parameters.AddWithValue("@id", c.id);

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
                String sql = "SELECT id,title,description,added_date,added_by,updated_date,updated_by FROM tbl_categories WHERE status=1 AND id LIKE '%" + keywords + "%' OR status=1 AND title LIKE '%" + keywords + "%' OR status=1 AND description LIKE '%" + keywords + "%' ";
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

    }
}
