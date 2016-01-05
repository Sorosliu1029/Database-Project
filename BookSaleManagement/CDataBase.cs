using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BookSaleManagement
{
    class CDataBase
    {
        public static string connStr ;
        public static SqlConnection conn = new SqlConnection(connStr);

        // “读”数据的静态方法
        public static DataSet GetDataFromDB(string sqlStr)
        {
            conn.Open();
            SqlDataAdapter myAdapter = new SqlDataAdapter(sqlStr, conn);
            DataSet myDataSet = new DataSet();
            myDataSet.Clear();
            myAdapter.Fill(myDataSet);
            conn.Close();
            if (myDataSet.Tables[0].Rows.Count != 0)
            {
                return myDataSet;
            }
            else
            {
                return null;
            }
        }

        // “写”数据的静态方法
        public static bool UpdateDB(string sqlStr)
        {
            conn.Open();
            // 定义数据命令对象
            SqlCommand myCmd = new SqlCommand(sqlStr, conn);
            // 设置Command对象的CommandType属性
            myCmd.CommandType = CommandType.Text;
            // 执行SQL语句
            myCmd.ExecuteNonQuery();
            conn.Close();
            // 数据更新成功,返回true
            return true;
        }
    }
}
