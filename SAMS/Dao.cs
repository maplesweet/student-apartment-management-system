using System.Data.SqlClient;

namespace SAMS
{
    internal class Dao
    {
        public SqlConnection connect()
        {
            string str = @"Data Source=;Initial Catalog=;Integrated Security=TURE";//数据库连接字符串
            SqlConnection sc = new SqlConnection(str);//创建数据库连接对象
            sc.Open();//打开数据库
            return sc;//返回数据库连接对象
        }
        public SqlCommand command(string sql)
        {
            SqlCommand cmd=new SqlCommand(sql, connect());
            return cmd;
        }
        public int Execute(string sql)
        {
            return command(sql).ExecuteNonQuery();
        }
        public SqlDataReader read(string sql)
        {
            return command(sql).ExecuteReader();
        }
    }
}
