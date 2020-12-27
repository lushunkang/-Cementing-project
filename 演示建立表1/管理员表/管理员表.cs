﻿using System;
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
    public partial class 管理员表 : Form
    {
        public 管理员表()
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
            string sql = "select * from management";

            var reader = mysqlDB.Get(sql);
            while (reader.Read())
            {
                int index = this.dataGridView1.Rows.Add();
                for (int i = 0; i < dataGridView1.Columns.Count; i++) {

                    this.dataGridView1.Rows[index].Cells[i].Value = reader[i];
                }
            }
            num.DataSource = mysqlDB.getmanaNum2();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            //弹出窗体
            manaInsert frmInsert = new manaInsert();
            frmInsert.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (this.dataGridView1.SelectedRows.Count > 0)
            {//遍历选中行
                foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        string sql = "DELETE FROM management WHERE 管理员账号=" + "'" + row.Cells[0].Value + "'";
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

                /*string sql = "UPDATE 地应力大小表 SET " +
                    "井号='" +row.Cells[1].Value+
                    "',地应力类型='" + row.Cells[2].Value +
                    "',地应力X大小=" + row.Cells[3].Value +
                    ",地应力Y大小=" + row.Cells[4].Value +
                    ",地应力Z大小=" + row.Cells[5].Value +
                    ",深度=" + row.Cells[6].Value +
                    ",记录时间='" +DateTime.Now+
                    "' WHERE " +
                    "序号=" + row.Cells[0].Value +
                    "";*/
                string updateSql = "update management set 管理员昵称 =" + "'" + row.Cells[1].Value + "'" + ",管理员密码=" + "'" + row.Cells[2].Value + "'" + ",管理员姓名=" + "'" + row.Cells[3].Value + "'" + ",管理员联系方式=" + "'" + row.Cells[4].Value + "'" + ",管理员地址=" + "'" + row.Cells[5].Value + "'" + ",管理员注册时间=" + "'" + row.Cells[6].Value + "'" + ",管理员出生日期=" + "'" + row.Cells[7].Value + "'" + " where 管理员账号 =" + "'" + row.Cells[0].Value + "'";
                Console.WriteLine(updateSql);
                var res = mysqlDB.Edit(updateSql);
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
            string sql = "select * from management where 管理员账号='" +num.Text +"'";

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

        private void 管理员表_Leave(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
