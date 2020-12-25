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
    public partial class FrmInsertrun : Form
    {
        public FrmInsertrun()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MysqlDB mysqlDB;
            mysqlDB = new MysqlDB("49.235.232.46", 3306, "cement", "123456");
            try
            {
                string sql = "INSERT 井眼轨迹表" +
                    "(井号,深度,井斜角,方位角,地层坍塌压力当量密度,时间)" +
                    " VALUE('" +
                    JingHao.Text + "'," +
                    (float)Convert.ToSingle(textHeight.Text) + "," +
                    (float)Convert.ToSingle(textJinxie.Text) + "," +
                    (float)Convert.ToSingle(textFangwei.Text) + "," +
                    (float)Convert.ToSingle(textMidu.Text) + ",'" +
                    DateTime.Now +
                    "')";

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

        private void FrmInsert_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
