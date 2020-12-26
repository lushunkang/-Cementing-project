namespace 演示建立表1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.井表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.权限表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户表ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.钻井液稳定性表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.水化效应表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.管理员表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.井眼轨迹表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.井表ToolStripMenuItem,
            this.用户表ToolStripMenuItem,
            this.权限表ToolStripMenuItem,
            this.用户表ToolStripMenuItem1,
            this.钻井液稳定性表ToolStripMenuItem,
            this.水化效应表ToolStripMenuItem,
            this.管理员表ToolStripMenuItem,
            this.井眼轨迹表ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1311, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 井表ToolStripMenuItem
            // 
            this.井表ToolStripMenuItem.Name = "井表ToolStripMenuItem";
            this.井表ToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.井表ToolStripMenuItem.Text = "石油井基础数据";
            this.井表ToolStripMenuItem.Click += new System.EventHandler(this.井表ToolStripMenuItem_Click);
            // 
            // 用户表ToolStripMenuItem
            // 
            this.用户表ToolStripMenuItem.Name = "用户表ToolStripMenuItem";
            this.用户表ToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.用户表ToolStripMenuItem.Text = "地应力信息";
            this.用户表ToolStripMenuItem.Click += new System.EventHandler(this.用户表ToolStripMenuItem_Click);
            // 
            // 权限表ToolStripMenuItem
            // 
            this.权限表ToolStripMenuItem.Name = "权限表ToolStripMenuItem";
            this.权限表ToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.权限表ToolStripMenuItem.Text = "权限分配管理";
            this.权限表ToolStripMenuItem.Click += new System.EventHandler(this.权限表ToolStripMenuItem_Click);
            // 
            // 用户表ToolStripMenuItem1
            // 
            this.用户表ToolStripMenuItem1.Name = "用户表ToolStripMenuItem1";
            this.用户表ToolStripMenuItem1.Size = new System.Drawing.Size(81, 24);
            this.用户表ToolStripMenuItem1.Text = "用户信息";
            this.用户表ToolStripMenuItem1.Click += new System.EventHandler(this.用户表ToolStripMenuItem1_Click);
            // 
            // 钻井液稳定性表ToolStripMenuItem
            // 
            this.钻井液稳定性表ToolStripMenuItem.Name = "钻井液稳定性表ToolStripMenuItem";
            this.钻井液稳定性表ToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.钻井液稳定性表ToolStripMenuItem.Text = "钻井液稳定性分析";
            this.钻井液稳定性表ToolStripMenuItem.Click += new System.EventHandler(this.钻井液稳定性表ToolStripMenuItem_Click);
            // 
            // 水化效应表ToolStripMenuItem
            // 
            this.水化效应表ToolStripMenuItem.Name = "水化效应表ToolStripMenuItem";
            this.水化效应表ToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.水化效应表ToolStripMenuItem.Text = "水化效应信息";
            this.水化效应表ToolStripMenuItem.Click += new System.EventHandler(this.水化效应表ToolStripMenuItem_Click);
            // 
            // 管理员表ToolStripMenuItem
            // 
            this.管理员表ToolStripMenuItem.Name = "管理员表ToolStripMenuItem";
            this.管理员表ToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.管理员表ToolStripMenuItem.Text = "管理员信息";
            this.管理员表ToolStripMenuItem.Click += new System.EventHandler(this.管理员表ToolStripMenuItem_Click);
            // 
            // 井眼轨迹表ToolStripMenuItem
            // 
            this.井眼轨迹表ToolStripMenuItem.Name = "井眼轨迹表ToolStripMenuItem";
            this.井眼轨迹表ToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.井眼轨迹表ToolStripMenuItem.Text = "井眼轨迹信息";
            this.井眼轨迹表ToolStripMenuItem.Click += new System.EventHandler(this.井眼轨迹表ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 714);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximumSize = new System.Drawing.Size(1329, 761);
            this.MinimumSize = new System.Drawing.Size(1329, 761);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "井壁加固技术研究";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 用户表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 井表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 权限表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户表ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 钻井液稳定性表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 水化效应表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 管理员表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 井眼轨迹表ToolStripMenuItem;
    }
}

