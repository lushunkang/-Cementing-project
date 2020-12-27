using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 演示建立表1
{
    public partial class 钻井液定性表 : Form
    {
        public 钻井液定性表()
        {
            InitializeComponent();
            showDate();
        }
        MysqlDB mysqlDB;

        public void showDate() {
            mysqlDB = new MysqlDB("49.235.232.46", 3306, "cement", "123456");
            string sql = "select * from 钻井液沿裂缝压力穿透效应及钻井液有效封堵性对井壁稳定性表";

            var reader = mysqlDB.Get(sql);
            while (reader.Read())
            {
                int index = this.dataGridView1.Rows.Add();
                for (int i = 0; i < dataGridView1.Columns.Count; i++) {

                    this.dataGridView1.Rows[index].Cells[i].Value = reader[i];
                }
            }

            //绑定数据集
            num.DataSource = mysqlDB.getWellNum();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            //弹出窗体
            FrmInsertzhuan frmInsert = new FrmInsertzhuan();
            frmInsert.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                //遍历选中行
                foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        string sql = "DELETE FROM 钻井液沿裂缝压力穿透效应及钻井液有效封堵性对井壁稳定性表 WHERE 序号=" + row.Cells[0].Value;
                        Console.WriteLine(sql);
                        var res = mysqlDB.Edit(sql);
                        if (res)
                        {
                            MessageBox.Show("删除成功");
                        }
                        else
                        {
                            MessageBox.Show("删除失败");
                        }
                        this.dataGridView1.Rows.Remove(row);
                    }
                }
            }
            else
            {
                MessageBox.Show("请选择删除行！");
            }
        }


        private Boolean isUpdate = false;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(change_column.ToString());
            if (isUpdate) {
                var row = dataGridView1.Rows[change_column];

                string sql = "UPDATE 钻井液沿裂缝压力穿透效应及钻井液有效封堵性对井壁稳定性表 SET " +
                    "井号='" +row.Cells[1].Value+
                    "',深度=" + row.Cells[2].Value +
                    ",井壁径向渗流能力=" + row.Cells[3].Value +
                    ",井壁径向与层理面法向夹角=" + row.Cells[4].Value +
                    ",井筒_地层渗流场及孔=" + row.Cells[5].Value +
                    " WHERE " +
                    "序号=" + row.Cells[0].Value +
                    "";

                Console.WriteLine(sql);
                var res = mysqlDB.Edit(sql);
                if (res)
                {
                    MessageBox.Show("修改成功");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("修改失败");
                }
            }
            else
            {
                MessageBox.Show("没有数据可修改");
            }
            dataGridView1.Invalidate();
        }

        int change_column;
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            isUpdate = true;
            change_column = e.RowIndex;
            //dataGridView1[e.ColumnIndex, e.RowIndex].Style.BackColor = Color.Blue;//修改内容后变为蓝色 
        }

        private void lookup_Click(object sender, EventArgs e)
        {
            if (num.Text != "")
            {
                string sql = "select * from 钻井液沿裂缝压力穿透效应及钻井液有效封堵性对井壁稳定性表 where 井号='" + num.Text + "'";
                var reader = mysqlDB.Get(sql);
                dataGridView1.Rows.Clear();
                while (reader.Read())
                {
                    int index = this.dataGridView1.Rows.Add();
                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {

                        this.dataGridView1.Rows[index].Cells[i].Value = reader[i];
                    }
                }
            }
        }

        private void num_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)     //Ctrl+F1
            {
                lookup_Click(this, EventArgs.Empty);
            }
            if (e.KeyCode == Keys.S && e.Modifiers == Keys.Control)
            {
                btnUpdate.Focus();//焦点转移
                btnUpdate_Click(sender, e);
            }
            if (e.KeyCode == Keys.Delete)
            {
                btnDelete_Click(this, EventArgs.Empty);
            }
        }

        private void num_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void 钻井液定性表_Leave(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
