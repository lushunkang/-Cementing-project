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
using 演示建立表1;

namespace 演示建立表1
{
    public partial class manaInsert : Form
    {
        public DataGridView d1;
       
        public manaInsert()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (zhanghao.Text != "" & nicheng.Text != ""&mima.Text!=""&xingming.Text!=""&lianxi.Text!=""&dizhi.Text!=""&dateTimePicker1.Value!=null)
            {
                MysqlDB mysqlDB;
                mysqlDB = new MysqlDB("49.235.232.46", 3306, "cement", "123456");
                try
                {
                    //string sql1 = "insert into power values (" + "'" + zhanghao.Text + "'" + "," + "'" + xingming.Text + "'" + "," + "'" + "管理员" + "'" + "," + "'" +DateTime.Today+ "'" +","+ "'"+"修改人"+"'"+")";
                    string sql = "insert into management values (" + "'" + zhanghao.Text + "'" + "," + "'" + nicheng.Text + "'" + "," + "'" + mima.Text + "'" + "," + "'" + xingming.Text + "'" + "," + "'" + lianxi.Text + "'" + "," + "'" + dizhi.Text + "'" + "," + "'" + DateTime.Today + "'" + "," + "'" + dateTimePicker1.Value.ToString() + "'" + ")";
                    Console.WriteLine(sql);
                    //Console.WriteLine(sql1);
                    var res = mysqlDB.Edit(sql);
                    //var res1 = mysqlDB.Edit(sql1);

                    if (res)
                    {
                        MessageBox.Show("添加成功");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("添加失败");
                    }
                    /*  if (res1)
                      {
                          MessageBox.Show("权限表更新成功");
                          this.Close();
                      }
                      else
                      {
                          MessageBox.Show("权限表更新失败");
                      }*/
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("输入格式错误");
                }
            }
            else
            {
                MessageBox.Show("请将输入信息填写完整");
            }
            
        }

        private void FrmInsert_Load(object sender, EventArgs e)
        {
            shijian.Text = DateTime.Today.ToString().Substring(0,10);
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(47, 161, 243);
            this.button1.BackColor = System.Drawing.Color.FromArgb(255, 128, 128);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dizhi_Validated(object sender, EventArgs e)
        {
           

        }

        private void zhanghao_Validated(object sender, EventArgs e)
        {
            
        }

        private void nicheng_Validated(object sender, EventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
           
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text != mima.Text)
                errorProvider7.SetError(textBox1, "两次输入密码不相同");
            else
                errorProvider7.SetError(textBox1, string.Empty);
        }

        private void mima_Validated(object sender, EventArgs e)
        {
            
        }

        private void lianxi_Validated(object sender, EventArgs e)
        {
            
            
        }

        private void xingming_Validated(object sender, EventArgs e)
        {
           
        }

        private void shijian_TextChanged(object sender, EventArgs e)
        {

        }

        private void zhanghao_Validating(object sender, CancelEventArgs e)
        {
            
        }

