using System;
using System.Data;
using System.Data.SqlClient;

namespace S1Hotel
{
    class DBHelper
    {
        //创建数据库连接
        private static string str = @"Data Source=.;Initial Catalog=S1Hotel;Integrated Security=True";
        private SqlConnection con = new SqlConnection(str);

        /// <summary>
        /// 查询多个值的方法
        /// </summary>
        /// <param name="str"></param>
        /// <param name="sql"></param>
        /// <returns></returns>
        public SqlDataReader SelectDataReader(string sql)
        {
            con.Open();
            SqlCommand com = new SqlCommand(sql, con);
            return com.ExecuteReader(CommandBehavior.CloseConnection);//返回SqlDataReader关闭SqlConnection对象连接
        }

        /// <summary>
        /// 备用关闭数据库
        /// </summary>
        public void CloseConnection()
        {
            con.Close();
        }
        /// <summary>
        /// 增删改
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <returns></returns>
        public int ExecuteSQLCommand(string sql)
        {
            con.Open();
            SqlCommand com = new SqlCommand(sql, con);
            int a = com.ExecuteNonQuery();
            con.Close();
            return a;
        }

        /// <summary>
        /// 查询一张表的数据
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <param name="biaoMing"></param>
        /// <returns></returns>
        public DataSet GetDataSet(string sql, string biaoMing)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds, biaoMing);
            return ds;
        }

        /// <summary>
        /// 查询单个值并返回int类型
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public int GetSingleIntValue(string sql)
        {
            con.Open();
            SqlCommand com = new SqlCommand(sql, con);
            int a = 0;
            var t = com.ExecuteScalar();
            //当com.ExecuteScalar()等于空时就返回0；
            if (t == DBNull.Value || t == null)
            {

            }
            else
            {
                a = (int)com.ExecuteScalar();
            }
            con.Close();
            return a;
        }

        /// <summary>
        /// 查询单个值并返回double类型
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public double GetSingleDoubleValue(string sql)
        {
            con.Open();
            SqlCommand com = new SqlCommand(sql, con);
            double a = 0;
            var t = com.ExecuteScalar();
            //当com.ExecuteScalar()等于空时就返回0；
            if (t == DBNull.Value || t == null)
            {

            }
            else
            {
                a = Convert.ToDouble(com.ExecuteScalar());
            }
            con.Close();
            return a;
        }

        /// <summary>
        /// 计算时间重叠
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public bool CalcTimeOverlap(DateTime a, DateTime b, DateTime x, DateTime y)
        {
            //时间无重叠             
            return b >= x && y >= a;
            /*
            if ((b < x) || (y < a))
                return false;
            return true;
            */
        }
    }
}
