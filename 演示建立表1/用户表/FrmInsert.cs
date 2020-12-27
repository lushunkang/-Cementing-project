using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 演示建立表1
{
    public partial class FrmInsert : Form
    {
        public FrmInsert()
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

        private void button1_Click(object sender, EventArgs e)
        {
            var regex3 = new Regex(@"
                                        (?=.*^[0-9]*$)                     #必须包含数字                                                                                                          
                                        .{6,20}                         #至少8个字符，最多30个字符
                                         ", RegexOptions.Multiline | RegexOptions.IgnorePatternWhitespace);
            //校验密码是否符合
            bool pwdIsMatch3 = regex3.IsMatch(textBox1.Text);

            var regex1 = new Regex(@"
                                        (?=.*[0-9])                     #必须包含数字
                                        (?=.*[a-zA-Z])
                                        (?=([\x21-\x7e]+)[^a-zA-Z0-9])  #必须包含特殊符号#必须包含小写或大写字母                                      
                                        .{6,20}                         #至少8个字符，最多30个字符
                                         ", RegexOptions.Multiline | RegexOptions.IgnorePatternWhitespace);
            //校验密码是否符合
            bool pwdIsMatch1 = regex1.IsMatch(textBox3.Text);
            var regex2 = new Regex(@"
                                        (?=.*[0-9])                     #必须包含数字
                                        (?=.*[a-zA-Z]) 
                                        (?=([\x21-\x7e]+)[^a-zA-Z0-9])  #必须包含特殊符号#必须包含小写或大写字母                                      
                                        .{6,20}                         #至少8个字符，最多30个字符
                                         ", RegexOptions.Multiline | RegexOptions.IgnorePatternWhitespace);
            //校验密码是否符合
            bool pwdIsMatch2= regex2.IsMatch(textBox7.Text);
            var regex4 = new Regex(@"
                                        (?=.*^[0-9]*$)                     #必须包含数字                                                                                                          
                                        .{11,11}                         #至少8个字符，最多30个字符
                                         ", RegexOptions.Multiline | RegexOptions.IgnorePatternWhitespace);
            //校验密码是否符合
            bool pwdIsMatch4 = regex4.IsMatch(textBox5.Text);
            ////////////////////////////////////////////////
            if (pwdIsMatch3 == true)
            {
                if (pwdIsMatch1 == true && pwdIsMatch2 == true)
                {
                    if (textBox3.Text.Trim().Equals(textBox7.Text.Trim()))
                    {
                        if (pwdIsMatch4 == true)
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
                                    /*string po = "四级";
                                    string na = "管理员";
                                    string sql3 = "insert into power(账号,姓名,权限级别,修改时间，修改人) values('" + textBox1.Text + "','" + textBox4.Text + "','" + po + "','" + DateTime.Now + "'，'" + na + "')";
                                    Console.WriteLine(sql3);
                                    var res2 = mysqlDB.Edit(sql3);
                                    if (res2)
                                    { }
                                    else
                                    {
                                        MessageBox.Show("权限申请失败");
                                    }*/
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
                        else
                        {
                            MessageBox.Show("必须电话号码是11位纯数字的号码");
                        }
                    }
                        else
                        {
                            
                             MessageBox.Show("两次输入密码不一致,请重新输入");
                    }
                      

                }
                else
                {
                    MessageBox.Show("密码格式不对请输入字母加数字组合的6-20位");
                }
            }
            else
            {
                MessageBox.Show("账号格式不对请输入纯数字6-20位");
            }

           
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmInsert_Load(object sender, EventArgs e)
        {

        }

        private void FrmInsert_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)     //Ctrl+F1
            {
                btnSubmit_Click(this, EventArgs.Empty);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox3.PasswordChar == '*')
            {
                textBox3.PasswordChar = '\0';
            }
            else
            {
                textBox3.PasswordChar = '*';
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox3.PasswordChar == '*')
            {
                textBox3.PasswordChar = '\0';
            }
            else
            {
                textBox3.PasswordChar = '*';
            }
        }
    }
}
