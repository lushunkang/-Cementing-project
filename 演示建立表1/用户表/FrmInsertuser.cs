using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 演示建立表1
{
    public partial class FrmInsertuser : Form
    {
        public FrmInsertuser()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MysqlDB mysqlDB;
            mysqlDB = new MysqlDB("49.235.232.46", 3306, "cement", "123456");

            string type = null;
          
            try
            {
               string sql = "insert into user(用户账号,用户昵称,用户密码,用户真实姓名,用户联系方式,用户地址,用户注册时间) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + DateTime.Now + "')";
               

                Console.WriteLine(sql);
                var res = mysqlDB.Edit(sql);
                if (res)
                {
                    MessageBox.Show("添加成功");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("添加失败");
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("输入格式错误");
            }
        }
        string people = "1234";
        string po = "四级";
        private void button1_Click(object sender, EventArgs e)
        {
            MysqlDB mysqlDB;
            mysqlDB = new MysqlDB("49.235.232.46", 3306, "cement", "123456");

            string type = null;

            try
            {
                string sql = "insert into user(用户账号,用户昵称,用户密码,用户真实姓名,用户联系方式,用户地址,用户注册时间) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + DateTime.Now + "')";
                string sql2 = "insert into power(账号,姓名,权限级别,修改时间,修改人) values('" + textBox1.Text + "','" + textBox4.Text + "','" + po + "','" + DateTime.Now + "','" +people + "')";

                Console.WriteLine(sql);
                var res = mysqlDB.Edit(sql);
                if (res)
                {
                    MessageBox.Show("添加成功");
                    Console.WriteLine(sql2);
                    var res2 = mysqlDB.Edit(sql2);
                    if (res2)
                    {
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("添加失败");
                    }

                    this.Close();
                }
                else
                {
                    MessageBox.Show("添加失败");
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("输入格式错误");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmInsert_Load(object sender, EventArgs e)
        {

        }
    }
}
