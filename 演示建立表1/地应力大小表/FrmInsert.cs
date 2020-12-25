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
    public partial class FrmInsert : Form
    {
        public FrmInsert()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MysqlDB mysqlDB;
            mysqlDB = new MysqlDB("49.235.232.46", 3306, "cement", "123456");

            string type = null;
            if (Zheng.Checked) {
                type = "潜在正断层类";
            }
            if (ZouHua.Checked) {
                type = "潜在走滑断层类";
            }
            if (NiChong.Checked) {
                type = "潜在逆冲断层类";
            }
            try
            {
                string sql = "INSERT 地应力大小表(井号,地应力类型,地应力X大小,地应力Y大小,地应力Z大小,深度,记录时间)" +
                    " VALUE('" +
                    JingHao.Text + "'," +
                    "'" + type + "'," +
                    (float)Convert.ToSingle(textX.Text) + "," +
                    (float)Convert.ToSingle(textY.Text) + "," +
                    (float)Convert.ToSingle(textZ.Text) + "," +
                    (float)Convert.ToSingle(textHeight.Text) + "," +
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
