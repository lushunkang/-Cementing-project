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
    public partial class manaInsert : Form
    {
        public manaInsert()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            MysqlDB mysqlDB;
            mysqlDB = new MysqlDB("49.235.232.46", 3306, "cement", "123456");
            try
            {
                //string sql1 = "insert into power values (" + "'" + zhanghao.Text + "'" + "," + "'" + xingming.Text + "'" + "," + "'" + "管理员" + "'" + "," + "'" +DateTime.Today+ "'" +","+ "'"+"修改人"+"'"+")";
                string sql = "insert into management values (" + "'" + zhanghao.Text + "'" + "," + "'" + nicheng.Text + "'" + "," + "'" + mima.Text + "'" + "," + "'" + xingming.Text + "'" + "," + "'" + lianxi.Text + "'" + "," + "'" + dizhi.Text + "'" + "," + "'" + DateTime.Today + "'" + "," + "'" + riqi.Text + "'" + ")";
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

        private void FrmInsert_Load(object sender, EventArgs e)
        {
            shijian.Text = DateTime.Today.ToString().Substring(0,10);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
