using MySql.Data.MySqlClient;
using PhamicySysytem.BLL;
using PhamicySysytem.DAL;
using PharmacySystem.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacySystem.DAL
{
    internal class stockDAL
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
                String sql = "SELECT id,name,type,qty,price,man_id,added_date,added_by,updated_date,updated_by FROM tbl_stock WHERE status=1";
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
        public bool Insert(stockBLL s)
        {
            bool isSuccess = false;
            try
            {
                string sql = "Insert Into tbl_stock (name,type,qty,price,man_id,added_date,added_by,updated_date,updated_by,status) Values (@name,@type,@qty,@price,@man_id,@added_date,@added_by,@updated_date,@updated_by,@status)";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@name", s.name);
                cmd.Parameters.AddWithValue("@type", s.type);
                cmd.Parameters.AddWithValue("@qty", s.qty);
                cmd.Parameters.AddWithValue("@price", s.price);
                cmd.Parameters.AddWithValue("@man_id", s.man_id);
                cmd.Parameters.AddWithValue("@added_date", s.added_date);
                cmd.Parameters.AddWithValue("@added_by", s.added_by);
                cmd.Parameters.AddWithValue("@updated_date", s.added_date);
                cmd.Parameters.AddWithValue("@updated_by", s.added_by);
                cmd.Parameters.AddWithValue("@status", s.status);
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
        public bool Update(stockBLL s)
        {
            bool isSuccess = false;
            try
            {
                string query = "Update tbl_stock Set name=@name,type=@type,qty=@qty,price=@price,man_id=@man_id,updated_date=@updated_date,updated_by=@updated_by Where id=@id";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", s.name);
                cmd.Parameters.AddWithValue("@type", s.type);
                cmd.Parameters.AddWithValue("@qty", s.qty);
                cmd.Parameters.AddWithValue("@price", s.price);
                cmd.Parameters.AddWithValue("@man_id", s.man_id);
                cmd.Parameters.AddWithValue("@updated_date", s.updated_date);
                cmd.Parameters.AddWithValue("@updated_by", s.updated_by);
                cmd.Parameters.AddWithValue("@id", s.id);

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

        #region Delete data in Database
        public bool Delete(stockBLL s)
        {
            bool isSuccess = false;

            try
            {
                string sql = "UPDATE tbl_stock SET status=@status WHERE id=@id";
                MySqlCommand cmd = new MySqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@status", s.status);

                cmd.Parameters.AddWithValue("@id", s.id);

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

                String sql = "SELECT id,name,type,qty,price,man_id,added_date,added_by,updated_date,updated_by FROM tbl_stock WHERE status=1 AND id LIKE '%" + keywords + "%' OR status=1 AND name LIKE '%" + keywords + "%' OR status=1 AND type LIKE '%" + keywords + "%' ";
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

        #region Method to get current quantity from the database based on product ID
        public int GetProductQty(int productID)
        {
            int qty = 0;
            DataTable dt = new DataTable();
            try
            {
                string sql = "Select qty From tbl_stock Where id=@id";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", productID);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                con.Open();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    qty = int.Parse(dt.Rows[0]["qty"].ToString());
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
            return qty;
        }
        #endregion

        #region method to update quantity
        public bool UpdateQuantity(int ProductID, int Qty)
        {
            bool isSuccess = false;
            try
            {
                string query = "Update tbl_stock Set qty=@qty Where id=@id";
                MySqlCommand cmd = new MySqlCommand(query, con);

                int currentQty = GetProductQty(ProductID);
                int NewQty = currentQty - Qty;
                cmd.Parameters.AddWithValue("@qty", NewQty);
                cmd.Parameters.AddWithValue("@id", ProductID);

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

        #region Select Data From Database
        public DataTable ViewNoStock()
        {
            DataTable dt = new DataTable();
            try
            {
                String sql = "SELECT id,name,type,qty,price,man_id,added_date,added_by,updated_date,updated_by FROM tbl_stock WHERE status=1 AND qty=0";
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

        #region Search User on Database using Keywords
        public DataTable ViewStock(string keywords)
        {

            DataTable dt = new DataTable();
            try
            {
                String sql = "SELECT id,name,type,qty,price FROM tbl_stock WHERE qty!=0 AND status=1 AND id LIKE '%" + keywords + "%' OR qty!=0 AND  status=1 AND name LIKE '%" + keywords + "%' OR qty!=0 AND  status=1 AND type LIKE '%" + keywords + "%' ";
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
