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
    public partial class 井表 : Form
    {
        public 井表()
        {
            InitializeComponent();
            showDate();
        }
        MysqlDB mysqlDB;
        private void 地应力大小表_Load(object sender, EventArgs e)
        {
        }


        public void showDate() {
            mysqlDB = new MysqlDB("49.235.232.46", 3306, "cement", "123456");
            string sql = "select * from well";

            var reader = mysqlDB.Get(sql);
            while (reader.Read())
            {
                int index = this.dataGridView1.Rows.Add();
                for (int i = 0; i < dataGridView1.Columns.Count; i++) {

                    this.dataGridView1.Rows[index].Cells[i].Value = reader[i];
                }
            }
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            //弹出窗体
            FrmInsertwell frm = new FrmInsertwell();
            frm.Show();
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
                        string sql = "DELETE FROM well WHERE 井号='" + row.Cells[0].Value + "'";
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

                string sql = "UPDATE well SET " +
                    "井号='" +row.Cells[0].Value+
                    "',地点='" + row.Cells[1].Value +
                    "',负责人姓名='" + row.Cells[2].Value +
                    "',负责人电话='" + row.Cells[3].Value +
                    "',负责人地址='" + row.Cells[4].Value +
                    "',开井时间='" + row.Cells[5].Value +
                    "' WHERE " +
                    "井号='" + row.Cells[0].Value +
                    "'";

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
                mysqlDB = new MysqlDB("49.235.232.46", 3306, "cement", "123456");
                string sql = "select * from well where 井号='" + num.Text + "'";

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

        private void 地应力大小表_Activated(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            showDate();
        }
    }

}
