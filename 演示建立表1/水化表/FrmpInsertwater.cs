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
    public partial class FrmpInsertwater : Form
    {
        public FrmpInsertwater()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MysqlDB mysqlDB;
            mysqlDB = new MysqlDB("49.235.232.46", 3306, "cement", "123456");
            int i = 1;
         
            try
            {
                
                string sql = "INSERT into shuihua(井号,深度,黏土矿物类型,含量分布,水化作用强度,时间)" +
                    " VALUE('" +
                      JingHao.Text+"'" + ','+
                  "'"+textX.Text+ "'" + "," +
                   "'"+ textY.Text + "'"+ "," 
                   +"'"+ textZ.Text + "'"+"," 
                   +"'"+ textH.Text + "'"+ "," +
                    "'" + DateTime.Now + "'" +
                    ")";

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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmpInsert_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
