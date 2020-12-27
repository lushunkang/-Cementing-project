
namespace 演示建立表1
{
    partial class FrmpInsertwater
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmpInsertwater));
            this.label1 = new System.Windows.Forms.Label();
            this.JingHao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textX = new System.Windows.Forms.TextBox();
            this.textZ = new System.Windows.Forms.TextBox();
            this.textH = new System.Windows.Forms.TextBox();
            this.textL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textY = new System.Windows.Forms.ComboBox();
            this.取消 = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "井号：";
            // 
            // JingHao
            // 
            this.JingHao.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.JingHao.Location = new System.Drawing.Point(109, 18);
            this.JingHao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.JingHao.Name = "JingHao";
            this.JingHao.Size = new System.Drawing.Size(175, 27);
            this.JingHao.TabIndex = 1;
            this.JingHao.TextChanged += new System.EventHandler(this.JingHao_TextChanged);
            this.JingHao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.JingHao_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(28, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "深度：";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(299, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "黏土矿物类型：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(329, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "含量分布：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(299, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "水化作用强度：";
            // 
            // textX
            // 
            this.textX.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textX.Location = new System.Drawing.Point(109, 102);
            this.textX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textX.Name = "textX";
            this.textX.Size = new System.Drawing.Size(175, 27);
            this.textX.TabIndex = 7;
            // 
            // textZ
            // 
            this.textZ.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textZ.Location = new System.Drawing.Point(443, 58);
            this.textZ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textZ.Name = "textZ";
            this.textZ.Size = new System.Drawing.Size(175, 27);
            this.textZ.TabIndex = 9;
            // 
            // textH
            // 
            this.textH.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textH.Location = new System.Drawing.Point(443, 100);
            this.textH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textH.Name = "textH";
            this.textH.Size = new System.Drawing.Size(175, 27);
            this.textH.TabIndex = 10;
            // 
            // textL
            // 
            this.textL.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textL.Location = new System.Drawing.Point(109, 61);
            this.textL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textL.Name = "textL";
            this.textL.Size = new System.Drawing.Size(175, 27);
            this.textL.TabIndex = 17;
            this.textL.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(27, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "序号：";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // textY
            // 
            this.textY.Font = new System.Drawing.Font("宋体", 11F);
            this.textY.FormattingEnabled = true;
            this.textY.Items.AddRange(new object[] {
            "高岭石类",
            "蒙脱石类",
            "伊利石类",
            "水铝英石类"});
            this.textY.Location = new System.Drawing.Point(443, 18);
            this.textY.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textY.Name = "textY";
            this.textY.Size = new System.Drawing.Size(175, 26);
            this.textY.TabIndex = 19;
            // 
            // 取消
            // 
            this.取消.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.取消.Cursor = System.Windows.Forms.Cursors.Default;
            this.取消.ForeColor = System.Drawing.Color.White;
            this.取消.Image = ((System.Drawing.Image)(resources.GetObject("取消.Image")));
            this.取消.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.取消.Location = new System.Drawing.Point(421, 150);
            this.取消.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.取消.Name = "取消";
            this.取消.Size = new System.Drawing.Size(88, 37);
            this.取消.TabIndex = 18;
            this.取消.Text = "取消";
            this.取消.UseVisualStyleBackColor = false;
            this.取消.Click += new System.EventHandler(this.取消_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(161)))), ((int)(((byte)(243)))));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Image = global::演示建立表1.Properties.Resources.保存;
            this.btnSubmit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubmit.Location = new System.Drawing.Point(154, 150);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(88, 37);
            this.btnSubmit.TabIndex = 15;
            this.btnSubmit.Text = "提交";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // FrmpInsertwater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(653, 217);
            this.Controls.Add(this.textY);
            this.Controls.Add(this.取消);
            this.Controls.Add(this.textL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.textH);
            this.Controls.Add(this.textZ);
            this.Controls.Add(this.textX);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.JingHao);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmpInsertwater";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "水化作用录入";
            this.Load += new System.EventHandler(this.FrmpInsert_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmpInsertwater_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox JingHao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textX;
        private System.Windows.Forms.TextBox textZ;
        private System.Windows.Forms.TextBox textH;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox textL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button 取消;
        private System.Windows.Forms.ComboBox textY;
    }
}