        public void zhanghao_Leave(object sender, EventArgs e)
        {
            var regex2 = new Regex(@"
                                        (?=.*[0-9])                     #必须包含数字
                                         (?=.*[a-zA-Z])                 #必须包含小写或大写字母 
                                                                        #必须包含特殊符号                                     
                                        .{6,20}                         #至少6个字符，最多20个字符
                                         ", RegexOptions.Multiline | RegexOptions.IgnorePatternWhitespace);
            //校验密码是否符合
            bool pwdIsMatch2 = regex2.IsMatch(zhanghao.Text);
            Console.WriteLine(pwdIsMatch2);
            if(pwdIsMatch2 == true)
            {
                MysqlDB mysqlDB;
                mysqlDB = new MysqlDB("49.235.232.46", 3306, "cement", "123456");
                try
                {
                    string sql = "select 管理员账号 from management";
                    Console.WriteLine(sql);
                    var res = mysqlDB.Get(sql);
                    List<string> list = new List<string>();
                    while (res.Read())
                    {
                        string str = res.GetString("管理员账号");
                        list.Add(str);
                    }
                    if (list.Contains(zhanghao.Text))
                    {
                        errorProvider1.SetError(zhanghao, "管理员账号已存在！");
                        Console.WriteLine("正确");
                    }
                    else if (string.IsNullOrEmpty(zhanghao.Text))
                    {
                        errorProvider1.SetError(zhanghao, "不能为空！");
                    }
                    else
                    {
                        errorProvider1.Clear();
                    }
                    //var res1 = mysqlDB.Edit(sql1);

                }
                catch (System.FormatException)
                {
                    MessageBox.Show("输入格式错误");
                }

            }
            else if(pwdIsMatch2 == false)
            {
                errorProvider1.SetError(zhanghao, "账号必须在8-30位之间，且需要包含数字和字母！");
            }
            

            //ErrorProvider errorProvider = new ErrorProvider();

        }

        private void mima_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void zhanghao_MouseClick(object sender, MouseEventArgs e)
        {
            //errorProvider1.Clear();
        }

        private void nicheng_Leave(object sender, EventArgs e)
        {
            //每次如果输入完成，触发此事件
            if (string.IsNullOrEmpty(nicheng.Text))
                errorProvider2.SetError(nicheng, "不能为空！");
            else
                errorProvider2.SetError(nicheng, string.Empty);
        }

        private void mima_Leave(object sender, EventArgs e)
        {
            var regex1 = new Regex(@"
                                        (?=.*[0-9])                     #必须包含数字
                                         (?=.*[a-zA-Z])                 #(?=.*[a-zA-Z])必须包含小写或大写字母         
                                       (?=([\x21-\x7e]+)[^a-zA-Z0-9])   #必须包含特殊符号                                      
                                        .{6,20}                         #至少8个字符，最多30个字符
                                         ", RegexOptions.Multiline | RegexOptions.IgnorePatternWhitespace);
            //校验密码是否符合
            bool pwdIsMatch1 = regex1.IsMatch(mima.Text);
            if (pwdIsMatch1 == false)
            {
                errorProvider3.SetError(mima, "密码必须包含数字字母以及特殊字符且长度在8-30字符之间！");
            }
            else if (string.IsNullOrEmpty(mima.Text))
                errorProvider3.SetError(mima, "不能为空！");
            else
                errorProvider3.Clear();
        }

        private void lianxi_Leave(object sender, EventArgs e)
        {
            //电信手机号码正则        
            string dianxin = @"^1[35789][01379]\d{8}$";
            Regex dReg = new Regex(dianxin);
            //联通手机号正则        
            string liantong = @"^1[345678][01256]\d{8}$";
            Regex tReg = new Regex(liantong);
            //移动手机号正则        
            string yidong = @"^(134[012345678]\d{7}|1[34578][012356789]\d{8})$";
            Regex yReg = new Regex(yidong);

            if (dReg.IsMatch(lianxi.Text) || tReg.IsMatch(lianxi.Text) || yReg.IsMatch(lianxi.Text))
            {
                errorProvider4.Clear();
            }
            else
            {

                errorProvider4.SetError(lianxi, "您输入的手机号不正确！");
                lianxi.Text = "";
            }
        }

        private void xingming_Leave(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(xingming.Text))
                errorProvider5.SetError(xingming, "不能为空！");
            else
                errorProvider5.SetError(xingming, string.Empty);
        }

        private void dizhi_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dizhi.Text))
                errorProvider6.SetError(dizhi, "地址不能为空！");
            else
                errorProvider6.SetError(dizhi, string.Empty);
        }

        private void manaInsert_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSubmit.Focus();
                this.btnSubmit_Click(sender, e);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (mima.PasswordChar.ToString()=="*")
            {
                mima.PasswordChar = '\0';
            }
            else
            {
                mima.PasswordChar = '*';
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (textBox1.PasswordChar.ToString() == "*")
            {
                textBox1.PasswordChar = '\0';
            }
            else
            {
                textBox1.PasswordChar = '*';
            }
        }
    }
}
