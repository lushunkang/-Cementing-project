using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Threading;

namespace 演示建立表1
{
    public partial class 启动生成界面 : Form
    {
        public static bool kaiguan=false;
        public 启动生成界面()
        {
            InitializeComponent();
            Thread th = new Thread(new ThreadStart(DoSplash));
            th.Start();
            Thread.Sleep(4000);
            th.Abort();
            Thread.Sleep(1000);
    }
        private void DoSplash()
        {
            启动飞溅屏 sp = new 启动飞溅屏();
            sp.ShowDialog();
            sp.Close();
        }
        //用户登录
        private void button1_Click(object sender, EventArgs e)
        {
            //检查账户密码是否为空
            if(textBox1.Text == "" || textBox2.Text == "" || (radioButton1.Checked==false && radioButton2.Checked==false))
            {
                MessageBox.Show("你的账号，密码为空，或者你没用选择身份按钮");   
               
            }
            else
            {
                
                    var regex1 = new Regex(@"
                                        (?=.*[0-9])                     #必须包含数字
                                                                        #(?=.*[a-zA-Z])必须包含小写或大写字母                                      
                                        .{6,20}                         #至少8个字符，最多30个字符
                                         ", RegexOptions.Multiline | RegexOptions.IgnorePatternWhitespace);
                    //校验密码是否符合
                    bool pwdIsMatch1 = regex1.IsMatch(textBox1.Text);
                    var regex2 = new Regex(@"
                                        (?=.*[0-9])                     #必须包含数字
                                         (?=.*[a-zA-Z])                 #必须包含小写或大写字母 
                                        (?=([\x21-\x7e]+)[^a-zA-Z0-9])  #必须包含特殊符号                                     
                                        .{6,20}                         #至少8个字符，最多30个字符
                                         ", RegexOptions.Multiline | RegexOptions.IgnorePatternWhitespace);
                    //校验密码是否符合
                    bool pwdIsMatch2 = regex2.IsMatch(textBox2.Text);
                    if (pwdIsMatch2 == true && pwdIsMatch1==true)
                    {
                        //登录数据库验证密码
                        MysqlDB mysqlDB;
                        mysqlDB = new MysqlDB("49.235.232.46", 3306, "cement", "123456");

                        //string type = null;
                        string username = textBox1.Text.Trim();
                        string userpassword = textBox2.Text.Trim();


                        //sql语句（谨慎使用drop，delete!!!）
                        string sql = "SELECT 管理员账号,管理员密码 FROM management";
                        string sql1 = "SELECT 用户账号,用户密码 FROM user";
                        if (textBox1.Text.Equals("")&textBox2.Text.Equals(""))
                            MessageBox.Show("用户名或密码不能为空");
                        else
                        {
                        if (radioButton1.Checked) { 
                            var reader = mysqlDB.Get(sql);
                            Dictionary<string, string> qqDict = new Dictionary<string, string>();// 用户密码字典
                            if (reader != null)
                            {
                                while (reader.Read())
                                {
                                    string name = reader.GetString("管理员账号");
                                    string pwd = reader.GetString("管理员密码");
                                    qqDict.Add(name, pwd);
                                }

                                if (textBox2.Text.Equals(""))
                                    MessageBox.Show("密码不能为空");
                                else
                                {
                                    String loginName = textBox1.Text;
                                    //User.Name = textBox1.Text;//将登陆名的text创给类的静态字段
                                    if (qqDict.ContainsKey(loginName))
                                    {
                                        if (textBox2.Text.Equals(qqDict[textBox1.Text]))
                                        {
                                            //MessageBox.Show("密码正确");
                                            //if(radioButton1.Checked)
                                            //管理员界面显示
                                            kaiguan = true;
                                                Form1 a = new Form1();
                                                a.ShowDialog();
                                                this.Hide();
                                        }
                                        else
                                            MessageBox.Show("密码错误");
                                    }
                                    else
                                        MessageBox.Show("无此用户名");
                                }
                            }
                            else
                            {
                                MessageBox.Show("出现网络连接问题");
                            }
                        }
                        else
                        {
                            var reader = mysqlDB.Get(sql1);
                            Dictionary<string, string> qqDict = new Dictionary<string, string>();// 用户密码字典
                            if (reader != null)
                            {
                                while (reader.Read())
                                {
                                    string name = reader.GetString("用户账号");
                                    string pwd = reader.GetString("用户密码");
                                    qqDict.Add(name, pwd);
                                }

                                if (textBox2.Text.Equals(""))
                                    MessageBox.Show("密码不能为空");
                                else
                                {
                                    String loginName = textBox1.Text;
                                    //User.Name = textBox1.Text;//将登陆名的text创给类的静态字段
                                    if (qqDict.ContainsKey(loginName))
                                    {
                                        if (textBox2.Text.Equals(qqDict[textBox1.Text]))
                                        {
                                            //MessageBox.Show("密码正确");
                                            //用户界面显示

                                            Form1 form1 = new Form1();
                                            form1.ShowDialog();
                                        }
                                        else
                                            MessageBox.Show("密码错误");
                                    }
                                    else
                                        MessageBox.Show("无此用户名");
                                }
                            }
                            else
                            {
                                MessageBox.Show("出现网络连接问题");
                            }
                        }
                    }
                        //Console.WriteLine("")
                    }
                    else
                    {
                        MessageBox.Show("请检验你输入的密码中是否含有特殊字符或空格，密码长度在6-20位，请重新输入");
                    }
                
            }
            //检验输入的密码
            

        }
        //注册用户
        private void label3_Click(object sender, EventArgs e)
        {
            manaInsert Create = new manaInsert();
            Create.Show();
        }
        int pass1 = 1;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(textBox2.PasswordChar=='\0')
            {
                this.textBox2.PasswordChar = '*';
            }
            else
            {
                this.textBox2.PasswordChar = '\0';
            }        
            //this.textBox1.TextMode = TextBoxMode.SingLine;

        }

        private void 启动生成界面_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            FrmInsert frmInsertuser = new FrmInsert();
            frmInsertuser.ShowDialog();
        }
    }
}
