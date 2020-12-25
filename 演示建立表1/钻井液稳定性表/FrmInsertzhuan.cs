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
    public partial class FrmInsertzhuan : Form
    {
        public FrmInsertzhuan()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MysqlDB mysqlDB;
            mysqlDB = new MysqlDB("49.235.232.46", 3306, "cement", "123456");
            try
            {
                string sql = "INSERT 钻井液沿裂缝压力穿透效应及钻井液有效封堵性对井壁稳定性表" +
                    "(井号,深度,井壁径向渗流能力,井壁径向与层理面法向夹角,井筒_地层渗流场及孔)" +
                    " VALUE('" +
                    JingHao.Text + "'," +
                    (float)Convert.ToSingle(textHeight.Text) + "," +
                    (float)Convert.ToSingle(textShenLiu.Text) + "," +
                    (float)Convert.ToSingle(textJiaJiao.Text) + "," +
                    (float)Convert.ToSingle(textKong.Text) +
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

        private void FrmInsert_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
