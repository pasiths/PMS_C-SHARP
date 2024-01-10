using MySql.Data.MySqlClient;
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
    internal class transactionDetailsDAL
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
                String sql = "SELECT * FROM tbl_transaction";
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

        #region Insert method for transaction detail
        public bool InsertTransactionDetails(transactionDetailsBLL td)
        {
            bool isSuccess = false;
            
            try
            {
                string sql = "Insert Into tbl_transaction_detail(c_id,p_id,p_price,qty,total,added_date,added_by) Values(@c_id,@p_id,@p_price,@qty,@total,@added_date,@added_by)";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                
                cmd.Parameters.AddWithValue("@p_id", td.p_id);
                cmd.Parameters.AddWithValue("@p_price", td.price);
                cmd.Parameters.AddWithValue("@qty", td.qty);
                cmd.Parameters.AddWithValue("@total", td.total);
                cmd.Parameters.AddWithValue("@c_id", td.c_id);
                cmd.Parameters.AddWithValue("@added_date", td.added_date);
                cmd.Parameters.AddWithValue("@added_by", td.added_by);

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
                String sql = "SELECT * FROM tbl_transaction_detail WHERE id LIKE '%" + keywords + "%' OR c_id LIKE '%" + keywords + "%' OR p_id LIKE '%" + keywords + "%' ";
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
