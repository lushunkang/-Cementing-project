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
    public partial class powerdata : Form
    {
        public powerdata()
        {
            InitializeComponent();
            showDate();
        }
        MysqlDB mysqlDB;
     


        public void showDate() {
            mysqlDB = new MysqlDB("49.235.232.46", 3306, "cement", "123456");
            string sql = "select * from power";

            var reader = mysqlDB.Get(sql);
            while (reader.Read())
            {
                int index = this.dataGridView1.Rows.Add();
                for (int i = 0; i < dataGridView1.Columns.Count; i++) {

                    this.dataGridView1.Rows[index].Cells[i].Value = reader[i];
                }
            }
        }
                                            
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //遍历选中行
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        string sql = "DELETE FROM power WHERE 账号='" + row.Cells[0].Value + "'";
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

                string sql = "UPDATE power SET " +
                    "姓名='" + row.Cells[1].Value +
                    "',权限级别='" + row.Cells[2].Value +
                    "',修改时间='" + DateTime.Now +
                    "',修改人='" + row.Cells[4].Value +
                    "' WHERE " +
                    "账号='" + row.Cells[0].Value +
                    "'";

                Console.WriteLine(sql);
                var res = mysqlDB.Edit(sql);
                if (res)
                {
                    MessageBox.Show("修改成功");
                    dataGridView1.Rows.Clear();
                    showDate();
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

                string sql = "select * from power where 账号='" + num.Text + "'";

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

        private void powerdata_Load(object sender, EventArgs e)
        {

        }

        private void powerdata_KeyDown(object sender, KeyEventArgs e)
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
    }

}
