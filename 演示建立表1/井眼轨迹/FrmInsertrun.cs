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
    public partial class FrmInsertrun : Form
    {
        private 井眼轨迹表 f1;
        public FrmInsertrun()
        {
            InitializeComponent();
        }

        public FrmInsertrun(井眼轨迹表 f)
        {
            InitializeComponent();
            f1 = f;

        }
        MysqlDB mysqlDB;
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
                    f1.dataGridView1_refresh();
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
            mysqlDB = new MysqlDB("49.235.232.46", 3306, "cement", "123456");
            JingHao.DataSource = mysqlDB.getWellNum();
        }



        private void FrmInsertrun_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSubmit.Focus();//焦点转移
                btnSubmit_Click(sender, e);
            }

            if (e.KeyCode == Keys.Escape)
            {
                btnCancel.Focus();//焦点转移
                btnCancel_Click(sender, e);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textHeight_KeyPress(object sender, KeyPressEventArgs e)
        {

            char c = e.KeyChar;
            if (c == '\b') return;
            if (c >= '０' && c <= '９')   // 将全角的数字转换成英文的数字
            {
                e.KeyChar = (char)('0' + c - '０');
                return;
            }
            else if (c == '－')     // 将全角的负号转换成英文的负号
            {
                e.KeyChar = '-';
                return;
            }
            else if (c == '．' || c == '。')    // 将全角的小数点转换成英文的小数点
            {
                e.KeyChar = '.';
                return;
            }
            TextBox txtBox = (TextBox)sender;
            if (txtBox.Tag == null) return;   // 空，则不判断是飞正确
            string input = txtBox.Text;
            input = input.Substring(0, txtBox.SelectionStart) + c + input.Substring(txtBox.SelectionLength + txtBox.SelectionStart);   // 根据光标位置确定可能的输入串
            int flag = int.Parse(txtBox.Tag.ToString());
            string s = @"(?!0)\d+";
            if ((flag & 2) != 0) s += @"(\.\d*)?|0(\.\d*)?";    // 允许小数
            s = @"(" + s + @")?";
            if ((flag & 4) != 0) s = @"-?" + s;                 // 允许负数
            if ((flag & 1) != 0) s += "|0";                     // 允许 0
            s = @"(?n)^(" + s + ")$";
            if (Regex.IsMatch(input, s)) return;                // 满足条件，返回
            e.Handled = true;                                   // 忽略该输入}
        }

        private void textJinxie_KeyPress(object sender, KeyPressEventArgs e)
        {

            char c = e.KeyChar;
            if (c == '\b') return;
            if (c >= '０' && c <= '９')   // 将全角的数字转换成英文的数字
            {
                e.KeyChar = (char)('0' + c - '０');
                return;
            }
            else if (c == '－')     // 将全角的负号转换成英文的负号
            {
                e.KeyChar = '-';
                return;
            }
            else if (c == '．' || c == '。')    // 将全角的小数点转换成英文的小数点
            {
                e.KeyChar = '.';
                return;
            }
            TextBox txtBox = (TextBox)sender;
            if (txtBox.Tag == null) return;   // 空，则不判断是飞正确
            string input = txtBox.Text;
            input = input.Substring(0, txtBox.SelectionStart) + c + input.Substring(txtBox.SelectionLength + txtBox.SelectionStart);   // 根据光标位置确定可能的输入串
            int flag = int.Parse(txtBox.Tag.ToString());
            string s = @"(?!0)\d+";
            if ((flag & 2) != 0) s += @"(\.\d*)?|0(\.\d*)?";    // 允许小数
            s = @"(" + s + @")?";
            if ((flag & 4) != 0) s = @"-?" + s;                 // 允许负数
            if ((flag & 1) != 0) s += "|0";                     // 允许 0
            s = @"(?n)^(" + s + ")$";
            if (Regex.IsMatch(input, s)) return;                // 满足条件，返回
            e.Handled = true;                                   // 忽略该输入}
        }

        private void textFangwei_KeyPress(object sender, KeyPressEventArgs e)
        {

            char c = e.KeyChar;
            if (c == '\b') return;
            if (c >= '０' && c <= '９')   // 将全角的数字转换成英文的数字
            {
                e.KeyChar = (char)('0' + c - '０');
                return;
            }
            else if (c == '－')     // 将全角的负号转换成英文的负号
            {
                e.KeyChar = '-';
                return;
            }
            else if (c == '．' || c == '。')    // 将全角的小数点转换成英文的小数点
            {
                e.KeyChar = '.';
                return;
            }
            TextBox txtBox = (TextBox)sender;
            if (txtBox.Tag == null) return;   // 空，则不判断是飞正确
            string input = txtBox.Text;
            input = input.Substring(0, txtBox.SelectionStart) + c + input.Substring(txtBox.SelectionLength + txtBox.SelectionStart);   // 根据光标位置确定可能的输入串
            int flag = int.Parse(txtBox.Tag.ToString());
            string s = @"(?!0)\d+";
            if ((flag & 2) != 0) s += @"(\.\d*)?|0(\.\d*)?";    // 允许小数
            s = @"(" + s + @")?";
            if ((flag & 4) != 0) s = @"-?" + s;                 // 允许负数
            if ((flag & 1) != 0) s += "|0";                     // 允许 0
            s = @"(?n)^(" + s + ")$";
            if (Regex.IsMatch(input, s)) return;                // 满足条件，返回
            e.Handled = true;                                   // 忽略该输入}
        }

        private void textMidu_KeyPress(object sender, KeyPressEventArgs e)
        {

            char c = e.KeyChar;
            if (c == '\b') return;
            if (c >= '０' && c <= '９')   // 将全角的数字转换成英文的数字
            {
                e.KeyChar = (char)('0' + c - '０');
                return;
            }
            else if (c == '－')     // 将全角的负号转换成英文的负号
            {
                e.KeyChar = '-';
                return;
            }
            else if (c == '．' || c == '。')    // 将全角的小数点转换成英文的小数点
            {
                e.KeyChar = '.';
                return;
            }
            TextBox txtBox = (TextBox)sender;
            if (txtBox.Tag == null) return;   // 空，则不判断是飞正确
            string input = txtBox.Text;
            input = input.Substring(0, txtBox.SelectionStart) + c + input.Substring(txtBox.SelectionLength + txtBox.SelectionStart);   // 根据光标位置确定可能的输入串
            int flag = int.Parse(txtBox.Tag.ToString());
            string s = @"(?!0)\d+";
            if ((flag & 2) != 0) s += @"(\.\d*)?|0(\.\d*)?";    // 允许小数
            s = @"(" + s + @")?";
            if ((flag & 4) != 0) s = @"-?" + s;                 // 允许负数
            if ((flag & 1) != 0) s += "|0";                     // 允许 0
            s = @"(?n)^(" + s + ")$";
            if (Regex.IsMatch(input, s)) return;                // 满足条件，返回
            e.Handled = true;                                   // 忽略该输入}
        }
    }
}
