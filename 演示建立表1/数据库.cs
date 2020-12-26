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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 用户表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try { 
                地应力大小表 a = new 地应力大小表();
                a.MdiParent = this;
                a.Show();
            }
            catch (System.InvalidOperationException)
            {
                地应力大小表 a = new 地应力大小表();
                a.MdiParent = this;
                a.Show();
            }

        }

        private void 井表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                井表 jingbiao = new 井表();
                jingbiao.MdiParent = this;
                jingbiao.Show();
            }
            catch (System.InvalidOperationException)
            {
                井表 jingbiao = new 井表();
                jingbiao.MdiParent = this;
                jingbiao.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void 权限表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                powerdata power = new powerdata();
                power.MdiParent = this;
                power.Show();
            }
            catch (System.InvalidOperationException)
            {
                powerdata power = new powerdata();
                power.MdiParent = this;
                power.Show();
            }
        }

        private void 用户表ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                用户表 user = new 用户表();
                user.MdiParent = this;
                user.Show();
            }
            catch (System.InvalidOperationException)
            {
                用户表 user = new 用户表();
                user.MdiParent = this;
                user.Show();
            }
        }

        private void 钻井液稳定性表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                钻井液定性表 zhuan = new 钻井液定性表();
                zhuan.MdiParent = this;
                zhuan.Show();
            }
            catch (System.InvalidOperationException)
            {
                钻井液定性表 zhuan = new 钻井液定性表();
                zhuan.MdiParent = this;
                zhuan.Show();
            }
        }

        private void 水化效应表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                水化作用强度表 fuction = new 水化作用强度表();
                fuction.MdiParent = this;
                fuction.Show();
            }
            catch (System.InvalidOperationException)
            {
                水化作用强度表 fuction = new 水化作用强度表();
                fuction.MdiParent = this;
                fuction.Show();
            }
        }

        private void 管理员表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                管理员表 mann = new 管理员表();
                mann.MdiParent = this;
                mann.Show();
            }
            catch (System.InvalidOperationException)
            {
                管理员表 mann = new 管理员表();
                mann.MdiParent = this;
                mann.Show();
            }
        }

        private void 井眼轨迹表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                井眼轨迹表 run = new 井眼轨迹表();
                run.MdiParent = this;
                run.Show();
            }
            catch (System.InvalidOperationException)
            {
                井眼轨迹表 run = new 井眼轨迹表();
                run.MdiParent = this;
                run.Show();
            }
        }
    }
}
