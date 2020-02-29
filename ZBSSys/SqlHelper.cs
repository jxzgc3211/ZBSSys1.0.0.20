using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ZBSSys
{
    public static class SqlHelper
    {
        //上线用
        public static string connStr = ConfigurationManager.ConnectionStrings["fabuZBS"].ConnectionString;
        //单机测试用
        //public static string connStr = ConfigurationManager.ConnectionStrings["dbZBS"].ConnectionString;
        public static DataTable ExecuteTable(string sql, params SqlParameter[] ps)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                sda.SelectCommand.Parameters.AddRange(ps);
                sda.Fill(dt);
                return dt;
            }
        }

        public static int ExecuteNonQuery(string sql, params SqlParameter[] ps)
        {
            //执行增、删、改的操作
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddRange(ps);
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static int ExecuteNonQuery(string sql, CommandType commandType, params SqlParameter[] ps)
        {
          
            //执行增、删、改的操作
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.CommandType = commandType;
                    cmd.Parameters.AddRange(ps);
                    conn.Open();
                    return cmd.ExecuteNonQuery();
                    
                }
            }
        }
        public static object ExecutScalar(string sql, params SqlParameter[] ps)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddRange(ps);
                    return cmd.ExecuteScalar();
                }
            }
        }
        public static SqlDataReader ExecuteReader(string sql, params SqlParameter[] ps)
        {
            //创建数据库连接对象
            SqlConnection conn = new SqlConnection(connStr);
            //常见数据库操作对象
            SqlCommand cmd = new SqlCommand(sql, conn);
            //可变数组ps的长度，无参数就不执行下面的判断
            if (ps.Length > 0)
            {
                cmd.Parameters.AddRange(ps);
            }
            //打开数据库的连接
            conn.Open();
            //执行并反馈数据库的查询结果，其中CommandBehavior.CloseConnection，表示Reader使用
            //完成后，再关闭SqlDataReader时，会自动关闭使用的数据库连接
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }
    }
}
