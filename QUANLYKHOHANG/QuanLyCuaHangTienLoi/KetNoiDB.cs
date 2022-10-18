    using System;
    using System.Data;
    using System.Data.SqlClient;

    namespace QuanLyCuaHangTienLoi
    {
        public class KetNoiDB
        {
            public static SqlConnection connect;

            public void MoKetNoi()
            {
                if(KetNoiDB.connect == null)
                {
                    KetNoiDB.connect = new SqlConnection(@"Data Source=KHUCVANDINH\SQLEXPRESS01;Initial Catalog=QuanLyKho
;Integrated Security=True");
                }
                if(KetNoiDB.connect.State != ConnectionState.Open)
                {
                    KetNoiDB.connect.Open();
                }
            }

            public void DongKetNoi()
            {
                if(KetNoiDB.connect != null)
                {
                    if(KetNoiDB.connect.State == ConnectionState.Open)
                    {
                        KetNoiDB.connect.Close();
                    }
                }
            }

            public bool ThucThiCauLenh(string strSQL) // update, insert, delete
            {
                try
                {
                    MoKetNoi();
                    SqlCommand sqlcmd = new SqlCommand(strSQL, connect);
                    var result = sqlcmd.ExecuteNonQuery();
                    DongKetNoi();

                    return result > 0;
                }
                catch
                {
                    return false;
                }
            }

            public DataTable GetDataTable(string strSQL) // select
            {
                try
                {
                    MoKetNoi();
                    DataTable dt = new DataTable();
                    SqlDataAdapter sqlda = new SqlDataAdapter(strSQL, connect);
                    sqlda.Fill(dt);
                    DongKetNoi();
                    return dt;
                }
                catch
                {
                    return null;
                }
            }

            public DataSet GetDataSet(string strSQL) // select
            {
                try
                {
                    MoKetNoi();
                    DataSet ds = new DataSet();
                    SqlDataAdapter sqlda = new SqlDataAdapter(strSQL, connect);
                    sqlda.Fill(ds);
                    DongKetNoi();
                    return ds;
                }
                catch
                {
                    return null;
                }
            }

            public string GetValue(string strSQL) // select
            {
                string temp = null;
                MoKetNoi();
                SqlCommand sqlcmd = new SqlCommand(strSQL, connect);
                SqlDataReader sqldr = sqlcmd.ExecuteReader();
                while(sqldr.Read())
                {
                    temp = sqldr[0].ToString();
                }
                DongKetNoi();
                return temp;
            }
            
        }
    }
