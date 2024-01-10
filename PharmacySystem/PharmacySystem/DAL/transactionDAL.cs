using MySql.Data.MySqlClient;
using PhamicySysytem.DAL;
using PharmacySystem.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacySystem.DAL
{
    internal class transactionDAL
    {
        #region Connection String
        MySqlConnection con = connectionDAL.connectionDB();
        #endregion

        #region Insert Data in Database
        public bool Insert_Transaction(transctionsBLL t, out int transactionID)
        {
            bool isSuccess = false;
            transactionID = -1;

            try
            {
                transactionID = CID(out isSuccess);
                string sql = "INSERT INTO tbl_transaction(id,c_name,total,added_date,added_by) VALUES(@id,@c_name,@total,@added_date,@added_by)";
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", transactionID);
                cmd.Parameters.AddWithValue("@c_name", t.c_name);
                cmd.Parameters.AddWithValue("@total", t.total);
                cmd.Parameters.AddWithValue("@added_date", t.added_date);
                cmd.Parameters.AddWithValue("@added_by", t.added_by);

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

        #region
        private int CID(out bool isSuccess)
        {
            int cid = 0;
            isSuccess=false;
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                string count = "SELECT COUNT(id) FROM tbl_transaction";
                MySqlCommand cmd = new MySqlCommand(count, con);
                int cou = int.Parse(cmd.ExecuteScalar().ToString())+1;
                if (cou == 0)
                {
                    cid = 0;
                    isSuccess=true;
                }
                else
                {
                    string sql = "select id from tbl_transaction ORDER BY id DESC LIMIT 1";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(sql, con);
                    
                    adapter.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        cid = int.Parse(dt.Rows[0]["id"].ToString()); isSuccess = true;
                    }
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
            return cid+1;
        }
        #endregion
    }
}
