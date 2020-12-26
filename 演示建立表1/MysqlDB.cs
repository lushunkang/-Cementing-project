using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 演示建立表1
{
    class MysqlDB
    {
        private string connetStr;
        // server=127.0.0.1/localhost 代表本机，端口号port默认是3306可以不写
        private MySqlConnection conn;

        //构造方法
        public MysqlDB(string ip, int port, string DBname, string DBpwd)
        {
            this.connetStr = "server=" + ip +
                ";port=" + port +
                ";user=" + DBname +
                ";password=" + DBpwd +
                "; database=" + DBname +
                ";";
        }

        //连接方法
        public void Connect()
        {
            conn = new MySqlConnection(connetStr);
            try
            {
                conn.Open();//打开通道，建立连接，可能出现异常,使用try catch语句
                Console.WriteLine("已经建立连接");
                //在这里使用代码对数据库进行增删查改
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show(ex.Message);//打印错误信息
            }
            finally
            {
                //conn.Close();
            }
        }
        //获取井号
        public IList<string> getWellNum() {
            IList<string> list = new List<string>();
            string sql2 = "SELECT 井号 FROM well";
            var res = this.Get(sql2);
            while (res.Read())
            {
                list.Add(res["井号"].ToString());
            }
            return list;
        }



        //查询方法
        public MySqlDataReader Get(string sql)
        {
            this.Connect();//连接数据库
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();//执行ExecuteReader()返回一个MySqlDataReader对象

                return reader;
            }
            catch (MySqlException ex)
            {
                return null;//操作失败，返回空值
                MessageBox.Show(ex.Message);//打印错误信息
            }

            //返回值使用方法
            //while (reader.Read())//初始索引是-1，执行读取下一行数据，返回值是bool
            // {
            //Console.WriteLine(reader[0].ToString() + reader[1].ToString() + reader[2].ToString());
            //Console.WriteLine(reader.GetInt32(0)+reader.GetString(1)+reader.GetString(2));
            //Console.WriteLine(reader.GetInt32("userid") + reader.GetString("username") + reader.GetString("password"));
            //"userid"是数据库对应的列名，推荐这种方式
            // }
        }

        //操作数据库
        public Boolean Edit(string sql)
        {
            this.Connect();//连接数据库
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();//执行ExecuteReader()返回一个MySqlDataReader对象
                return true;
            }
            catch (MySqlException ex)
            {
                return false;
                MessageBox.Show(ex.Message);//打印错误信息
            }

        }
    }
}
